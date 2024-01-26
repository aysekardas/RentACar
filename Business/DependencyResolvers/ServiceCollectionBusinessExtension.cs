using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtension
    {
        //Extension Method 
        //Metodun ve barındığı class'ın statik olması gerekiyor (private alan varsa ulaşamayacağım)
        //ilk parametre genişleteceğimiz tip olmalı ve başında this keyword'ü olmalı
        public static IServiceCollection AddBusinessServices(this IServiceCollection services,IConfiguration configuration)
        {

            //Singleton : Tek bir nesne oluşturur ve herkese onu verir.
            //services.AddSingleton<IBrandService, BrandManager>();
            //services.AddSingleton<IBrandDal, InMemoryBrandDal>();
            //services.AddSingleton<BrandBusinessRules>();


            //Fluent yapı;
            services
                .AddSingleton<IBrandService, BrandManager>()
                .AddSingleton<IBrandDal, InMemoryBrandDal>()
                .AddSingleton<BrandBusinessRules>();
            /*builder.Services.AddScoped<Random>();*/ //new Random

            //Http request gelince bir scope açılıyor, o isteğe özel bu kısmı oluşturabilirim;(O Scope her açıldığında o scope'a özel referans veriyor.
            //builder.Services.AddTransient<BrandBusinessRules>();
            services
                .AddSingleton<IModelService, ModelManager>()
                .AddSingleton<IModelDal, InMemoryModelDal>()
                .AddSingleton<ModelBusinessRules>();



            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi

            //Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

            services.AddDbContext<RentACarContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"
                )));
            return services;
        }

    }
}