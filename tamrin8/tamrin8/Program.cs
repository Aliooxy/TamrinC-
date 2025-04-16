using System;

namespace tamrin8
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            bool isprime = true;

            if (entry == 1)
            {
                isprime = false;
            }
            for (int i = 2; i < entry; i++)
            {
                
                if (entry % i == 0)
                {
                    isprime = false;
                }
                


            }
            if (isprime == true)
            {
                Console.WriteLine("number is prime");
            }
           
            else
            {
                Console.WriteLine("number is not prime");
            }

        }
    }
}
