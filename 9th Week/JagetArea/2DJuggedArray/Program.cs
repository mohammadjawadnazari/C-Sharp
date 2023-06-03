using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[][] Rrs;
            //string[][] Rr=new string[3][];
            //string[][] Rr=new string[3] []{ new string [3],new string[4],new string [5]};
            // string[][] Trs = { new string[3] { "ac", "kl", "pl" }, new string[1] { "45" }, new string[2] { "4f", "34" } };
            // int[][,] a = new int[4][,];

            int[][,] a = new int[4][,];
            a[0] = new int[3,2];
            a[1] = new int[5,1];
            a[2] = new int[1,1];
            a[3] = new int[2,2];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter number :");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            int k = 0;
            foreach (int[] x in a)
            {

                Console.Write($"a[{k}]= ");
                foreach (int y in x)
                {
                    Console.Write(y + "\t");
                }
                k++;
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
