using Microsoft.AspNetCore.Identity;
using PayrollApp.Api.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Entities
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public User User { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
    }
}
