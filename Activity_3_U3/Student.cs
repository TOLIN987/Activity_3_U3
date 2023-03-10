using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3_U3
{
    public class Student : Person
    {
        private int studen_id;

        public int student_id
        {
            get { return studen_id; }
            set { studen_id = value; }
        }
        public Student(string name, int age , int student_id):base(name,age)
        {
            this.student_id = student_id;
        }

        ~Student()
        {
            System.Diagnostics.Trace.WriteLine("The Student destructor worked succesfully");
        }
    }
}
