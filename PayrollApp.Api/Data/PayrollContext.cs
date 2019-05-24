using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Api.Data.Entities;

namespace PayrollApp.Api.Data
{
    public class PayrollContext : IdentityDbContext<User>
    {
        public PayrollContext(DbContextOptions<PayrollContext> options) :base(options)
        {
        }
    }
}