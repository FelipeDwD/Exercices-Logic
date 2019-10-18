using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercise8
{
    class Student
    {
        private double _average;
        public string Nome { get; set; }

        public double Pr1 { get; set; }

        public double Pr2 { get; set; }

        public string Situation { get; private set; }

        public Student(string nome, double pr1, double pr2)
        {
            Nome = nome;
            Pr1 = pr1;
            Pr2 = pr2;
            Average = (Pr1 + Pr2) / 2;
        }

        public double Average
        {
            get { return _average; }
            private set
            {
                _average = value;

                if (Average >= 6.0)
                {
                    Situation = "approved!";
                }
                else
                {
                    Situation = "disapproved!";
                }
            }
        }

        public override string ToString()
        {
            return $"\nName: {Nome}" +
                $"\nPr1: {Pr1.ToString("F1", CultureInfo.InvariantCulture)}" +
                $"\nPr2: {Pr2.ToString("F1", CultureInfo.InvariantCulture)}" +
                $"\nAverage: {Average.ToString("F1", CultureInfo.InvariantCulture)}" +
                $"\nSituation: {Situation}";
        }
    }
}
