using System;

namespace CSharp_Study_Guide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any following key to peform an arithmetic operation:");
            Console.WriteLine("\n\t1 - Addition\n\t2 - Subtraction\n\t3 - Multipication\n\t4 - Division");
            Int32.TryParse(Console.ReadLine(), out int response);
            System.Console.Clear();
            while (response != 0)
            {
                Console.WriteLine("Please enter first value");
                Int32.TryParse(Console.ReadLine(), out int value1);
                Console.WriteLine("Please enter first value");
                Int32.TryParse(Console.ReadLine(), out int value2);

                switch (response)
                {
                    case 1:
                        Console.WriteLine($"Result is {value1 + value2}");
                        break;
                    case 2:
                        Console.WriteLine($"Result is {value1 - value2}");
                        break;
                    case 3:
                        Console.WriteLine($"Result is {value1 * value2}");
                        break;
                    case 4:
                        Console.WriteLine($"Result is {(double)value1 / (double)value2}");
                        break;
                    default:
                         
                        break;

                }
                
                Console.WriteLine("Press any following key to peform an arithmetic operation:");
                Console.WriteLine("\n\t1 - Addition\n\t2 - Subtraction\n\t3 - Multipication\n\t4 - Division");
                Int32.TryParse(Console.ReadLine(), out response);
            }

            
            

            
        }
    }
}
