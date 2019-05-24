using Microsoft.AspNetCore.Identity;

namespace PayrollApp.Api.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}