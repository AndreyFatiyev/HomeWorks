using System;

namespace Task3
{
    class Task3
    {
        static void Main(string[] args)
        { //3. Найти индекс минимального элемента массива.
            bool sw = true;
            while (sw)
            {
                try {
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

                    int minNumIndex = 0;
                    int min = arr[0];
                    Console.WriteLine("\n\n3. Найти индекс минимального элемента массива.\n\n");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (min > arr[i])
                        {
                            minNumIndex = i;
                        }

                    }
                    Console.WriteLine($"MinNumIndex is = {minNumIndex}");
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
