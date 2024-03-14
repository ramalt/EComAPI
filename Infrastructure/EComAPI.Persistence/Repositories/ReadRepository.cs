using System.Linq.Expressions;
using EComAPI.Application.Repositories;
using EComAPI.Domain.Entities.Common;
using EComAPI.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;

namespace EComAPI.Persistence.Repositories;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly EComDbContext _context;

    public ReadRepository(EComDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();


    public IQueryable<T> GetAll(bool tracking = false) => tracking ? Table : Table.AsNoTracking();

    public async Task<T?> GetByIdAsync(string id, bool tracking = false)
    {
        var query = Table.AsQueryable();

        if (!tracking)
            query = Table.AsNoTracking();

        return await query.FirstOrDefaultAsync(t => t.Id == new Guid(id));
    }

    public async Task<T?> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = false)
    {
        var query = Table.AsQueryable();

        if (!tracking)
            query = Table.AsNoTracking();

        return await query.FirstOrDefaultAsync(expression);
    }

    public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = false)
    {
        var query = Table.Where(expression);

        return tracking ? query : query.AsNoTracking();
    }

}
