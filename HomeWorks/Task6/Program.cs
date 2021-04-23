using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {//6. Сделать реверс массива (массив в обратном направлении).
            bool sw= true;
            while (sw)
            { 
                try
                {
                    int n;
                    Console.WriteLine($"enter the length of the array : ");
                    n = Convert.ToInt32(Console.ReadLine());

                    int[] arr = new int[n];

                    // Инициализация массива и вывод инициализации на экран .
                    for (int i = 0; i < arr.Length; i++)
                    {

                        Console.WriteLine($"write down the array number : {i}");
                        arr[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.Clear();
                    Console.WriteLine("Array is : \n");//Вывод массива 
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]}\t");
                    }

                    Console.WriteLine("\n\n6. Сделать реверс массива (массив в обратном направлении).\n\n");

                    for (int i = 0; i < arr.Length / 2; i++)
                    {
                        int minNum = arr[i];
                        arr[i] = arr[arr.Length - i - 1];
                        arr[arr.Length - i - 1] = minNum;
                    }

                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]}\t");
                    }

                    sw = false;
                    Console.ReadKey();

                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter Numbers not Symbols =>>>>\n\n");
                    sw = true;
                }
            }
           
        }
    }
}
