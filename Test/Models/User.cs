using System;
using Microsoft.AspNetCore.Identity;

namespace Test.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
   
}
