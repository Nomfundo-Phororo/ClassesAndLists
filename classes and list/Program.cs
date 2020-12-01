using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Object> cars = new List<Object>();
           


           
            string stoper = "";

            Console.WriteLine("--------------------------Press 00 to exit----------------------------------- ");
            int a=0;
            while( a<100)
            {
                car cars1 = new car();
                Console.Write("Please enter your car name: ");
               
               
               
                cars1.name = Console.ReadLine();
                cars.Add(cars1.name);
                cars.Add(" ");
                Console.WriteLine("Enter the year: ");
                cars1.year = int.Parse(Console.ReadLine());
                cars.Add(cars1.year);
                cars.Add("|");

                foreach (var car in cars)
                {
                    Console.Write(car );
                   

                }

                Console.WriteLine("  ");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Wanna leave?: ");
               
                stoper = Console.ReadLine();
            
                a++;
                if(stoper=="00")
                {
                    break;
                }
            }

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
