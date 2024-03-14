using System.Linq.Expressions;
using EComAPI.Domain.Entities.Common;

namespace EComAPI.Application.Repositories;

public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
{
    IQueryable<T> GetAll(bool tracking = false);
    IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = false);
    Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = false);
    Task<T> GetByIdAsync(string Id, bool tracking = false);
}
