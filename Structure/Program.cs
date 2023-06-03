using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    class Program
    {
        struct std
        {
            public string Fname, Lname, Pname;
            public int age;
            public double avg;
            public void print()
            {
                Console.WriteLine("name \t Lase Name \t Parent Name \t age \t avg");
                Console.WriteLine(Fname +" \t ");
            }
        }
        static void Main(string[] args)
        {
            std ahmad;
            ahmad.Lname = "mahmoodi";
            ahmad.Fname = "Ahmad";
            ahmad.Pname = "Hasan";
            ahmad.age = 28;
            ahmad.avg = 88;
            Console.ReadLine();
        }
    }
}
