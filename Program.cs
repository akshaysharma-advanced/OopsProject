using OopsProject.Abstraction;
using OopsProject.AccessModifiers;
using OopsProject.DifferentConstructors;
using OopsProject.DynamicPolymorphism;
using OopsProject.HierarchicalInheritance;
using OopsProject.Interface;
using OopsProject.MultipleInheritance;
using OopsProject.SingleInheritance;
using OopsProject.StaticPolymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1:");
            Rectangle r = new Rectangle(10, 5);
            int areaOfRectangle = r.Area();
            Square s = new Square(10, 10);
            int areaOfSquare = s.Area();
            Console.WriteLine("Area of Rectangle is " + areaOfRectangle + ".");
            Console.WriteLine("Area of Square is " + areaOfSquare + ".");

            Console.WriteLine("\nQuestion 2:");
            PrintDetails p = new PrintDetails();
            p.printData("Akshay", "Sharma", "Ahmedabad");
            p.printData("8765432112", "akshay@mail.com");

            Console.WriteLine("\nQuestion 3:");
            Xc40 xc40 = new Xc40();
            Xc60 xc60 = new Xc60();
            Vehicle.Brand();
            Console.WriteLine("Model:" + xc40.modelName);
            xc40.Price();
            Console.WriteLine();
            Vehicle.Brand();
            Console.WriteLine("Model" + xc60.modelName);
            xc60.Price();

            Console.WriteLine("\nQuestion 4:");
            Apple myApple = new Apple(); //Create an Apple object
            myApple.FruitName();
            myApple.FruitColor();

            Mango myMango = new Mango(); //Create an Apple object
            myMango.FruitName();
            myMango.FruitColor();

            Papaya myPapaya = new Papaya(); //Create an Apple object
            myPapaya.FruitName();
            myPapaya.FruitColor();

            Console.WriteLine("\nQuestion 5:");
            MultipleInheritanceClass myObj = new MultipleInheritanceClass();
            myObj.FirstInterfaceMethod();
            myObj.SecondInterfaceMethod();

            Console.WriteLine("\nQuestion 6:");
            SimpleInterest simpleInterest = new SimpleInterest();
            simpleInterest.principalAmount = 2000;
            simpleInterest.rateOfInterest = 0.1;
            simpleInterest.years = 3;
            Console.WriteLine("Simple Interest:" + simpleInterest.CalculateInterest());

            Console.WriteLine("\nQuestion 7:"); 
            //Create a object named someMetal
            Gold someMetal = new Gold();

            //Display the value of metalName field from Gold class and value of color field from Metal Class
            Console.WriteLine("Metal is " + someMetal.metalName + " and its color is " + someMetal.color + ".");

            //Call the value() method from Metal Class on someMetal object
            someMetal.value();

            Console.WriteLine("\nQuestion 8:");
            City myCity = new City();
            myCity.CountryName();
            myCity.StateName();
            myCity.CityName();

            Console.WriteLine("\nQuestion 9:");
            Son son = new Son();
            Console.WriteLine("My name is " + son.SonName() + " and my father's name is " + son.FatherName() + ".");
            Daughter daughter = new Daughter();
            Console.WriteLine("My name is " + daughter.DaughterName() + " and my father's name is " + daughter.FatherName() + ".");

            Console.WriteLine("\nQuestion 10:"); Student student1 = new Student(); //This would invoke default constructor
            //Default constructor gives default values to the int and objects as 0, null
            //It also gives warnings as fields are not assigned.
            Console.Write(student1.name);
            Console.WriteLine(student1.id);

            School school1 = new School(101, "MGM"); //This will invoke parameterized constructor
            Console.WriteLine("School Name: " + school1.schoolName + " and School Id: " + school1.regNumber);
        }
    }
}
