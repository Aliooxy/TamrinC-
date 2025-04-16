using System;

namespace tamrin7
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry = int.Parse(Console.ReadLine());
            int reverse = 0;
            int digit = 0;
            while (entry != 0)
            {
                digit = entry % 10;
                reverse = reverse * 10 + digit;
                entry /= 10;
            }
            Console.WriteLine(reverse);

        }
    }
}
