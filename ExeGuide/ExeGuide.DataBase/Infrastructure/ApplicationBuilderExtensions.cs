using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ExeGuide.DataBase.Data.Entities;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;
using static ExeGuide.DataBase.Data.Constants.WriterConstants;

namespace ExeGuide.DataBase.Infrastructure
{
    public static class ApplicationBuilderExtensions
    {
        //Here we initialize the editor role to the database
        public static IApplicationBuilder SeedEditorRole(this IApplicationBuilder app)
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
        //Here we connect the editor user to the role
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
                    var role = roleManager.Roles.FirstOrDefault(e => e.Name == EditorRolleName);
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


        //Here we initialize the writer role to the database
        public static IApplicationBuilder SeedWriterRole(this IApplicationBuilder app)
        {
            using var scopedService = app.ApplicationServices.CreateScope();

            var services = scopedService.ServiceProvider;


            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(WriterRolleName))
                    {
                        return;
                    }
                    var role = new IdentityRole { Name = WriterRolleName };
                    await roleManager.CreateAsync(role);
                })
                .GetAwaiter()
                .GetResult();

            return app;

        }
        //Here we connect the writer user to the role
        public static IApplicationBuilder SeedWriter(this IApplicationBuilder app)
        {
            using var scopedService = app.ApplicationServices.CreateScope();

            var services = scopedService.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    var writer = await userManager.FindByNameAsync(WriterEmail);
                    var role = roleManager.Roles.FirstOrDefault(e=>e.Name == WriterRolleName);
                    if (await userManager.IsInRoleAsync(writer, role.Name))
                    {
                        return;
                    }

                    await userManager.AddToRoleAsync(writer, role.Name);
                })
                .GetAwaiter()
                .GetResult();

            return app;

        }
    }
}
