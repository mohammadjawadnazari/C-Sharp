using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int A, B;
            //double C;
            //A = 2;
            //B = 3;

            //C = (double)A / B;
            double A = 6.79;
            int B;
            B = Convert.ToInt32(A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("_________________*************_______________");

            B = 0;
            B = (int)A;
            Console.WriteLine("B = {0}", B);

            //B = 0;
            //B = int.Parse(A);
            //Console.WriteLine("B = {0}", B);

            Console.ReadLine();

        }
    }
}
