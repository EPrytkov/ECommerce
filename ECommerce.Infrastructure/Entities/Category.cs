using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Infrastructure.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = null!;

    public int? ParentCategoryId { get; set; }
    
    [ForeignKey(nameof(ParentCategoryId))]
    public List<Category> Children { get; set; } = null!;
}