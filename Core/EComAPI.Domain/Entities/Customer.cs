using EComAPI.Domain.Entities.Common;

namespace EComAPI.Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; } = null!;

    public ICollection<Order> Orders { get; set; }
}
