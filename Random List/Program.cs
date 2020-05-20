using System;

namespace Random_List
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList r = new RandomList();
            r.Add("Greeshma");
            r.Add("Rajesh");
            r.Add("Haithem");
            r.Add("Raji");
            r.RandomString();
            for (int i = 0; i <r.Count; i++)
            {
                Console.WriteLine(r[i]);
            }
           
            Console.ReadKey();
        }
    }
}
