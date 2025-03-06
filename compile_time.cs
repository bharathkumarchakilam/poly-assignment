using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    class Math_operations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    //class Second_one
    //{
    //    static void main()
    //    {
    //        Math_operations oper = new Math_operations();
    //        Console.WriteLine(oper.Add(5, 10));
    //        Console.WriteLine(oper.Add(5, 20, 10));
    //        Console.WriteLine(oper.Add(5.2, 9.5));
    //    }
    //}
}
