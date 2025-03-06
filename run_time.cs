using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    class Overriding
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Overriding
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Overriding
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    //class Second_two
    //{
    //    static void Main()
    //    {
    //        Animal myAnimal = new Animal();
    //        myAnimal.MakeSound();  

    //        Animal myDog = new Dog();
    //        myDog.MakeSound(); 

    //        Animal myCat = new Cat();
    //        myCat.MakeSound();  
    //    }
    //}
}
