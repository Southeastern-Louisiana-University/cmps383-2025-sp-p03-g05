using Microsoft.AspNetCore.Identity;

namespace Selu383.SP25.P03.Api.Features.Users
{
    public class UserRole : IdentityUserRole<int>
    {
        public required virtual User User { get; set; } = new User();
        public required virtual Role Role { get; set; } = new Role();
    }
}

