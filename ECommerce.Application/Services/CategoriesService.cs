using ECommerce.Application.Dto.Categories;
using ECommerce.Application.Services.Interfaces;
using ECommerce.Data.Entities;
using ECommerce.Data.Repositories.Interfaces;
using Mapster;

namespace ECommerce.Application.Services;

public class CategoriesService : ICategoriesService
{
    private readonly ICategoriesRepository _categoriesRepository;

    public CategoriesService(ICategoriesRepository categoriesRepository)
    {
        _categoriesRepository = categoriesRepository;
    }
    
    public Task<Guid> CreateCategoryAsync(CreateCategoryRequest request, CancellationToken cancellationToken)
    {
        var entity = request.Adapt<Category>();
        return _categoriesRepository.CreateAsync(entity, cancellationToken);
    }

    public async Task<List<CategoryDto>> GetAllAsync(CancellationToken cancellationToken)
    {
        return (await _categoriesRepository.GetAllAsync(cancellationToken)).Adapt<List<CategoryDto>>();
    }

    public async Task<List<CategoryDto>> GetAllParentsAsync(CancellationToken cancellationToken)
    {
        return (await _categoriesRepository.GetAllParentsAsync(cancellationToken)).Adapt<List<CategoryDto>>();
    }
}