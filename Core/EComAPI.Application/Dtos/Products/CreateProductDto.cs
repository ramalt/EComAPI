namespace EComAPI.Application.Dtos.Products;

public class CreateProductDto
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public float Price { get; set; }
}
