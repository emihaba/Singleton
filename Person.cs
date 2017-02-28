using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Person
    {
        static Person instance;
        public int age { set; get; }

        private Person()
        {

        }

        public static Person getInstance()
        {
            if (instance == null)
            {
                instance = new Person();
            }
            return instance;
           
        }
    }
}
