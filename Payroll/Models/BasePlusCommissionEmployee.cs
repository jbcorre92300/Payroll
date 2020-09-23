using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Models
{
    public class BasePlusCommissionEmployee : CommissionEmployee
    {
        public BasePlusCommissionEmployee(string firstname, string lastname, string socialSecurityNumber)
            : base(firstname, lastname, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 4.0M;
        }
    }
}
