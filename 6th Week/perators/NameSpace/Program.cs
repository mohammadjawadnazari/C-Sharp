using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NameSpace2;

namespace NameSpace1
{
    class C1
    {
        public void F1()
        {
            Console.WriteLine("Your in NameSpace \"F1\" and class \"C1\" and function \"F1\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //C1 obj1 = new C1();
            NameSpace1.C1 obj1 = new NameSpace1.C1();
            NameSpace2.C1 obj2 = new NameSpace2.C1();
            obj1.F1();
            obj2.F1();

            Console.ReadLine();
            //string ans;
            //Console.WriteLine("Enter your ans");
            //ans = Console.ReadLine();
            //A.print(ans);
            //Console.ReadLine();
        }
    }
}
namespace NameSpace2
{
    class C1
    {
        public void F1()
        {
            Console.WriteLine("Your in NameSpace \"F2\" and class \"C1\" and function \"F1\"");
        }
    }
    //class A
    //{
    //    static public void print(string x)
    //    {
    //        Console.WriteLine(x);
    //    }
    //}
}
