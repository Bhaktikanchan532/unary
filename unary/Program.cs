using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = ++a + a++;
            int c = ++b * a++;
            int d = ++c * ++b - ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
