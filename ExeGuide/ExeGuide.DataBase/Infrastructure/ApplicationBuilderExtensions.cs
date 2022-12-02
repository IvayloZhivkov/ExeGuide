using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ExeGuide.Data.Entities;
using static ExeGuide.Data.Constants.EditorConstants;

namespace ExeGuide.Core.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder SeedRolle(this IApplicationBuilder app)
        {
            using var scopedService = app.ApplicationServices.CreateScope();

            var services = scopedService.ServiceProvider;

         
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(EditorRolleName))
                    {
                        return;
                    }
                    var role = new IdentityRole { Name = EditorRolleName };
                    await roleManager.CreateAsync(role);
                })
                .GetAwaiter()
                .GetResult();

            return app;

        }
        public static IApplicationBuilder SeedEditor(this IApplicationBuilder app)
        {
            using var scopedService = app.ApplicationServices.CreateScope();
            
            var services = scopedService.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    var editor = await userManager.FindByNameAsync(EditorEmail);
                    var role = roleManager.Roles.FirstOrDefault();
                    if (await userManager.IsInRoleAsync(editor,role.Name))
                    {
                        return;
                    }
                   
                    await userManager.AddToRoleAsync(editor,role.Name);
                })
                .GetAwaiter()
                .GetResult();

            return app;
                
        }
    }
}
