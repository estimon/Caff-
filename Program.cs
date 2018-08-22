using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffè
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var Coffe = new Coffe();
            var Tea = new Tea();


            Console.WriteLine("Here is the Caffè menu");
            Console.WriteLine("");
            Console.WriteLine("Coffe = 1, Tea =  2");
            Console.WriteLine("");
            Console.WriteLine("What would you like to order");

            string choise = Console.ReadLine();
            if (choise.ToLower() == "1")
            {
                Coffe.YourOrder();

                Coffe.Money();
            }
            else if (choise.ToLower() == "2")
            {
                Tea.YourOrder();
                
                Tea.Money();
            }
            Console.ReadLine();
        }
    }
}
