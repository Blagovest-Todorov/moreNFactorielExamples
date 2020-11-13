using System;

namespace _09.WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.Write("n! = ");

            uint result = 1;

            while (true)
            {
                Console.Write(n);
                if (n == 1)
                {
                    break;
                }
                Console.Write("*");
                result *= n;
                n--;

            }
            Console.WriteLine("= {0}", result);



        }
    }
}
