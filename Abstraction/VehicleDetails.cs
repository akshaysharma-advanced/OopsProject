using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.Abstraction
{
    //Abstract Class
    abstract class Vehicle
    {
        //Abstract method without body
        public abstract void Price();

        //Regular Method
        public static void Brand()
        {
            Console.WriteLine("Brand: Volvo");
        }
    }

    //Derived Class (inherited from Vehicle)
    class Xc40 : Vehicle
    {
        public string modelName = "XC40";
        public override void Price()
        {
            Console.WriteLine("Price: 47 Lakhs");
        }
    }
    class Xc60 : Vehicle
    {
        public string modelName = "XC60";
        public override void Price()
        {
            Console.WriteLine("Price: 67 Lakhs");
        }
    }
}
