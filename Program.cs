using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using poly_assignment;

class Program
{
    static void Main()
    {
        //First question
        ////compile time polymorphism
        //Food food = new Food();
        //food.order("burger");
        //food.order("pizza", 3);
        ////run time polymorphism
        //Burger burger = new Burger();
        //burger.prepare();
        //Pizza pizza = new Pizza();
        //pizza.prepare();


        //Second question
        //method overloading
        ////Math_operations oper = new Math_operations();
        //Console.WriteLine(oper.Add(5, 10));
        //Console.WriteLine(oper.Add(5, 20, 10));
        //Console.WriteLine(oper.Add(5.2, 9.5));
        ////method overriding
        //Overriding myAnimal = new Overriding();
        //myAnimal.MakeSound();  
        //Overriding myDog = new Dog();
        //myDog.MakeSound();  
        //Overriding myCat = new Cat();
        //myCat.MakeSound();

        ////Third question
        //Overloading payment = new Overloading();
        //payment.MakePayment("1234567812345678", "123");   // Credit Card Payment
        //payment.MakePayment("user@example.com");          // PayPal Payment
        //payment.MakePayment(987654321, 1001);             // Bank Transfer Payment

        ////Fourth question
        //Animal myAnimal2 = new Animal();
        //myAnimal2.MakeSound();
        //myAnimal2.Sleep();

        //Dog2 myDog2 = new Dog2();
        //myDog2.MakeSound();
        //myDog2.Sleep();

        //Animal anotherDog = new Dog2();
        //anotherDog.MakeSound();
        //anotherDog.Sleep();


        ////Fifth question
        ////Abstract class
        //Payment payment1 = new CreditCardPayment();
        //payment1.ProcessPayment(100);
        //payment1.GenerateReceipt();

        //Payment payment2 = new PayPalPayment();
        //payment2.ProcessPayment(50);
        //payment2.GenerateReceipt();

        ////Interface
        //IPayment payment11 = new CreditCard();
        //payment11.ProcessPayment(200);

        //IPayment payment21 = new Bitcoin();
        //payment21.ProcessPayment(300);


        ////Sixth question
        //Vehicle myCar = new Car();
        //myCar.StartEngine();
        //myCar.DisplayInfo();

        //Vehicle myMotorcycle = new Motorcycle();
        //myMotorcycle.StartEngine();
        //myMotorcycle.DisplayInfo();

        //Vehicle myTruck = new Truck();
        //myTruck.StartEngine();
        //myTruck.DisplayInfo();

        ////Seventh question
        //BaseClass baseObj = new BaseClass();
        //baseObj.ShowMessage();

        //DerivedClass derivedObj = new DerivedClass();
        //derivedObj.ShowMessage();

        //BaseClass baseRefDerived = new DerivedClass();
        //baseRefDerived.ShowMessage();

        //Eighth question
        //provided in Eighth.txt

        //Nineth question
        //output: Dog barks


        //Tenth Question
        /*No, we cannot achieve true polymorphism with structs in C#. 
        This is because polymorphism in C# is primarily enabled by inheritance and
        method overriding using virtual and override, which are not supported by structs.*/




    }
}