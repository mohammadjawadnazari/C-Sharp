using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 4, 6, 8, 10 };
            //for(int i=0;i<4;i++)
            //{
            //    a[i] = a[i] + 3;
            //}
            int j = 0;
            foreach (int i in a)
            {
                j = i + 3;
            }

            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(a[i] + "\t");
            //}
            foreach (int i in a)
            {
                Console.Write(i + "\t");
            }
            Console.ReadLine();
        }
    }
}
