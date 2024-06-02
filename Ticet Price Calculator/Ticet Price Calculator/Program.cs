using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticet_Price_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int fullPrice = 10;
            const int discountedPrice = 7;

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            int ticketPrice = (age >= 65 || age <= 12) ? discountedPrice : fullPrice;

            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
    }
}
