using System;

namespace Task10
{
    class Task11
    {
        static void Main(string[] args)
        { bool sw = true;
           

            while (sw)
            {
                try
                {
                    Console.WriteLine("First user name:");
                    string name1 = Console.ReadLine();


                    Console.WriteLine("Enter your age:");
                    int age1 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Second user name: ");
                    string name2 = Console.ReadLine();

                    Console.WriteLine("Enter your age: ");
                    int age2 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine($"\nwho is older ?\n if {name1} press '1' , if {name2} press '2' ");
                    int user = Convert.ToInt32(Console.ReadLine());



                    if (user == 1)
                    {
                        if (age1 > age2)
                        {
                            Console.WriteLine($"Right , {name1} is {age1 - age2} older than {name2} ");
                        }
                        else
                            Console.WriteLine($"Not true , {name1} is {age2 - age1} younger than {name2} ");
                    }
                    else if (user == 2)
                    {
                        if (age2 > age1)
                        {
                            Console.WriteLine($"Right , {name2} is {age2 - age1} older than {name1} ");
                        }
                        else
                            Console.WriteLine($"Not true , {name2} is {age1 - age2} younger than {name1} ");

                    }
                    sw = false;
                }
                catch
                {
                    Console.WriteLine(" Your write is wrong =>>> Please enter valid parameters ");
                    sw = true;
                }
            }
            Console.ReadKey();
           
           
        }

            


    }
}

