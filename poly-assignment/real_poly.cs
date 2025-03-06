using System;
public class Food
{
    public void order(string item)
    {
        Console.WriteLine($"ordering 1 {item}");
    }
    public void order(string item,int quantity)
    {
        Console.WriteLine($"ordering {quantity} {item}(s)");
    }
    public virtual void prepare()
    {
        Console.WriteLine("preparing food.....");
    }
}

public class Burger : Food
{
    public override void prepare()
    {
        Console.WriteLine("burger is preparing.....");
    }
}

public class Pizza : Food
{
    public override void prepare()
    {
        Console.WriteLine("Pizza is preparing......");
    }
}

// class First
// {
//     static void main()
//     {
//         //compile time polymorphism
//         Food food = new Food();
//         food.order("burger");
//         food.order("pizza",3);

//         //run time polymorphism
//         Burger burger = new Burger();
//         burger.prepare();
//         Pizza pizza = new Pizza();
//         pizza.prepare();
//     }
// }