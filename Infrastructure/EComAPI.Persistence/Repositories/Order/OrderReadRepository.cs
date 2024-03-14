using System.Linq.Expressions;
using EComAPI.Application.Repositories.Order;
using EComAPI.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Entity = EComAPI.Domain.Entities;


namespace EComAPI.Persistence.Repositories.Order;

public class OrderReadRepository : ReadRepository<Entity.Order>, IOrderReadRepository
{
    public OrderReadRepository(EComDbContext context) : base(context)
    {
    }
}
