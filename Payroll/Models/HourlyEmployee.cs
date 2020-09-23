using System;
using System.Collections.Generic;
using System.Text;

namespace Payroll.Models
{
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(string firstname, string lastname, string socialSecurityNumber,decimal hourlyawage, decimal hoursworked)
            : base(firstname,lastname,socialSecurityNumber)
        {

        }

        public override decimal Earnings()
        {
            return 3.0M;
        }
    }
}
