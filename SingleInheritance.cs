using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    class Metal //parent class (base class)
    {
        public string color = "Yellow"; //Metal class field
        public void value()
        {
            Console.WriteLine("Expensive");
        }
    }

    class Gold : Metal //child class (derived class)
    {
        public string metalName = "Gold"; //Gold class field
    }
    internal class SingleInheritance
    {
        static void Main(string[] args)
        {
            //Create a object named someMetal
            Gold someMetal = new Gold();
            
            //Display the value of metalName field from Gold class and value of color field from Metal Class
            Console.WriteLine("Metal is " + someMetal.metalName + " and its color is " + someMetal.color + ".");

            //Call the value() method from Metal Class on someMetal object
            someMetal.value();
        }
    }
}
