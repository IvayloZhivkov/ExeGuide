using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using ExeGuide.Core.Services.Exercises.Models;
using ExeGuide.Core.Services.Models;
using ExeGuide.Core.Services.Users;
using ExeGuide.Core.Services.Exercises;
using Microsoft.Extensions.Logging;
using System.Net;

namespace ExeGuide.Core.Services.Exercises
{
    public class ExerciseService : IExerciseService
    {
        public readonly ExeGuideDbContext data;
        public readonly IUserService user;

        public ExerciseService(ExeGuideDbContext data, IUserService _user)
        {
            this.data = data;
            this.user = _user;
        }

        /// <summary>
        /// This method gives us all the exercises in the database by the given criteria
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="mainCategory"></param>
        /// <param name="subCategory"></param>
        /// <param name="equipment"></param>
        /// <param name="currPage"></param>
        /// <param name="exercisesPerPage"></param>
        /// <returns></returns>
        public ExercisesQueryModel All(string searchTerm = null, string mainCategory = null, string subCategory = null, string equipment = null, int currPage = 1, int exercisesPerPage = 1)
        {
            var exerciseQuery = this.data.Exercises.AsQueryable();

            if (!string.IsNullOrWhiteSpace(mainCategory))
            {
                exerciseQuery = data.Exercises
                    .Where(h => h.MainCategory.MainCategoryName == mainCategory);
            }
            if (!string.IsNullOrWhiteSpace(subCategory))
            {
                exerciseQuery = data.Exercises
                    .Where(h => h.SubCategory.SubCategoryName == subCategory);
            }
            if (!string.IsNullOrWhiteSpace(equipment))
            {
                exerciseQuery = data.Exercises
                    .Where(h => h.Equipment.Name == equipment);
            }
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                exerciseQuery = exerciseQuery.Where(h =>
                h.Name.ToLower().Contains(searchTerm.ToLower()) ||
                h.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            var exercises = exerciseQuery.Skip((currPage - 1) * exercisesPerPage).Take(exercisesPerPage).Select(h => new ExerciseServiceModel
            {
                Id = h.Id,
                Name = h.Name,
                Description = h.Description,
                ImageUrl = h.ImageUrl
            }).ToList();

            var totalExercises = exerciseQuery.Count();

            return new ExercisesQueryModel()
            {
                TotalExercisesCount = totalExercises,
                Exercises = exercises
            };
        }

        /// <summary>
        /// This method returns all the names in the equipment catagory
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> AllEquipmentNames() => this.data.Equipments.Select(c => c.Name).Distinct().ToList();
        /// <summary>
        /// This method returns all the names in the main catagory
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> AllMainCategoriesNames() => this.data.MainCategories.Select(c => c.MainCategoryName).Distinct().ToList();
        /// <summary>
        /// This method returns all the names in the sub catagory
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> AllSubCategoriesNames() => this.data.SubCategories.Select(c => c.SubCategoryName).Distinct().ToList();



       
        /// <summary>
        /// Return the exercise details by the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ExerciseDetailsServiceModel ExerciseDetailsById(int id) => data.Exercises
                .Where(e => e.Id == id)
                .Select(e => new ExerciseDetailsServiceModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    ImageUrl = e.ImageUrl,
                    MainCategory = e.MainCategory.MainCategoryName,
                    SubCategory = e.SubCategory.SubCategoryName,
                    Equipment = e.Equipment.Name,
                }).FirstOrDefault();

        /// <summary>
        /// Ensures that the given exercise exist in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exists(int id) => data.Exercises.Any(h => h.Id == id);

        /// <summary>
        /// Returns all exercises in the user database
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IEnumerable<ExerciseServiceModel> AllExercisesById(string userId)
        {
            var exercises = data.TrainingUsersExercises.Where(h => h.UserId == userId);
            var realEx = exercises.Select(h => h.Exercise);
            var results = realEx.Select(h => new ExerciseServiceModel
            {
                Id = h.Id,
                Description = h.Description,
                ImageUrl = h.ImageUrl,
                Name = h.Name
            }).ToList();

            return results;
        }


