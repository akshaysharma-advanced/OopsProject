using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.SingleInheritance
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
}
