using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        { //5. Посчитать сумму элементов массива с нечетными индексами.
            bool sw = true; while (sw) {
                try{
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

                    int Sum = 0;
                    Console.WriteLine("\n\n5. Посчитать сумму элементов массива с нечетными индексами.\n\n");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i % 2 == 1)   //5. Посчитать сумму элементов массива с нечетными индексами.
                        {
                            Sum += arr[i];
                        }
                    }
                    Console.WriteLine($"SumNums is = {Sum}");
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
