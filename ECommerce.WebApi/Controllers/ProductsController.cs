using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateAsync()
    {
        return Ok("fine");
    }
    
    [HttpGet]
    public IActionResult GetAsync()
    {
        return Ok("fine");
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAsync(int id)
    {
        return Ok("fine");
    }
}