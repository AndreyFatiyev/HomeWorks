using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        { //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
            bool sw = true;

            while (sw)
            { 
                try 
                {
                    int n;
                    Console.WriteLine($"Enter Array Lenght : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];

                    // Инициализация массива и вывод на экран .
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine($"Enter Elements of Array : {i}");
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.Clear();

                    Console.WriteLine("Array is : \n");
                    //Вывод массива 
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write($"{arr[i]}\t");
                    }

                    Console.WriteLine("\n\n8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.\n\n");

                    int[] arr1 = new int[n];

                    int j = n % 2 == 0 ? arr1.Length / 2 : arr1.Length / 2 + 1;

                    for (int i = 0; i < arr1.Length / 2; i++)
                    {
                        arr1[j] = arr[i];
                        j++;

                    }

                    j = 0;

                    for (int i = arr1.Length / 2; i < arr1.Length; i++)
                    {
                        arr1[j] = arr[i];
                        j++;
                    }


                    for (int i = 0; i < arr1.Length; i++)
                    {
                        Console.Write($"{arr1[i]}\t");
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
