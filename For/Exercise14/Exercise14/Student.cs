using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercise14
{
    class Student
    {
        private double _average;
        public string Name { get; set; }

        public double Note1 { get; set; }

        public double Note2 { get; set; }

        public bool Approved { get; private set; }

        public Student(string name, double note1, double note2)
        {
            Name = name;
            Note1 = note1;
            Note2 = note2;
            Average = (Note1 + Note2) / 2;
        }

        public double Average
        {
            get { return _average; }

            private set
            {
                _average = value;

                if (Average >= 6.0)
                {
                    Approved = true;
                }
                else
                {
                    Approved = false;
                }
            }
        }

        public override string ToString()
        {
            string approved = "";

            if (Approved == true)
            {
                approved = "Yes";
            }
            else
            {
                approved = "No!";
            }

            return $"\nName: {Name}" +
                $"\nAverage: {Average.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nApproved: {approved}";
        }
    }
}
