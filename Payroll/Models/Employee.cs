using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Payroll.Models
{
    public abstract class Employee
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public string SocialSecurityNumber { get; }
        public Employee(string firstname,string lastname,string socialSecurityNumber)
        {
            Firstname = firstname;//
            Lastname = lastname;
            SocialSecurityNumber = socialSecurityNumber;

        }
        public override string ToString()
        {
            return $"{Firstname} {Lastname}:{SocialSecurityNumber} ";

        }

        public abstract decimal Earnings();
       


    }
}
