using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caffè
{
    class Coffe : Asjad
    {
        public Coffe()
        {
            
            item = "Coffe";
            itemprice1 = 3;
            
        }

        public override int Money()
        {
            if(cake == true)
            {
                Price = itemprice1 + cakeprice;
                if (Money1 > Price)
                {
                    Money1 = Money1 - Price;
                    Console.WriteLine("You have {0} euros left", Money1);
                }
                
            }

            else if (cake == false)
            {
                Price = itemprice1;
                if (Money1 > Price)
                {
                    Money1 = Money1 - Price;
                    Console.WriteLine("You have {0} euros left", Money1);
                }
            }

            
            return Price;
            //Price = (itemprice1 + cakeprice);
            //Console.WriteLine("The total is {0}", Price);
            //if (Money1 > Price)
            //{
            //    Money1 = Money1 - Price;
            //    Console.WriteLine("You have {0} euros left", Money1);
            //}
            //return Price;
        }


    }
}
