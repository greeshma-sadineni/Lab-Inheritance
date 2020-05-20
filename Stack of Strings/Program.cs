using System;
using System.Collections;

namespace Stack_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stackofstrings s = new Stackofstrings();
            s.Push("greeshma");
            s.Push("vinay");
            s.Push("raji");
            s.Push("soya");
            Console.WriteLine(s.IsEmpty());
            Console.WriteLine("poped elenment in the list");
            Console.WriteLine(s.pop());

            Console.WriteLine("peek elenment in the list");
            Console.WriteLine(s.peek());

            
            Console.ReadLine();
        }
    }
}
