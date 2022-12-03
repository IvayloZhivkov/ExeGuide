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
       public bool ExistById(string id) => context.Users.Any(u=>u.Id == id);

      public string GetUserId(string userId) => this.context.Users.FirstOrDefault(a => a.Id == userId).Id;



       public IdentityUser GetUserById(string userId) => context.Users.FirstOrDefault(a => a.Id == userId);
       

      
        public void AddNewUser(TrainingUser user)
        {
            context.Add(user);
            context.SaveChanges();
        }
    }
}
