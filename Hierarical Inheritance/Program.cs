using System;

namespace Hierarical_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog d = new Dog();
            d.Eat();
            d.Bark();
            Cat c = new Cat();
            c.Eat();
            c.Meow();
            Console.ReadKey();
           

        }
    }
}
