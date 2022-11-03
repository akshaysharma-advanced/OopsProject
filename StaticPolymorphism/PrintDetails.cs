using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.StaticPolymorphism
{
    internal class PrintDetails
    {
        public void printData(string firstName, string lastName, string city)
        {
            Console.WriteLine("First Name:" + firstName);
            Console.WriteLine("Last Name:" + lastName);
            Console.WriteLine("City:" + city);
        }
        public void printData(string mobileNum, string emailId)
        {
            Console.WriteLine("Mobile No:" + mobileNum);
            Console.WriteLine("Email ID:" + emailId);
        }
    }
}
