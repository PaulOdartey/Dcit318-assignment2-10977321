
using System;

namespace AnimalSoundApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To DCIT318 Animal Sound App");
            Console.WriteLine("This program demonstrates how different animals make sound.");
            Console.WriteLine();

            Animal genericAnimal = new Animal();

            Dog dog = new Dog();

            Cat cat = new Cat();

            Console.WriteLine("Animal sound:");

            genericAnimal.MakeSound();

            Console.WriteLine("Dog sound:");

            dog.MakeSound(); 

            Console.WriteLine("Cat sound:");

            cat.MakeSound();

            Console.ReadLine();

            Console.WriteLine("Sound completed. Press any key to Exit.");
            Console.ReadKey();
        }
            
    }
}
