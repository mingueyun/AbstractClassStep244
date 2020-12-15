using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassStep244
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee individual = new Employee();

            individual.firstName = "Sample";
            individual.lastName = "Student";
            individual.SayName();

            individual.age = 15;
            individual.tellAge();
            Console.ReadLine();
        }
    }
}
