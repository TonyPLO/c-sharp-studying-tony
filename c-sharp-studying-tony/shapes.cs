using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_studying_tony
{

    public class Square
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetArea()
        {
            return side * side;
        }

        public double GetPerimeter()
        {
            return 4 * side;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Square - Side: {side}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }

    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double length)
        {
            this.length = length;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Rectangle - Length: {length}, Width: {width}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }

    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Circle - Radius: {radius}, Area: {GetArea()}, Perimeter: {GetPerimeter()}");
        }
    }

    public class shapes
    {
        public static void Main()
        {
            Square square1 = new Square(4.5);
            Square square2 = new Square(6.3);

            Rectangle rectangle1 = new Rectangle(5.0, 3.2);
            Rectangle rectangle2 = new Rectangle(7.8, 4.4);

            Circle circle1 = new Circle(3.5);
            Circle circle2 = new Circle(5.0);

            square1.PrintDetails();
            square2.PrintDetails();
            rectangle1.PrintDetails();
            rectangle2.PrintDetails();
            circle1.PrintDetails();
            circle2.PrintDetails();
        }
    }
}
