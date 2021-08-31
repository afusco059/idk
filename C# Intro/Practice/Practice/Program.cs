using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome " + userName);

            Console.WriteLine("Press any key to continue");
            Console.ReadLine();


            Console.Write("how many hours of sleep did you get last night");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("good job thats a lot of sleep");
            }
            else if (hoursOfSleep >= 6) 
            {
                Console.WriteLine("Not bad but you need more sleep");
            
            }
            else if (hoursOfSleep < 6)
            {
                Console.WriteLine("you need more sleep");

            
            }
            else
            {
                Console.WriteLine("None it terrible");
            }



            Console.ReadKey();
        }
    }
}
