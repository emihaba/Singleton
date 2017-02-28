using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1, person2;

            person1 = Person.getInstance();
            person2 = Person.getInstance();

            person1.age = 20;
            person2.age = 21;

            Console.WriteLine(person1.age);
            Console.WriteLine(person2.age);
            Console.ReadKey();








        }
    }
}
