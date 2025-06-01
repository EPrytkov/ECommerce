using ECommerce.Application.Dto.Categories;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoriesService _categoriesService;

    public CategoriesController(ICategoriesService categoriesService)
    {
        _categoriesService = categoriesService;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateCategoryRequest request)
    {
        return Ok(await _categoriesService.CreateCategoryAsync(request, HttpContext.RequestAborted));
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _categoriesService.GetAllAsync(HttpContext.RequestAborted));
    }
    
    [HttpGet("parents")]
    public async Task<IActionResult> GetAllParentsAsync()
    {
        return Ok(await _categoriesService.GetAllParentsAsync(HttpContext.RequestAborted));
    }
}