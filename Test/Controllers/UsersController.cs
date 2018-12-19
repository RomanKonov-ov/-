using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Test.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_userManager.Users.ToList());

        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return new OkObjectResult(user);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody]User user)
        {
            // TODO: доделай по аналогии
            if (user == null)
            {
                return BadRequest();
            }
            IdentityResult result = await _userManager.CreateAsync(user);

            return new OkObjectResult(user);
        }


        [HttpPut]
        public async Task<IActionResult> Put([FromBody]User model)
        {
            // TODO: доделай по аналогии
            User user = await _userManager.FindByEmailAsync(User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }
            user.Name = model.Name;
            user.Patronymic = model.Patronymic;
            user.Surname = model.Surname;
            user.BirthDate = model.BirthDate;
            IdentityResult result = await _userManager.UpdateAsync(user);

            return new OkObjectResult(user);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Del(string id)
        {
            // TODO: доделай по аналогии
            User user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            IdentityResult result = await _userManager.DeleteAsync(user);

            return new OkObjectResult(user);

        }
    }
}