using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numerical grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Your Grade is: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your Grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your Grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your letter grade is: D");
            }
            else
            {
                Console.WriteLine("Your Grade is: F");
            }
        }
    }
}
