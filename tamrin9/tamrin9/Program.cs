using System;

namespace tamrin9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number to print all prime number until :");
            int entry = int.Parse(Console.ReadLine());
            for (int i = 2; i <= entry; i++)
            {
                if (isprime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isprime(int entry) 
        {
            for (int i = 2; i < entry; i++)
            {
                if (entry % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}