namespace ECommerce.Application.Dto.Categories;

public record CreateCategoryRequest
{
    public required string Name { get; set; }
    
    public List<CreateCategoryRequest>? Children { get; set; }
}