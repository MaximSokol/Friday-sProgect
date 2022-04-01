using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Objects.Also_UML_Diagrams
{
    class Invoice
    {
        public readonly int account;
       public readonly string customer;
       public readonly string provider;
        //------------------------------

        private string article;
        private int quantity;
        //----------------------

        public Invoice() { }

        public Invoice(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }
        //---------------------------------------------

        public void CountThesumWithNDS()
        {
            int basePrice = Convert.ToInt32(article);
            Console.WriteLine($"The sum witout NDS =\t{basePrice * quantity / 100}\n");
        }
        //------------------------------------

        public void CountTheSumwithoutNDS()
        {
            int basePrice = Convert.ToInt32(article);
            Console.WriteLine($"The sum with NDS =\t{basePrice}\n");
        }
        //------------------------------------
    }
}
