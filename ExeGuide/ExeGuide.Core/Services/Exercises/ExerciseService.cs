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

namespace ExeGuide.Core.Services.Exercises
{
    public class ExerciseService  : IExerciseService
    {
        public readonly ExeGuideDbContext data;
        public readonly IUserService user;

        public ExerciseService(ExeGuideDbContext data, IUserService _user)
        {
            this.data = data;
            this.user = _user;
        }

        public ExercisesQueryModel All( string searchTerm = null, string mainCategory = null,string subCategory = null, string equipment = null,int currPage = 1, int exercisesPerPage = 1)
        {
            var exerciseQuery = this.data.Exercises.AsQueryable();

            if (!string.IsNullOrWhiteSpace(mainCategory) )
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

        public IEnumerable<string> AllEquipmentNames()=> this.data.Equipments.Select(c => c.Name).Distinct().ToList();
        public IEnumerable<string> AllMainCategoriesNames() =>  this.data.MainCategories.Select(c => c.MainCategoryName).Distinct().ToList();
        public IEnumerable<string> AllSubCategoriesNames()=>this.data.SubCategories.Select(c => c.SubCategoryName).Distinct().ToList();
            
        

        public IEnumerable<ExerciseIndexServiceModel> AllShowingSlide() =>
            this.data
            .Exercises
            .Select(e => new ExerciseIndexServiceModel
            {
                Id = e.Id,
                Title = e.Name,
                ImageUrl = e.ImageUrl
            });

        public ExerciseDetailsServiceModel ExerciseDetailsById(int id)=> data.Exercises
                .Where(e=>e.Id == id)
                .Select(e=> new ExerciseDetailsServiceModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Description = e.Description,
                    ImageUrl = e.ImageUrl,
                    MainCategory = e.MainCategory.MainCategoryName,
                    SubCategory = e.SubCategory.SubCategoryName,
                    Equipment = e.Equipment.Name,
                }).FirstOrDefault();

        public bool Exists(int id) => data.Exercises.Any(h => h.Id == id);

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



        public void AddToFav(int userId, int exerciseId)
        {
            
            TrainingUsersExercise userExercises = new TrainingUsersExercise()
            {
               ExerciseId = exerciseId,
              // UserId = userId
            };
            if (!data.TrainingUsersExercises.Contains(userExercises))
            {
            data.TrainingUsersExercises.AddAsync(userExercises);
            data.SaveChanges();
            }
                return;


        }
    }
}
