using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Car
    {
        private int _year;
        public bool Ipva { get; private set; }

        public string ModelCar { get; set; }

        public string Color { get; set; }

        public Car(string modelcar, string color, int year)
        {
            ModelCar = modelcar;
            Color = color;
            Year = year;
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;

                if (Year <= (2019 - 20))
                {
                    Ipva = false;
                }
                else
                {
                    Ipva = true;
                }
            }
        }

        public override string ToString()
        {
            string haveIpva = "";

            if (Ipva == true)
            {
                haveIpva = "YES";
            }
            else
            {
                haveIpva = "NO"
;            }

            return $"\nModel: {ModelCar}" +
                $"\nYear: {Year}" +
                $"\nColor: {Color}" +
                $"\nIpva: {haveIpva}";
                


        }









    }
}
