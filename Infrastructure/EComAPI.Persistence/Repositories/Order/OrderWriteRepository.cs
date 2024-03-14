using EComAPI.Application.Repositories.Order;
using EComAPI.Persistence.EFCore;
using Entity = EComAPI.Domain.Entities;


namespace EComAPI.Persistence.Repositories.Order;

public class OrderWriteRepository : WriteRepository<Entity.Order>, IOrderWriteRepository
{
    public OrderWriteRepository(EComDbContext context) : base(context)
    {
    }
}
