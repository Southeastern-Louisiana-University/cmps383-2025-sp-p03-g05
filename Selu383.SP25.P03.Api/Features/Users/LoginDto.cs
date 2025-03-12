namespace Selu383.SP25.P03.Api.Features.Users
{
    public class LoginDto
    {
        public required string UserName { get; set; } = string.Empty;
        public required string Password { get; set; } = string.Empty;
    }
}


