using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            double sumOfArea = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10);
                int x = random.Next(0, 3);
                Shape shape = ShapeFactory.Manufacture((ShapeName)x);
                if (!shape.Judge())//形状不合法
                {
                    i--;
                    continue;
                }
                Console.WriteLine($"第{i}个形状为：{(ShapeName)x}，面积为：{shape.Area()}");
                sumOfArea += shape.Area();
            }
            Console.WriteLine($"总面积为：{sumOfArea}");



        }
    }
}


namespace HomeWork3_2
{
    enum ShapeName
    {
        triangle,
        rectangle,
        square
    }
    class ShapeFactory
    {
        public static Shape Manufacture(ShapeName sn)
        {
            Random random = new Random();
            switch (sn)
            {
                case ShapeName.rectangle:
                    return new Rectangle(random);
                case ShapeName.square:
                    return new Square(random);
                case ShapeName.triangle:
                    return new Triangle(random);
                default:
                    return null;
            }
        }
    }
}