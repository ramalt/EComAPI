using EComAPI.Application.Repositories.Customer;
using EComAPI.Application.Repositories.Order;
using EComAPI.Application.Repositories.Product;
using EComAPI.Persistence.EFCore;
using EComAPI.Persistence.Repositories.Customer;
using EComAPI.Persistence.Repositories.Order;
using EComAPI.Persistence.Repositories.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EComAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<EComDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));

        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
    }

}
