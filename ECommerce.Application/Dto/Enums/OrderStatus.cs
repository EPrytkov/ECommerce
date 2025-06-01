namespace ECommerce.Application.Dto.Enums;

public enum OrderStatus
{
    Created = 0,
    InPending = 1,
    Confirmed = 2,
    Failed = 3,
    Expired = 4,
    OnHold = 5,
    Shipped = 6,
    AwaitingPickUp = 7,
    Completed = 8,
    Cancelled = 9,
    Refunded = 10
}