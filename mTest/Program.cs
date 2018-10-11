using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an interger value");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine("Number       Squared         Cubed");
            Console.WriteLine("------------------------------------------");

            for (int i = 1; i <= value; i++)
            {
                int squared = Square(i);
                int cubed = Cube(i);
                Console.WriteLine("{0}              {1}             {2}", i, squared, cubed);
                Console.ReadLine();
            }
        }
        private static int Square(int number)
        {
            int answer = number * number;
            return answer;
        }
        private static int Cube(int number)
        {
            int answer = Square(number) * number;
            return answer;
        }
    }
}
