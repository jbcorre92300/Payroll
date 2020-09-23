using Payroll.Models;
using System;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Payroll....");
            //Employee ee = new Employee("Bruce", "Wayne", "BAT001");
            //Console.WriteLine(ee);

            HourlyEmployee he = new HourlyEmployee("Diana", "Ross", "WW001");
            Console.WriteLine(he);

            CommissionEmployee ce = new CommissionEmployee("Peter", "Parker", "SPIDER001");
            Console.WriteLine(ce);

            SalariedEmployee se = new SalariedEmployee("Bruce", "Banner", "HULK001");
            Console.WriteLine(se);

            BasePlusCommissionEmployee bce = new BasePlusCommissionEmployee("Tony", "Stark", "IRON001");
            Console.WriteLine(bce);
        }
    }
}
