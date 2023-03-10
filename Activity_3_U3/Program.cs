using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3_U3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person P;
            P = new Person("Jose", 21);
            Console.WriteLine("Name: {0}\nAge: {1}", P.Name, P.Age);
            Student S;
            S = new Student("Jose", 21, 14947);
            Console.WriteLine("Name: {0}\nAge: {1}\nStudent_ID: {2}", S.Name, S.Age, S.student_id);
        }
    }
}
