using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Type_Identifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the length of side C: ");
            double sideC = Convert.ToDouble(Console.ReadLine());

            string triangleType = GetTriangleType(sideA, sideB, sideC);
            Console.WriteLine($"The triangle is {triangleType}.");
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || b == c || a == c)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
