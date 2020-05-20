using System;

namespace Multiple_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy p = new Puppy();
            p.Eat();
            p.Bark();
            p.Weep();
            Console.ReadKey();
        }
    }
}
