namespace ECommerce.Application.Dto.Categories;

public class CategoryDto
{
    public string Name { get; set; }
    
    public List<CategoryDto> Children { get; set; }
}