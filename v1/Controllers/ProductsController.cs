using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("v1/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> AllProducts()
    {
        return new string[]{
            "Product 12",
            "Product 2"
        };
    }
}