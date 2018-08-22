using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffè
{
    abstract class Asjad
    {
        public string item;
        public bool cake;
        public int itemprice1;
        public int cakeprice = 5;
        public int Price;
        public bool size;
        public int sizeprice = 2;
        public int Money1 = 100;
        public int iteamtotal;


        public void YourOrder()
        {
            string Order;
            Console.WriteLine("You orderd a {0}", item);
            Console.WriteLine("Would you like some cake with that? (yes, no)");
            Order = Console.ReadLine();
            if (Order.ToLower() == "yes")
            {
                cake = true;
                Console.WriteLine("The cake will be 5 euros");
                check();
            }

            else if (Order.ToLower() == "no")
            {
                check();
            }

           

        }


        public void check()
        {
            Console.WriteLine("Here is your check");
            Console.WriteLine("These are your following purchases");
            Console.WriteLine(item + " = " + itemprice1);
            if(cake == true)
            {
                Console.WriteLine("Cake = " + cakeprice);
            }

        }




        public abstract int Money();


    }


}
