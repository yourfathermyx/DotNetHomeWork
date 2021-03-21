using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle(-1, -1, -1.5);
            Rectangle rectangle = new Rectangle(3, 4);
            Square square = new Square(5);
            //            bool flag = triangle.Judge();
            //            bool flag = rectangle.Judge();
            bool flag = square.Judge();
            if (flag == true)
            {
                Console.WriteLine("该形状合法！");
                Console.Write("该形状面积为：");
                Console.WriteLine(square.Area());
            }
            else
            {
                Console.WriteLine("该形状不合法...");
            }



        }
    }
}

namespace HomeWork3
{
    public class Rectangle : Shape
    {
        protected double length;
        protected double wide;

        public Rectangle(double length, double wide)
        {
            Length = length;
            Wide = wide;
        }
        public Rectangle(Random random)
        {
            Length = random.NextDouble() * 10;
            Wide = random.NextDouble() * 10;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }

        public double Wide
        {
            get { return wide; }
            set
            {
                if (value <= 0)
                {
                    wide = 0;
                }
                else
                {
                    wide = value;
                }
            }
        }

        public double Area()
        {
            return wide * length;
        }
        public bool Judge()
        {
            if (wide > 0 && length > 0)
            {
                return true;
            }
            return false;
        }
    }
}

namespace HomeWork3
{
    public interface Shape
    {
        double Area();
        bool Judge();
    }
}

namespace HomeWork3
{
    public class Square : Shape
    {
        private double side;

        public double Side
        {
            get { return side; }
            set
            {
                if (value <= 0)
                {
                    side = 0;
                }
                else
                {
                    side = value;
                }
            }
        }

        public Square(double s)
        {
            Side = s;
        }
        public Square(Random random)
        {
            Side = random.NextDouble() * 10;
        }

        public double Area()
        {
            return side * side;
        }

        public bool Judge()
        {
            if (side > 0)
                return true;
            return false;
        }
    }
}

namespace HomeWork3
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;
        public double A
        {
            set
            {
                if (value <= 0)
                {
                    a = 0;
                }
                else
                {
                    a = value;
                }
            }
            get
            {
                return a;
            }
        }
        public double B
        {
            set
            {
                if (value <= 0)
                {
                    b = 0;
                }
                else
                {
                    b = value;
                }
            }
            get
            {
                return b;
            }
        }

        public double C
        {
            set
            {
                if (value <= 0)
                {
                    c = 0;
                }
                else
                {
                    c = value;
                }
            }
            get
            {
                return c;
            }
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle(Random random)
        {
            A = random.NextDouble() * 10;
            B = random.NextDouble() * 10;
            C = random.NextDouble() * 10;
        }
        public double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool Judge()
        {
            if (a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0)
            {
                return true;
            }
            return false;
        }

    }
}