using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {//11.Написать программу, которая будет спрашивать имя и возраст двух человек

            bool isName = true;
            string name1="";
            string name2="";
            int age1=0;
            int age2=0;           
            while (isName) {
                try 
                {
                    Console.WriteLine("First user name:");
                    name1 = Console.ReadLine();
                    isName = false;
                } 
                catch
                {
                    Console.WriteLine("enter leggit symbols in name1 =>>>");
                    isName = true;
                } 
            }
            bool isAge = true;
            while (isAge)
            {
                try
                {
                    Console.WriteLine("First user age:");
                    age1 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (age1 > 0 && age1 < 101)
                    {
                        isAge = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter age from 1 to 100");
                    }
                    
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("enter numbers please =>>>");
                    isAge = true;
                }

            }
            bool isName2 = true;
            while (isName2)
            {
                try
                {
                    Console.WriteLine("Second user name: ");
                    name2 = Console.ReadLine();
                    Console.Clear();
                    isName2 = false;
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("enter leggit symbols in name2 =>>>");
                    isName2 = true;
                }

            }
            bool isAge2 = true;
            while (isAge2)
            {
                try
                {
                    Console.WriteLine("Second user age: ");
                    age2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (age2 > 0 && age2 < 101)
                    {
                        isAge2 = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter age from 1 to 100");
                    }
             
                   
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("enter numbers please =>>>");
                    isAge2 = true;
                }

            }





            


                    Console.WriteLine($"\nwho is older ?\n if {name1} press '1' , if {name2} press '2' ");
                     int user = Convert.ToInt32(Console.ReadLine());


            switch (user)
            {
                case 1:
                    if (age1 > age2)
                    {
                        Console.WriteLine($"Right , {name1} is {age1 - age2} older than {name2} ");
                    }
                    else
                        Console.WriteLine($"Not true , {name1} is {age2 - age1} younger than {name2} ");
                    break;
                        case 2:
                    if (age2 > age1)
                    {
                        Console.WriteLine($"Right , {name2} is {age2 - age1} older than {name1} ");
                    }
                    else
                        Console.WriteLine($"Not true , {name2} is {age1 - age2} younger than {name1} ");
                    break;
            }
                   
              
                   
              
            Console.ReadKey();


        }
    }
}
