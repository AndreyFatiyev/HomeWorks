using System;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine($"Zapiwite dlinu massiva : ");            
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];            
            arrInit(arr);// Инициализация массива и вывод на экран .
            Console.Clear();         
            Array(arr);//Вывод массива 
            
           
                 
            
            
            int oddCounter = 0;//7. Посчитать количество нечетных элементов массива.


            Console.WriteLine("\n\n\nEnter num Lesson : \n");
            int sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                
                case 1: //1. Найти минимальный элемент массива.
                    Console.Clear();                    
                    Array(arr);
                    minNum(arr);
                    Console.ReadLine();
                    break;
                case 2: //2. Найти максимальный элемент массива.
                    Console.Clear();                   
                    Array(arr);
                    maxNum(arr);                   
                    Console.ReadLine();
                    break;

                //3. Найти индекс минимального элемента массива.  
                case 3: 
                    Console.Clear();                   
                    Array(arr);
                    minIndex(arr);
                    break;

                //4. Найти индекс максимального элемента массива.
                case 4:
                    Console.Clear();
                    Array(arr);
                    maxIndex(arr);
                    Console.ReadLine();
                    break;

                //5. Посчитать сумму элементов массива с нечетными индексами.
                case 5: 
                    Console.Clear();                   
                    Array(arr);
                    NumSum(arr);
                    Console.ReadLine();
                    break;

                // 6. Сделать реверс массива (массив в обратном направлении).
                case 6: 
                    Console.Clear();                    
                    Array(arr);
                    RevArr(arr);
                    Array(arr);
                    break;

                //7. Посчитать количество нечетных элементов массива.
                case 7: 
                    Console.Clear();                   
                    Array(arr);
                    Console.WriteLine("\n\n7. Посчитать количество нечетных элементов массива.\n\n");

                    for (int i = 0; i < arr.Length; i++)
                    {                       
                        if (arr[i] % 2 == 1) 
                        {
                            oddCounter++;
                        }
                    }
                    Console.WriteLine($"oddCounter is = {oddCounter}");
                    Console.ReadLine();
                    break;

                //8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2.
                case 8: 
                    Console.Clear();                
                    Array(arr);
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
                    Console.ReadLine();
                    break;

                //9. Отсортировать массив (пузырьком (Bubble) и почитать методы:  выбором (Select), вставками (Insert)) и попробовать отсортировать.
                case 9:
                    Console.Clear();                  
                    Array(arr);
                    // сортировка                    
                    BubbleSort(arr);
                    // вывод
                    Array(arr);
                    Console.ReadLine();
                    break;
                case 10:


                    break;

                case 11:


                    break;


            }
          
            Console.ReadLine();
        }


        static void Array(params int[] arr) // Вывод массива в консоль
        {
            Console.WriteLine("Array is : \n");
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result = arr[i];
                Console.Write($"{result}\t");
            }
           

        }
        static void arrInit(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine($"Zapiwite 4islo massive : {i}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
  
        static void BubbleSort(params int[] arr) //9. Отсортировать массив (пузырьком (Bubble) и почитать методы:  выбором (Select), вставками (Insert)) и попробовать отсортировать.
        {
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
        }
        static void maxNum(params int[] arr) //2. Найти максимальный элемент массива.
        {
            int max = arr[0]; 
            Console.WriteLine("\n\n2. Найти максимальный элемент массива.\n\n");

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"maxNum is = {max}");

        }
        static void minNum(params int[] arr)  //1. Найти минимальный элемент массива.
        {
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
        }
        static void minIndex(params int[] arr)
        {
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
        }
        static void maxIndex(params int[] arr)
        {
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
        }
        static void NumSum(params int[] arr)
        {
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
        }
        static void RevArr(params int[] arr)
        {
            Console.WriteLine("\n\n6. Сделать реверс массива (массив в обратном направлении).\n\n");

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int minNum = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = minNum;
            }
        }
    }

}
