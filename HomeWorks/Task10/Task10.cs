using System;

namespace Task101
{
    class Task10
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < 20; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }
            Console.WriteLine($"Fibonacci nums is =>\n ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write($" {arr[i]}");
            }
            Console.ReadKey();
        }
    }
}
