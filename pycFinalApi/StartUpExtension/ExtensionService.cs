using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using pycFinalApi.Data.Model;
using pycFinalApi.Mapper;
using pycFinalApi.Service;
using pycFinalApi.Service.Offer.Concrete;

namespace pycFinalApi.StartUpExtension
{
    public static class ExtensionService
    {

        public static void AddServices(this IServiceCollection services)
        {
            // services 

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOfferService, OfferService>();
           


            // mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
