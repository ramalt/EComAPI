using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComAPI.Application.Repositories.Product;
using EComAPI.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Entity = EComAPI.Domain.Entities;


namespace EComAPI.Persistence.Repositories.Product;

public class ProductWriteRepository : WriteRepository<Entity.Product>, IProductWriteRepository
{
    public ProductWriteRepository(EComDbContext context) : base(context)
    {
    }
}
