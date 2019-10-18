using System;
using System.Collections.Generic;

namespace merda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> correctNamesUser = new List<string>();

            correctNamesUser.Add("F");          

            if (correctNamesUser.Contains("popop"))
            {
                Console.WriteLine("sim");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
