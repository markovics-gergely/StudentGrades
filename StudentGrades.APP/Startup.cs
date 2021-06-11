using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentGrades.APP.Data;
using StudentGrades.BLL.DTOs;
using StudentGrades.BLL.Interfaces;
using StudentGrades.BLL.Services;
using StudentGrades.DAL;
using System;

namespace StudentGrades.APP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var inMemoryStudents = new SqliteConnection(Configuration["ConnectionStrings:StudentsConnection"]);
            inMemoryStudents.Open();
            services.AddDbContext<NorthwindContext>(options =>
            {
                options.UseSqlite(inMemoryStudents, builder => builder.MigrationsHistoryTable("__EFMigrationsHistory"));
            });

            services.AddDatabaseDeveloperPageExceptionFilter();

            var inMemoryApp = new SqliteConnection(Configuration.GetConnectionString("DefaultConnection"));
            inMemoryApp.Open();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(
                    inMemoryApp, builder => builder.MigrationsHistoryTable("__EFMigrationsHistory"));
            });
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAutoMapper(config => config.AddProfile(new StudentGradesProfile()));

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddTransient<IStudentService, StudentService>();

            services.AddScoped<IStudentService, StudentService>();

            services.AddControllersWithViews();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddMvcCore();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext applicationDbContext, NorthwindContext northwindContext)
        {
            if (applicationDbContext.Database.EnsureDeleted())
            {
                applicationDbContext.Database.Migrate();

                var services = app.ApplicationServices;
                using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {
                    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
                    var user = new IdentityUser { UserName = "admin" };
                    userManager.CreateAsync(user, "edutest2021");
                }
            }

            if (northwindContext.Database.EnsureDeleted())
            {
                northwindContext.Database.Migrate();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
