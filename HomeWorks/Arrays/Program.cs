using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Random random = new Random();*/
            Console.WriteLine($"Zapiwite dlinu massiva : ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
           
            
            for (int i = 0; i < arr.Length; i++)
            {                
                Console.WriteLine($"Zapiwite 4islo massive : {i}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        

            Console.WriteLine("\n\n");

            int[] arr1 = new int[n];
            
            int j = n % 2 == 0 ? arr1.Length/2 : arr1.Length/2+1;
            
            for(int i = 0; i < arr1.Length/2; i++)
            {                
                    arr1[j] = arr[i];             
                j++;                 
               
            }

            j = 0;

            for(int i = arr1.Length / 2; i < arr1.Length; i++)
            {
                arr1[j] = arr[i];
                j++;
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("\n\n");
           
            
            Console.WriteLine("\n\n");
            /*int[] arr1 = new int[10];

           
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i < arr1.Length / 2)
                {
                    arr1[i] = arr[arr.Length / 2 + i];
                }

                Console.WriteLine(arr1[i]);

            }
            for (int i = arr1.Length/2; i < arr1.Length; i++)
            {
                
                                 

                Console.WriteLine(arr[i]);

            }
*/


            Console.WriteLine("\n\n");

            /*  int min = arr[0]; //1. Найти минимальный элемент массива.
              int max = arr[0]; //2. Найти максимальный элемент массива.
              int minIndex = 0; //3. Найти индекс минимального элемента массива.
              int maxIndex = 0; //4. Найти индекс максимального элемента массива.
              int Sum = 0;      //5.Посчитать сумму элементов массива с нечетными индексами.
              int oddCounter = 0;//7. Посчитать количество нечетных элементов массива.

              for (int i = 0; i < arr.Length; i++)
              {


                  if (min > arr[i]) //1. Найти минимальный элемент массива.
                  {
                      minIndex = i; //3. Найти индекс минимального элемента массива.
                      min = arr[i];                  
                  }
                  if (max < arr[i]) //2. Найти максимальный элемент массива.
                  {
                      maxIndex = i; //4. Найти индекс максимального элемента массива.
                      max = arr[i];
                  }
                  if (i % 2 == 1)   //5. Посчитать сумму элементов массива с нечетными индексами.
                  {
                      Sum += arr[i];
                  }
                  if (arr[i] % 2 == 1) //7. Посчитать количество нечетных элементов массива.
                  {
                      oddCounter++; 
                  }

              }

              for (int i = 0; i < arr.Length / 2; i++) // 6. Сделать реверс массива (массив в обратном направлении).
              {
                  int minNum = arr[i];
                  arr[i] = arr[arr.Length - i - 1];
                  arr[arr.Length - i - 1] = minNum;

              }

              Console.WriteLine("\n\nReverse Array :\n");

              for (int i = 0; i < arr.Length; i++) // 6.Вывод реверснутого массива.
              {
                  Console.Write($"{ arr[i]}\t");
              }


              Console.WriteLine($"\n\n\nmin number in array = {min} \nmax number in array = {max}" +
                  $" \nminIndex of minNum = {minIndex} \nmaxIndex of maxNum = {maxIndex} \nSumm of odd nums = {Sum}" +
                  $"\nodd nums Counter = {oddCounter}");*/

        }
    }
}
