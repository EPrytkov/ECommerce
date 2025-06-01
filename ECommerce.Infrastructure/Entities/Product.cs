﻿namespace ECommerce.Infrastructure.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; } = null!;
    
    public decimal Price { get; set; }
    
    public int Quantity { get; set; }
    
    public int CategoryId { get; set; }
    
    public Category Category { get; set; } = null!;
}