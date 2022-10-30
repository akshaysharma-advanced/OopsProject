using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class PrintDetails
    {
        void printData(string firstName, string lastName, string city)
        {
            Console.WriteLine("First Name:" + firstName);
            Console.WriteLine("Last Name:" + lastName);
            Console.WriteLine("City:" + city);
        }
        void printData(string mobileNum, string emailId)
        {
            Console.WriteLine("Mobile No:" + mobileNum);
            Console.WriteLine("Email ID:" + emailId);
        }
        static void Main(string[] args)
        {
            PrintDetails p = new PrintDetails();
            p.printData("Akshay", "Sharma", "Ahmedabad");
            p.printData("8765432112", "akshay@mail.com");
        }
    }
}
