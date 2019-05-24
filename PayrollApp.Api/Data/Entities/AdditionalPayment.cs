using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public class AdditionalPayment : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PayslipId { get; set; }
        public Payslip Payslip { get; set; }
        public int PayrollId { get; set; }
        public Payroll Payroll { get; set; }
        public decimal? Amount { get; set; }
        public string Description { get; set; }
    }
}
