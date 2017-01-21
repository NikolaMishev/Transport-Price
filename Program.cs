using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportpricee
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var dOrN = Console.ReadLine();

            if (dOrN == "day")
            {
                if (km < 19.9)
                {
                    Console.WriteLine(0.7 + (km * 0.79));
                }
                else if (km >= 20 && km <= 99.9)
                {
                    Console.WriteLine(km * 0.09);
                }
                else if (km >= 100)
                {
                    Console.WriteLine(km * 0.06);
                }

            }
            else
            {
                if (km < 19.9)
                {
                    Console.WriteLine(0.70 + (km * 0.90));
                }
                else if (km >= 20 && km <= 99.9)
                {
                    Console.WriteLine(km * 0.09);
                }
                else if (km >= 100)
                {
                    Console.WriteLine(km * 0.06);
                }
            }
        }
    }
}
