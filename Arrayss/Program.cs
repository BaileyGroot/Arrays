using System;

namespace Arrayss
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[9];

            for (int i = 0; i < 9; i++)
            {
                numbers[i] = i+1;
                if (i == 5)
                {
                    numbers[i] = numbers[i - 1] * 2;
                }
            }

            foreach (int tal in numbers)
            {
                Console.WriteLine(tal);
            }
            
            Console.ReadKey();
        }
    }
}
