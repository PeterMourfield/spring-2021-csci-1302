using System;
namespace csci_1302
{
    public class InheritanceTests
    {
        public static void Run()
        {
            //Shape shape = new Rectangle();

            //Console.WriteLine("Which shape do you want?");
            //string answer = Console.ReadLine();

            //if (answer == "1")
            //    shape = new Rectangle();
            //else
            //    shape = new Triangle();

            //shape.Draw();

            //int area = shape.CalculateArea();
            //Console.WriteLine(area);

            //Rocket rocket = new Rocket();
            //AddToDatabase(rocket);

            Shape square = new Square();
            square.Draw();
            //Console.WriteLine(square.Height);
        }
    }

    public abstract class Shape
    {
        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        // virtual: child classes MAY override
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }

        // abstract: child classes MUST override
        public abstract int CalculateArea();
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square");
            base.Draw();
        }

        public override int CalculateArea()
        {
            return Height * Width;
        }
    }
}