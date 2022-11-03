using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.DifferentConstructors
{
    public class Student
    {
        public int id;
        public string name;

        public Student() // This would be invoked while the object of class is created.
        {
            Console.WriteLine("Constructor Called");
        }
    }
    class School
    {
        public int regNumber;
        public string schoolName;

        /*Parameterized Constructor would initialize variables with
          the values of passed arguments while object of class is created */
        public School(int regNumber, string schoolName)
        {
            this.regNumber = regNumber;
            this.schoolName = schoolName;
        }
    }
}
