using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> AllProducts()
    {
        return new string[]{
            "Product 1",
            "Product 2"
        };
    }
}