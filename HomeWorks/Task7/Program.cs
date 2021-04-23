using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        { //7. Посчитать количество нечетных элементов массива.
            bool sw = true; while (sw) { try {
                    int n;
                    int oddCounter = 0;

                    Console.WriteLine($"enter the length of the array :");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];

                    // Инициализация массива и вывод на экран .
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"write down the array number : {i}");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Clear();

                    Console.WriteLine("Array is : \n");
                    //Вывод массива 
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]}\t");
                    }

                    Console.WriteLine("\n\n7. Посчитать количество нечетных элементов массива.\n\n");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 1)
                        {
                            oddCounter++;
                        }
                    }
                    Console.WriteLine($"oddCounter is = {oddCounter}");
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
