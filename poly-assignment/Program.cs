using System;
//how to real_poly.cs
using namespace Name;
public class Program
{
    static void main()
    {
        //First question
         //compile time polymorphism
        Food food = new Food();
        food.order("burger");
        food.order("pizza",3);

        //run time polymorphism
        Burger burger = new Burger();
        burger.prepare();
        Pizza pizza = new Pizza();
        pizza.prepare();
    }
}