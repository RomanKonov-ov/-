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

       
        /*[HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            // TODO: доделай по аналогии
            return null;
        }*/

        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
            // TODO: доделай по аналогии
            _userManager.Users.
            return null;
        }


        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            // TODO: доделай по аналогии
            return null;
        }

    
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // TODO: доделай по аналогии
            //User user = await _userManager.DeleteAsync(id);
            /*if ()
            {

            }*/
            return null;
        }
    }
}