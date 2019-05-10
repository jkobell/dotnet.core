using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using RazorPagesNorthwind.Models;

namespace RazorPagesNorthwind
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private string _contentRootPath = "";
        private string conn = "";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {           

            _contentRootPath = env.ContentRootPath;

            //here the %CONTENTROOTPATH% is replaced
            conn = Configuration.GetConnectionString("RazorPagesNorthwindContext");
            if (conn.Contains("%CONTENTROOTPATH%"))
            {
                conn = conn.Replace("%CONTENTROOTPATH%", _contentRootPath);
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }

       





        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //original connection to DB in absolute path
            //services.AddDbContext<RazorPagesNorthwindContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("RazorPagesNorthwindContext")));

            //Connection to the data source within APP_DATA is made
            services.AddDbContext<RazorPagesNorthwindContext>(options =>
                   options.UseSqlServer(conn));

        }


        

        
    }
}
