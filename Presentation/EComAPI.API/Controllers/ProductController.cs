using EComAPI.Application.Repositories.Product;
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

}
