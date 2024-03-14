using EComAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace EComAPI.Application.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    public DbSet<T> Table { get; }
}
