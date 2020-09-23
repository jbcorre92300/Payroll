using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Models
{
    public class CommissionEmployee : Employee
    {
        public CommissionEmployee(string firstname, string lastname, string socialSecurityNumber)
            : base(firstname, lastname, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 2.0M;
        }
    }
}
