
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MockProject.Data.Interface;
using MockProject.Data.Repository;
using MockProject.Models;
using FluentValidation.AspNetCore;


namespace MockProject
{
    public class Startup
    {
    
        public Startup(IConfiguration configuration)
        {
           
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //Add aduthenticate
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x =>
                {
                    x.AccessDeniedPath = "/Admin/Login/AccessDenied";
                    x.LoginPath = "/Admin/Login/Index";
                });
            //Authorize roles
            services.AddAuthorization(x =>
            {
               
                x.AddPolicy("admin", a => a.RequireAuthenticatedUser().RequireRole("admin"));
                x.AddPolicy("teacher", a => a.RequireAuthenticatedUser().RequireRole("teacher"));
                x.AddPolicy("student", a => a.RequireAuthenticatedUser().RequireRole("student"));
            });
            //DbContext setup

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            //fluent validator
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(fv =>
                {
                    fv.RegisterValidatorsFromAssemblyContaining<FacultyValidator>();
                    fv.RegisterValidatorsFromAssemblyContaining<UserValidator>();
                    fv.RegisterValidatorsFromAssemblyContaining<SubjectValidator>();
                    fv.RegisterValidatorsFromAssemblyContaining<ScheduleValidator>();
                    fv.RegisterValidatorsFromAssemblyContaining<SemesterValidator>();
                    fv.RegisterValidatorsFromAssemblyContaining<TranscriptValidator>();
                });


            //repo
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();

 
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePages();
                app.UseStatusCodePagesWithRedirects("/Error/{0}");
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "MyArea",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
