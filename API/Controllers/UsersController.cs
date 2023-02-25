using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //localhost:8989/api/users
    public class UsersController : ControllerBase //takes the name before the Controller, in this case User
    {
        private readonly DataContext _context;

        public UsersController(DataContext context) //Dependency injection by constructor
        {
            _context = context;

        }

        [HttpGet]//like Request Mapping in spring
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);

        }
    }
}