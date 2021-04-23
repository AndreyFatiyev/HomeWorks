using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {//1. Найти минимальный элемент массива.
            bool sw = true;
            while (sw)
            {
                try
                {
                    int n;
                    Console.WriteLine($"Zapiwite dlinu massiva : ");
                    n = Convert.ToInt32(Console.ReadLine());

                    int[] arr = new int[n];

                    // Инициализация массива и вывод инициализации на экран .
                    for (int i = 0; i < arr.Length; i++)
                    {

                        Console.WriteLine($"Zapiwite 4islo massive : {i}");
                        arr[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.Clear();
                    Console.WriteLine("Array is : \n");//Вывод массива 
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]}\t");
                    }


                    int min = arr[0];
                    Console.WriteLine("\n\n1. Найти минимальный элемент массива.\n\n");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (min > arr[i])
                        {
                            min = arr[i];
                        }
                    }
                    Console.WriteLine($"MinNum is = {min}");                    
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