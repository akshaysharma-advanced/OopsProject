using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.MultipleInheritance
{
    interface IFirstInterface
    {
        void FirstInterfaceMethod(); // first inteface method
    }

    interface ISecondInterface
    {
        void SecondInterfaceMethod(); //second inteface method
    }

    class MultipleInheritanceClass : IFirstInterface, ISecondInterface
    {
        public void FirstInterfaceMethod()
        {
            Console.WriteLine("This is First Interface Method!");
        }
        public void SecondInterfaceMethod()
        {
            Console.WriteLine("This is Second Interface Method!");
        }
    }
}
