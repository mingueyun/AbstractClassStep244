using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassStep244
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }

        public void tellAge()
        {

            Console.WriteLine(age);
        }

    }
}
