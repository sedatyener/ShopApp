using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ShopApp.Business.Abstract;
using ShopApp.Business.Concrate;
using ShopApp.DataAccess.Abstract;
using ShopApp.DataAccess.Concrate.EfCore;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.DataAccess.Concrete.Memory;
using ShopApp.WebUI.Middlewares;

namespace ShopApp.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IProductDAL, EfCoreProductDal>();
            services.AddScoped<ICategoryDAL, EfCoreCategoryDal>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                SeedDatabase.Seed();
            }

            app.UseStaticFiles();
            app.CustomStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "adminProducts",
                    template: "admin/products",
                    defaults: new { controller = "Admin", action = "ProductList" }
                    );
                routes.MapRoute(
                    name: "adminProducts",
                    template: "admin/products/{id?}",
                    defaults: new { controller = "Admin", action = "EditProduct" }
                    );

                routes.MapRoute(
                    name: "products",
                    template: "products/{category?}",
                    defaults: new { controller="Shop",action="List" }
                    );
                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=index}/{id?}"
                   );
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
