using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Data.Entities;
using ExeGuide.Core.Services.Exercises.Models;
using Microsoft.AspNetCore.Identity;

namespace ExeGuide.Core.Services.Users
{
    public class UserService : IUserService
    {
        private readonly ExeGuideDbContext context;
        public UserService(ExeGuideDbContext _context)
        {
            context = _context;
        }

        /// <summary>
        /// Checks if the current user exist in the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool ExistById(string id) => context.Users.Any(u => u.Id == id);




        /// <summary>
        /// This method returns the users id upon calling
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetUserId(string userId) => this.context.Users.FirstOrDefault(a => a.Id == userId).Id;




        /// <summary>
        /// This method returns a user by the given id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IdentityUser GetUserById(string userId) => context.Users.FirstOrDefault(a => a.Id == userId);


        /// <summary>
        /// This method adds new user to the databsae 
        /// </summary>
        /// <param name="user"></param>
        public void AddNewUser(TrainingUser user)
        {
            context.Add(user);
            context.SaveChanges();
        }
    }
}
