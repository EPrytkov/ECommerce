namespace ECommerce.Application.Dto;

public enum PaymentStatus
{
    Pending = 0,
    AwaitingPayment = 1,
    PaymentProcessing = 2,
    Confirmed = 3,
    Cancelled = 4,
    Refund = 5
    
}