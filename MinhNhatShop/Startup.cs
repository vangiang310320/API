using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RepositoryLayer.Repository;
using RepositoryLayer;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.CategorySevice;
using ServiceLayer.CategoryService;
using DomainLayer.DTO.Profile;
using ServiceLayer.CustomerService;
using ServiceLayer.MenuService;
using ServiceLayer.OrderDetailService;
using ServiceLayer.OrderService;
using ServiceLayer.ProductColorService;
using ServiceLayer.ProductImageService;
using ServiceLayer;
using ServiceLayer.ProductService;
using ServiceLayer.ProductSizeService;
using ServiceLayer.SlideService;
using ServiceLayer.SupplierService;
using ServiceLayer.UserService;

namespace MinhNhatShop
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
            services.AddCors();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MinhNhatShop", Version = "v1" });
            });
            services.AddDbContext<MinhNhatShopDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("conn")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductColorService, ProductColorService>();
            services.AddTransient<IProductSizeService, ProductSizeService>();
            services.AddTransient<IProductImageService, ProductImageService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISlideService, SlideService>();
            services.AddTransient<ISupplierService, SupplierService>();
            services.AddTransient<IUserService, UserService>();
            //Map
            var config = new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile(new ApplicationProfile());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MinhNhatShop v1"));
            }
            app.UseHttpsRedirection();
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}