using System;

namespace Task4
{
    class Task4
    {
        static void Main(string[] args)
        { //4. Найти индекс максимального элемента массива.
            bool sw = true;
            while (sw) { try {
                    int n;
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

                    int maxIndex = 0;
                    int max = arr[0];
                    Console.WriteLine("\n\n4. Найти индекс максимального элемента массива.\n\n");

                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (max < arr[i])
                        {
                            maxIndex = i;
                        }

                    }
                    Console.WriteLine($"MaxIndex is = {maxIndex}");
                    sw = false;
                    Console.ReadKey();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter Numbers not Symbols =>>>>\n\n");
                    sw = true;
                }
            } }
            
        }
    }

