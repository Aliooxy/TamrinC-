using System;

namespace tamrin4
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("enter number to Divisible by 5:");
                entry = int.Parse(Console.ReadLine());
                if (entry % 5 == 0)
                {
                    Console.WriteLine("number is  Divisible by 5 :  "+entry);
                }
                else
                {
                    Console.WriteLine("number is not  Divisible by 5 :  ");

                }
            }
            Console.ReadKey();
        }
    }
}
