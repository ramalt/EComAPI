using EComAPI.Domain.Entities.Common;

namespace EComAPI.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    public int Stock { get; set; }
    public float Price { get; set; }
    
    public ICollection<Order> Orders { get; set; }

}
