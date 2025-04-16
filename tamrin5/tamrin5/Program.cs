using System;

namespace tamrin5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=1,entry;
            entry = int.Parse(Console.ReadLine());
            for (int i = 0; i < entry; i++)
            {
                sum += sum * i;
            }
            Console.WriteLine("factoriel  is : "+sum);
        }
    }
}
