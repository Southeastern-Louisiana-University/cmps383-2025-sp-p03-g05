using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Selu383.SP25.P03.Api.Data;
using Selu383.SP25.P03.Api.Features.Users;

namespace Selu383.SP25.P03.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<Role> roleManager;
        private readonly DataContext dataContext;
        private readonly DbSet<Role> roles;

        public UsersController(
            RoleManager<Role> roleManager,
            UserManager<User> userManager,
            DataContext dataContext)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.dataContext = dataContext;
            roles = dataContext.Set<Role>();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<UserDto>> CreateUser([FromBody] CreateUserDto dto)
        {
            if (dto.Roles == null || !dto.Roles.Any() || !dto.Roles.All(x => roles.Any(y => x == y.Name)))
            {
                return BadRequest("Invalid roles provided.");
            }

            var newUser = new User { UserName = dto.Username };

            var result = await userManager.CreateAsync(newUser, dto.Password);
            if (!result.Succeeded)
            {
                return BadRequest("Failed to create user.");
            }

          
            var user = await userManager.FindByNameAsync(dto.Username);
            if (user == null)
            {
                return BadRequest("User not found after creation.");
            }

            var roleResult = await userManager.AddToRolesAsync(user, dto.Roles);
            if (!roleResult.Succeeded)
            {
                return BadRequest("Failed to assign roles.");
            }

            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName!,
                Roles = dto.Roles
            };
        }
    }
}
