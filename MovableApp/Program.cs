using System;

namespace MovableApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To DCIT318 Movable App");
            Console.WriteLine("This program demonstrates how different objects implement movement.");
            Console.WriteLine();

            IMovable car = new Car();

            IMovable bicycle = new Bicycle();

            car.Move();

            bicycle.Move();

            Console.ReadLine();

            Console.WriteLine("Movement completed. Press any key to Exit.");
            Console.ReadKey();
        }
    }
}