﻿namespace ECommerce.Infrastructure.Entities;

public class Order : BaseEntity
{
    public Guid UserId { get; set; }
    
    public Guid ProductId { get; set; }
    
    public int Quantity { get; set; }
}