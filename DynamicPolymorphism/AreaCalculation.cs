using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.DynamicPolymorphism
{
    class Shape
    {
        protected int length, breadth;

        public Shape(int lengthInput = 0, int breadthInput = 0)
        {
            length = lengthInput;
            breadth = breadthInput;
        }
        public virtual int Area()
        {
            Console.WriteLine("Parent class area: ");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int lengthInput = 0, int breadthInput = 0) : base(lengthInput, breadthInput)
        {

        }

        public override int Area()
        {
            return length * breadth;
        }
    }

    class Square : Shape
    {
        public Square(int lengthInput = 0, int breadthInput = 0) : base(lengthInput, breadthInput)
        {

        }

        public override int Area()
        {
            return length * breadth;
        }
    }
}
