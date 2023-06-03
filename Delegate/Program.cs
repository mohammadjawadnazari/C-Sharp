using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {

        static public int sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static public int sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static public int ul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static public int div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public delegate int worker(int x, int y);
        static void Main(string[] args)
        {
            int w = 90, z = 100;
            worker Mathman = new worker(Sum);
            Mathman += sum;
            Mathman -= sub;
            Mathman *= mul;
            Mathman /= div;
        }
    }
}
