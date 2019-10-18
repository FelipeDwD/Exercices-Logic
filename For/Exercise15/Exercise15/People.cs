using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercise15
{
    class People
    {
        private double _salary;
        public double Tax { get; private set; }
        public string Name { get; set; }
        

        public People(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                if (Salary < 600.00)
                {
                    Tax = 0.0;
                }
                else if (Salary >= 600.00 && Salary < 1499.99)
                {
                    Tax = 0.1;
                }
                else
                {
                    Tax = 0.15;
                }
            }
        }

        

        public void ChargeTax()
        {
            double valueTax = Tax * Salary;
            Salary -= valueTax;
        }

        public override string ToString()
        {
            string pay = "";

            if (Salary <= 600.00)
            {
                pay = "não";
            }
            else
            {
                pay = "sim";
            }

            return $"\nName: {Name}" +
                $"\nPay tax: {pay}" +
                $"\nAdjusted salary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
