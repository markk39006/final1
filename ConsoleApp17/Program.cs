using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] boytest = new int[3, 3];
            for (int i = 0; i <= 2; i++)
            {
                for(int j = 0; j <= 2; j++)
                {
                    boytest[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(boytest[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
