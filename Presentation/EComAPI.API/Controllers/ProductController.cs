using EComAPI.Application.Dtos.Products;
using EComAPI.Application.Repositories.Product;
using EComAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EComAPI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductReadRepository _readRepo;
    private readonly IProductWriteRepository _writeRepo;

    public ProductController(IProductWriteRepository writeRepo, IProductReadRepository readRepo)
    {
        _writeRepo = writeRepo;
        _readRepo = readRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetProducts()
    {
        var res = _readRepo.GetAll();
        return Ok(res);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto product)
    {

        Product model = new()
        {
            Id = Guid.NewGuid(),
            Name = product.Name,
            Price = product.Price,
            Stock = product.Stock,


        };
        await _writeRepo.AddAsync(model);

        await _writeRepo.SaveAsync();


        return Ok(model);
    }

}
