using PayrollApp.Api.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public class SalaryComponent : BaseEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PayslipId { get; set; }
        public Payslip Payslip { get; set; }
        public int PayrollId { get; set; }
        public Payroll Payroll { get; set; }
        public decimal? SalaryRate { get; set; }
        public decimal? DailyRate { get; set; }
        public decimal? DailyCola { get; set; }
        public decimal? OrdinaryDays { get; set; }
        public decimal? RestDay { get; set; }
        public decimal? SpecialHoliday { get; set; }
        public decimal? RegularHoliday { get; set; }
        public decimal? RestDaySpecialHoliday { get; set; }
        public decimal? RestDayRegularHoliday { get; set; }
        public decimal? OrdinaryDaysPay { get; set; }
        public decimal? RestDayPay { get; set; }
        public decimal? SpecialHolidayPay { get; set; }
        public decimal? RegularHolidayPay { get; set; }
        public decimal? RestDaySpecialHolidayPay { get; set; }
        public decimal? RestDayRegularHolidayPay { get; set; }
        public decimal? Total { get; set; }
        public SalaryComponentType Type { get; set; }
    }
}
