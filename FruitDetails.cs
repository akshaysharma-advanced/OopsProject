using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
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
    internal class FruitDetails
    {
        static void Main(string[] args)
        {
            Apple myApple = new Apple(); //Create an Apple object
            myApple.FruitName();
            myApple.FruitColor();

            Mango myMango = new Mango(); //Create an Apple object
            myMango.FruitName();
            myMango.FruitColor();

            Papaya myPapaya = new Papaya(); //Create an Apple object
            myPapaya.FruitName();
            myPapaya.FruitColor();
        }
        
    }
}
