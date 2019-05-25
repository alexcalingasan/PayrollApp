using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Api.Data.Enums
{
    public enum PayrollStatus
    {
        Created,
        InProgress,
        WaitingForApproval,
        Approved,
        WaitingForPayment,
        Completed
    }
}
