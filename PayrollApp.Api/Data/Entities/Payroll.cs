using PayrollApp.Api.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public class Payroll : BaseEntity
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime PayDay { get; set; }
        public PayrollStatus Status { get; set; }
        public ICollection<Payslip> Payslips { get; set; }
        public decimal? StaffSalary { get; set; }
    }
}
