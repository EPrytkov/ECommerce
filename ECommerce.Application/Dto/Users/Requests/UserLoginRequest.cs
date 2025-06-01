namespace ECommerce.Application.Dto.Users.Requests;

public class UserLoginRequest
{
    public string Login { get; set; }
    
    public string Password { get; set; }
}