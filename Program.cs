using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_year_is_leap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year");
            int year = int.Parse(Console.ReadLine());
            if (((year % 400 == 0) && (year % 100 = 0) || (year % 4 = 0)))
                Console.WriteLine("leap yaer", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);
            Console.WriteLine();
        }
    }
}
