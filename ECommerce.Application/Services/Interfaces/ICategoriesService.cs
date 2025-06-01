using ECommerce.Application.Dto.Categories;
using ECommerce.Infrastructure.Entities;

namespace ECommerce.Application.Services.Interfaces;

public interface ICategoriesService
{ 
    Task<Guid> CreateCategoryAsync(CreateCategoryRequest request, CancellationToken cancellationToken);
    
    Task<List<CategoryDto>> GetAllAsync(CancellationToken cancellationToken);
    
    Task<List<CategoryDto>> GetAllParentsAsync(CancellationToken cancellationToken);
}