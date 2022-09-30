using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unary
{
    internal class Class2
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" enter number");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
        
    }
}
