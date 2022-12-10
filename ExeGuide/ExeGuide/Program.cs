
using ExeGuide.Core.Services.Articles;
using ExeGuide.Core.Services.Exercises;
using ExeGuide.Core.Services.Users;
using ExeGuide.DataBase.Data;
using ExeGuide.DataBase.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("MyConnectionLaptop");
builder.Services.AddDbContext<ExeGuideDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ExeGuideDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IExerciseService, ExerciseService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IArticleService, ArticleService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error/Error/500");
    app.UseStatusCodePagesWithRedirects("/Error/Error?statusCode={0}");
    app.UseHsts();
}
//Seeding the roles and users with roles
app.SeedEditorRole();
app.SeedEditor();
app.SeedWriterRole();
app.SeedWriter();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "default",
      pattern: "{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Editor}/{action=Index}/{id?}"
    );
    endpoints.MapControllerRoute(
           name: "areas",
           pattern: "{area:exists}/{controller=Writer}/{action=Index}/{id?}"
         );

    endpoints.MapControllerRoute(
      name: "exerciseDescription",
      pattern: "Exercise/Description/{id}/{information}"
    );

    endpoints.MapRazorPages();
});
app.MapRazorPages();

app.Run();
