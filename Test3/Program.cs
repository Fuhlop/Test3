using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            int jah = 3;
            int x = 0;
            if (x == 1)
            {
                Console.WriteLine("111");
            }
            if (x == 2)
            {
                while (jah >= 0)
                {
                    Console.WriteLine("111");
                    jah--;
                }
            } else
            {
                Console.WriteLine("222");

            }
           //not sure why the jah-- isnt working 
           //i dont know the symbol for (not true) and for or statements
           //
         
            Console.WriteLine("Hello World!");
        }
    }
}
