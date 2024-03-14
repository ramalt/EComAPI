using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EComAPI.Application.Repositories;
using EComAPI.Domain.Entities.Common;
using EComAPI.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EComAPI.Persistence.Repositories;

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly EComDbContext _context;

    public WriteRepository(EComDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public async Task<bool> AddAsync(T model)
    {
        EntityEntry<T> entityEntry = await Table.AddAsync(model);

        return entityEntry.State == EntityState.Added;
    }

    public async Task<bool> AddRangeAsync(List<T> model)
    {
        await Table.AddRangeAsync(model);

        return true;
    }

    public bool Remove(T model)
    {
        EntityEntry<T> entityEntry = Table.Remove(model);

        return entityEntry.State == EntityState.Deleted;
    }

    public async Task<bool> Remove(string id)
    {
        T? model = await Table.FirstOrDefaultAsync(t => t.Id == new Guid(id));

        if (model is null)
            return false;

        EntityEntry<T> entityEntry = Table.Remove(model);

        return entityEntry.State == EntityState.Deleted;
    }

    public bool RemoveRange(List<T> model)
    {
        Table.RemoveRange(model);
        return true;
    }

    public bool Update(T model)
    {
        EntityEntry<T> entityEntry = Table.Update(model);

        return entityEntry.State == EntityState.Modified;
    }
    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
}
