using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    //Abstract Class
    abstract class Vehicle
    {
        //Abstract class without body
        public abstract void Price();

        //Regular Method
        public void Brand()
        {
            Console.WriteLine("Brand: Volvo");
        }
    }

    //Derived Class (inherited from Vehicle)
    class Xc40: Vehicle
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
    internal class VehicleDetails
    {
        public static void Main(string[] args)
        {
            Xc40 xc40 = new Xc40();
            Xc60 xc60 = new Xc60();
            xc40.Brand();
            Console.WriteLine("Model:"+ xc40.modelName);
            xc40.Price();
            Console.WriteLine();
            xc40.Brand();
            Console.WriteLine("Model" + xc60.modelName);
            xc60.Price();

        }
    }
}
