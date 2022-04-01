using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Objects.Also_UML_Diagrams
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task #1

            //Converter converter = new Converter(29.2, 35.79, 25.1);
            //converter.ExchageBuyingTheForeignCash(2800);
            //converter.ExchageBuyingTheUAH(100);

            // Task #2

            //Employee employee = new Employee("Oleksandrovskiy", "Veniamin", "Boss", 5);
            //employee.CalculateSalaryAndTax("Boss", 5);

            Invoice invoice = new Invoice("500", 20);
            invoice.CountThesumWithNDS();
            invoice.CountTheSumwithoutNDS();
        }
    }
}
