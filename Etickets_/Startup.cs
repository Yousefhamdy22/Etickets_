using eTickets.Data.Cart;
using Etickets_.Data;
using Etickets_.Data.Base;
using Etickets_.Data.services;
using Etickets_.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace Etickets_.services
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
            services.AddDbContext<Eco_Context>(options => options.UseSqlServer(Configuration.GetConnectionString
                ("DefaultConnectionStrings")));

            services.AddSession();
          
            services.AddRazorPages();


            

            // Dependancy injection 
            services.AddScoped< IActor , ActorsService >();
            services.AddScoped< IProducer,ProducerServices>();
            services.AddScoped< ICenima, CinemaServices>();
            services.AddScoped< IMovie , MoviesSevice>();
            services.AddScoped< Iorder , OrderServices >();



            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sc => ShoppingCart.GetShoppingCart(sc));




            //Authentication and authorization
            //services.AddIdentity<ApplicationUser, IdentityRole>().AddUserStore<AppContext>();
            services.AddMemoryCache();
            services.AddSession();
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            // seed DB
           App_Dbinitializer.Seed(app);
            /App_Dbinitializer.seed(app).Wait();

        }
    }
}
