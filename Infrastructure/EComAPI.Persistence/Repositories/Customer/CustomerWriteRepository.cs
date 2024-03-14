using EComAPI.Application.Repositories.Customer;
using EComAPI.Persistence.EFCore;
using Entity = EComAPI.Domain.Entities;


namespace EComAPI.Persistence.Repositories.Customer;

public class CustomerWriteRepository : WriteRepository<Entity.Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(EComDbContext context) : base(context)
    {
    }

}
