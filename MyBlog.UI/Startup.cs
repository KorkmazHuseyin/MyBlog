using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using MyBlogCore.Context;
using MyBlogCore.Identity;
using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


namespace MyBlog.UI
    {
    //public class Startup
    //{
    //    public Startup(IConfiguration configuration)
    //    {
    //        Configuration = configuration;
    //    }

    //    public IConfiguration Configuration { get; }

    //// This method gets called by the runtime. Use this method to add services to the container.
    //public void ConfigureServices(IServiceCollection services)
    //{
    //    services.AddControllersWithViews();
    //    services.AddDbContext<BlogDbContext>(a => a.UseSqlServer(Configuration.GetConnectionString("MyConn")));
    //    services.AddDbContext<BlogDbContext>(a => a.UseSqlServer(Configuration.GetConnectionString("IdentityConn")));

    //    services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<BlogDbContext>();



    //    services.ConfigureApplicationCookie(options =>
    //    {
    //        options.Cookie.HttpOnly = true;
    //        options.ExpireTimeSpan = TimeSpan.FromDays(1);
    //        options.LoginPath = "/Account/Login";
    //        options.AccessDeniedPath = "/Account/AccessDenied";
    //        options.SlidingExpiration = true;

    //    });

    //}

    //    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    //    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    //    {
    //        if (env.IsDevelopment())
    //        {
    //            app.UseDeveloperExceptionPage();
    //        }
    //        else
    //        {
    //            app.UseExceptionHandler("/Home/Error");
    //        }
    //        app.UseStaticFiles();

    //        app.UseRouting();
    //         app.UseAuthentication();

    //         app.UseAuthorization();

    //        app.UseEndpoints(endpoints =>
    //        {
    //            endpoints.MapControllerRoute(
    //                name: "default",
    //                pattern: "{controller=HomePage}/{action=Home}/{id?}");
    //        });



    //    }
    //}



    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<BlogDbContext>(a => a.UseSqlServer(Configuration.GetConnectionString("MyConn")));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<BlogDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(1);
                options.LoginPath = "/Account/Login";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            services.AddScoped<RoleManager<ApplicationRole>>();
            services.AddScoped<UserManager<ApplicationUser>>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=HomePage}/{action=Home}/{id?}");
            });
        }
    }
}
 