using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Objects.Also_UML_Diagrams
{
   partial class Converter
    {
        double usd;
        double eur;
        double rub;
        //-----------

        public Converter() { }

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        //-------------------------------------------------------

        public void ExchageBuyingTheForeignCash(double sumOfUah)
        {

            Console.WriteLine("The instruction of using the converting!");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine("1 - Converting UAH to USD");
            Console.WriteLine("2 - Converting UAH to EUR");
            Console.WriteLine("3 - Converting UAH to RUB");
             Console.WriteLine(new string('-', 25));

            Console.WriteLine();

            Console.WriteLine("Enter the choise ->...\t");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
               double value = this.usd / sumOfUah;
                Console.WriteLine($"Converting the UAH to USD =\t{value}\n");
            }
            else if(num == 2)
            {
                double value = this.eur / sumOfUah;
                Console.WriteLine($"Converting the UAH to EUR =\t{value}\n");
            }
            else if(num == 3)
            {
                double value = this.rub / sumOfUah;
                Console.WriteLine($"Converting the UAH to RUB =\t{value}\n");
            }  
        }
        //----------------------------------------------------------

        public void ExchageBuyingTheUAH(double sumOfCash)
        {
            Console.WriteLine("The instruction of using the converting!");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine("1 - Converting USD to UAH");
            Console.WriteLine("2 - Converting EUR to UAH");
            Console.WriteLine("3 - Converting RUB to UAH");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine();

            Console.WriteLine("Enter the choise ->...\t");
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                double sum = sumOfCash * this.usd;
                Console.WriteLine($"Converting the USD to UAH =\t{sum}\n");
            }
            else if (num == 2)
            {
                double sum = sumOfCash * this.eur;
                Console.WriteLine($"Converting the EUR to UAH =\t{sum}\n");
            }
            else if (num == 3)
            {
                double sum = sumOfCash * this.rub;
                Console.WriteLine($"Converting the RUB to UAH =\t{sum}\n");
            }
        }
        //----------------------------------------------------
    }
}
