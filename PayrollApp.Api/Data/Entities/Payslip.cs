using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public class Payslip : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PayrollId { get; set; }
        public Payroll Payroll { get; set; }
        public Deduction Deduction { get; set; }
        public ICollection<SalaryComponent> SalaryComponents { get; set; }
        public ICollection<AdditionalPayment> AdditionalPayments { get; set; }
        public ICollection<AdditionalDeduction> AdditionalDeductions { get; set; }

    }
}