        /// <summary>
        /// Creates a connection between the user and the exercise
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns
        public void AddToFav(string userId, int exerciseId)
        {

            TrainingUsersExercise userExercises = new TrainingUsersExercise()
            {
                ExerciseId = exerciseId,
                UserId = userId
            };
            if (!data.TrainingUsersExercises.Contains(userExercises))
            {
                data.TrainingUsersExercises.AddAsync(userExercises);
                data.SaveChanges();
            }
            return;


        }



        /// <summary>
        /// This methods makes possible to reach the category name
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ExerciseMainCategoryModel> AllMainCategories() =>
            this.data
            .MainCategories
            .Select(c => new ExerciseMainCategoryModel
            {
                Id = c.Id,
                Name = c.MainCategoryName
            })
            .ToList();



        /// <summary>
        /// This methods makes possible to reach the category name
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ExerciseSubCategoryModel> AllSubCategories() =>
            this.data
            .SubCategories
            .Select(c => new ExerciseSubCategoryModel
            {
                Id = c.Id,
                Name = c.SubCategoryName
            })
            .ToList();



        /// <summary>
        /// This methods makes possible to reach the category name
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ExerciseEquipmentModel> AllEquipments() =>
            this.data
            .Equipments
            .Select(c => new ExerciseEquipmentModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToList();




        /// <summary>
        /// Ensures that the current category exists in the database
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool MainCategoryExists(int categoryId) => this.data.MainCategories.Any(c => c.Id == categoryId);



        /// <summary>
        /// Ensures that the current category exists in the database
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool SubCategoryExists(int categoryId) => this.data.SubCategories.Any(c => c.Id == categoryId);
       

       
        /// <summary>
        /// Ensures that the current category exists in the database
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public bool EquipmentExists(int categoryId) => this.data.Equipments.Any(c => c.Id == categoryId);



        /// <summary>
        /// This method adds a newly created exercise
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public int Create(string title, string description, string imgageUrl, int mainCategoryId, int subCategoryId, int equipmentId)
        {

            var ex = new Exercise
            {
                Name = title,
                Description = description,
                ImageUrl = imgageUrl,
                MainCategoryId = mainCategoryId,
                SubCategoryId= subCategoryId,
                EquipmentId = equipmentId
                
            };

            this.data.Exercises.Add(ex);
            this.data.SaveChanges();

            return ex.Id;
        }


        /// <summary>
        /// This method edits the selscted exercise
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public void Edit(int exerciseId,string title, string description, string imgageUrl, int mainCategoryId, int subCategoryId, int equipmentId)
        {
            var exercise = data.Exercises.Find(exerciseId);

            exercise.Name = title;
            exercise.Description = description;
            exercise.ImageUrl = imgageUrl;
            exercise.MainCategoryId = mainCategoryId;
            exercise.SubCategoryId = subCategoryId;
            exercise.EquipmentId = equipmentId;

            this.data.SaveChanges();

            
        }


        /// <summary>
        /// This method deletes the selscted exercise
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns>Deletes a exercise</returns>
        public void Delete(int exerciseId)
        {
            var exerecise = data.Exercises.Find(exerciseId);

            data.Remove(exerecise);
            data.SaveChanges();
        }

        /// <summary>
        /// Removes an exercise from favourites
        /// </summary>
        /// <param name="exerciseId"></param>
        /// <param name="userId"></param>
        public void RemoveFromFavourite(int exerciseId, string userId)
        {
           TrainingUsersExercise ue = data.TrainingUsersExercises.Where(a=>a.UserId ==userId).Where(a=>a.ExerciseId==exerciseId).FirstOrDefault();
            data.Remove(ue);
            int one = 1;
            data.SaveChanges();

        }

        /// <summary>
        /// This method returns the id of a catagory
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public int MainCategoryId(int categoryId) => data.Exercises.Find(categoryId).MainCategoryId;


        /// <summary>
        /// This method returns the id of a catagory
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public int SubCategoryId(int categoryId) => data.Exercises.Find(categoryId).MainCategoryId;


        /// <summary>
        /// This method returns the id of a catagory
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public int EquipmentId(int categoryId) => data.Exercises.Find(categoryId).EquipmentId;

    }
}
