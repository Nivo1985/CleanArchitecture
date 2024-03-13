using AutoMapper;
using CleanArchitecture.Application.MapperProfiles;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MappingProfile());
        });
        var mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
        
        
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        return services;
    }
}