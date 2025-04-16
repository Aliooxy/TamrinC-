using System;

namespace tamrin2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue,entry;
            
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("enter number to see highest");
                entry = int.Parse(Console.ReadLine());
                if (entry > max)
                {
                    max = entry;
                }
            }
            Console.WriteLine("highest number is "+ max);

        }
    }
}
