using EComAPI.Domain.Entities.Common;

namespace EComAPI.Domain.Entities;

public class Order : BaseEntity
{
    public string Description { get; set; } = null!;
    public string Address { get; set; } = null!;

    public ICollection<Product> Products { get; set; }
    public Customer Customer { get; set; }
}
