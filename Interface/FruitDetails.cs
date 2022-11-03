using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.Interface
{
    //Fruit Interface
    interface IFruit
    {
        void FruitName(); //interface method (does not have a body)
        void FruitColor(); //interface method (does not have a body)
    }

    //Apple implements the IFruit interface
    class Apple : IFruit
    {
        public void FruitName()
        {
            //The body of FruitName() is provided here
            Console.WriteLine("Fruit Name: Apple");
        }

        public void FruitColor()
        {
            // The body of FruitColor() is provided here
            Console.WriteLine("Fruit Color: Red");
            Console.WriteLine();
        }
    }

    class Mango : IFruit
    {
        public void FruitName()
        {
            //The body of FruitName() is provided here
            Console.WriteLine("Fruit Name: Mango");
        }

        public void FruitColor()
        {
            // The body of FruitColor() is provided here
            Console.WriteLine("Fruit Color: Yellow");
            Console.WriteLine();
        }
    }

    class Papaya : IFruit
    {
        public void FruitName()
        {
            //The body of FruitName() is provided here
            Console.WriteLine("Fruit Name: Papaya");
        }

        public void FruitColor()
        {
            // The body of FruitColor() is provided here
            Console.WriteLine("Fruit Color: Yellow");
            Console.WriteLine();
        }
    }
}
