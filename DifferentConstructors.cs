using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
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
    internal class DifferentConstructors
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student(); //This would invoke default constructor
            //Default constructor gives default values to the int and objects as 0, null
            //It also gives warnings as fields are not assigned.
            Console.WriteLine(student1.name);
            Console.WriteLine(student1.id);

            School school1 = new School(101,"MGM"); //This will invoke parameterized constructor
            Console.WriteLine("School Name: "+ school1.schoolName + " and School Id: " + school1.regNumber);


        }
    }
}
