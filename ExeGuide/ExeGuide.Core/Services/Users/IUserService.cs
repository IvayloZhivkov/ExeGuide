using ExeGuide.DataBase.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace ExeGuide.Core.Services.Users
{
    public interface IUserService
    {
       bool ExistById(string id);
       string GetUserId(string userId);

      
       IdentityUser GetUserById(string userId);
       

        void AddNewUser(TrainingUser user);
    
    }
}
