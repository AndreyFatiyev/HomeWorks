using System;

namespace Task9
{
    class Task9
    {
        static void Main(string[] args)
        {
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
                    Console.WriteLine("\n\n9. Отсортировать массив (пузырьком (Bubble) и почитать методы:  выбором (Select), вставками (Insert)) и попробовать отсортировать.\n\n");
                    int temp;
                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        for (int k = i + 1; k < arr.Length; k++)
                        {
                            if (arr[i] > arr[k])
                            {
                                temp = arr[i];
                                arr[i] = arr[k];
                                arr[k] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Array is : \n");//Вывод массива 
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
