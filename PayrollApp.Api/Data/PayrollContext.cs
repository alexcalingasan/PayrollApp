using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PayrollApp.Api.Data.Entities;
using System.Linq;

namespace PayrollApp.Api.Data
{
    public class PayrollContext : IdentityDbContext<User>
    {
        public PayrollContext(DbContextOptions<PayrollContext> options) :base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Payslip> Payslips { get; set; }
        public DbSet<SalaryComponent> SalaryComponents { get; set; }
        public DbSet<Deduction> Deductions { get; set; }
        public DbSet<AdditionalPayment> AdditionalPayments { get; set; }
        public DbSet<AdditionalDeduction> AdditionalDeductions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
    }
}