using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Objects.Also_UML_Diagrams
{
    class Employee
    {
        string surname;
        string name;
        //------------------

        public string Possition { get; set; }

        public double Experiense { get; set; }
        //--------------------------------------

        public Employee() { }

        public Employee(string surname, string name,
            string possition, double experiense)
        {
            this.surname = surname;
            this.name = name;
            this.Possition = possition;
            this.Experiense = experiense;
        }
        //-----------------------------------------

        public void CalculateSalaryAndTax(string pos, double exp)
        {
            if (Possition == pos && Experiense == exp)
            {
                double salary = Experiense * 15000;
                double tax = Experiense * 15000 / 100;

                Console.WriteLine($"The salary =\t{salary}\n");
                Console.WriteLine($"The tax =\t{tax}\n");
            }
        }
        //----------------------------------------------------------

    }
}
