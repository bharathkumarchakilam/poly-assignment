using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_assignment
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    class Dog2 : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }

        public new void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }
    }

    class Fourth
    {
        static void Main()
        {
            Animal myAnimal = new Animal();
            myAnimal.MakeSound();
            myAnimal.Sleep();

            Dog2 myDog = new Dog2();
            myDog.MakeSound();
            myDog.Sleep();

            Animal anotherDog = new Dog2();
            anotherDog.MakeSound();
            anotherDog.Sleep();
        }
    }
}
