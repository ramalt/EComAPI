using EComAPI.Application.Repositories.Product;
using EComAPI.Persistence.EFCore;
using Entity = EComAPI.Domain.Entities;


namespace EComAPI.Persistence.Repositories.Product;

public class ProductReadRepository : ReadRepository<Entity.Product>, IProductReadRepository
{
    public ProductReadRepository(EComDbContext context) : base(context)
    {
    }
}
