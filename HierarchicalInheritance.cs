using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Father
    {
        public string FatherName()
        {
            return "Mohit";
        }
    }

    public class Son : Father
    {
        public string SonName()
        {
            return "Ali";
        }
    }

    public class Daughter: Father
    {
        public string DaughterName()
        {
            return "Aayesha";
        }
    }
    internal class HierarchicalInheritance
    {
        public static void Main(string[] args)
        {
            Son son = new Son();
            Console.WriteLine("My name is " + son.SonName() + " and my father's name is " + son.FatherName() + ".");
            Daughter daughter = new Daughter();
            Console.WriteLine("My name is " + daughter.DaughterName() + " and my father's name is " + daughter.FatherName() + ".");
        }
    }
}
