using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    class BaseClass
    {
        public void ShowMessage()
        {
            Console.WriteLine("Base class method");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void ShowMessage()
        {
            Console.WriteLine("Derived class method");
        }
    }

    //class Seventh
    //{
    //    static void Main()
    //    {
    //        BaseClass baseObj = new BaseClass();
    //        baseObj.ShowMessage();

    //        DerivedClass derivedObj = new DerivedClass();
    //        derivedObj.ShowMessage();

    //        BaseClass baseRefDerived = new DerivedClass();
    //        baseRefDerived.ShowMessage();
    //    }
    //}
}
