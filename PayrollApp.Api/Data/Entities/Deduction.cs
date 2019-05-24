using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public class Deduction : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PayslipId { get; set; }
        public Payslip Payslip { get; set; }
        public int PayrollId { get; set; }
        public Payroll Payroll { get; set; }
        public decimal? LateHour { get; set; }
        public decimal? LateMinute { get; set; }
        public decimal? Lates { get; set; }
        public decimal? AbsentDay { get; set; }
        public decimal? Absences { get; set; }
        public decimal? SSS { get; set; }
        public decimal? PhilHealth { get; set; }
        public decimal? HDMF { get; set; }
        public decimal? CashAdvance { get; set; }
        public decimal? SSSLoan { get; set; }
        public decimal? HDMFLoan { get; set; }
        public decimal? WithholdingTax { get; set; }
        public decimal? Total { get; set; }

    }
}
