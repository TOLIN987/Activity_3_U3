using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3_U3
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        ~Person()
        {
            System.Diagnostics.Trace.WriteLine("The destructor worked succesfully");
        }
    }
}
