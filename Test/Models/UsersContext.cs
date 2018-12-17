using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class UsersContext : IdentityDbContext<User>
    {
        public UsersContext(DbContextOptions options) : base(options)
        {
        }
        
    }
}