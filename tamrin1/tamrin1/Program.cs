using System;

namespace tamrin1
{
    class Program
    {
        static void Main(string[] args)

        {
            int min = int.MaxValue;
            int entry;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("enter number to see lowest!");
                entry  = int.Parse(Console.ReadLine());

                if (entry < min)
                {
                    min = entry;
                }
            }
            Console.WriteLine("lowest number is"+min);
        }
    }
}
