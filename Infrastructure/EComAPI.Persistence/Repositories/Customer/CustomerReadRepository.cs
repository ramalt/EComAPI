using EComAPI.Application.Repositories.Customer;
using EComAPI.Persistence.EFCore;
using Entity = EComAPI.Domain.Entities;


namespace EComAPI.Persistence.Repositories.Customer;

public class CustomerReadRepository : ReadRepository<Entity.Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(EComDbContext context) : base(context)
    {
    }
}
