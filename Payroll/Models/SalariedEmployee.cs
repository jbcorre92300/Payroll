using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Models
{
    public class SalariedEmployee : Employee
    {
        public SalariedEmployee(string firstname, string lastname, string socialSecurityNumber)
            : base(firstname, lastname, socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 1.0M;
        }
    }
}
