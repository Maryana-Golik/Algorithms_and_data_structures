using System;

namespace lab_2
{
    public class Square
    {
        public double Side { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Square(double x, double y, double side)
        {
            X = x;
            Y = y;
            Side = side;
        }

        public bool IsValid() => Side > 0;
        public double GetPerimeter() => 4 * Side;
        public double GetArea() => Side * Side;

        public override string ToString()
        {
            return string.Format("Кв(ст:{0:G}, x:{1:G}, y:{2:G})", Side, X, Y);
        }
    }
}