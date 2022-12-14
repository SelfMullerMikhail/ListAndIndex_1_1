using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Equals_1_2
{
    class Point
    {
        public int X { set; get; }
        public int Y { set; get; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point)) throw new Exception();
            var obj1 = (Point)obj;
            return X == obj1.X && Y == obj1.Y;
        }

        public override string ToString()
        {
            return $"X: {this.X} \nY: {this.Y}";
        }

        public static Point operator +(Point a, Point b)
        { return new Point(a.X + b.X, a.Y + b.Y); }

        public static bool operator ==(Point p1, Point p2)
        {

            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator !=(Point p1, Point p2)
        {

            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public override int GetHashCode()
        {
            return this.X + 33 + this.Y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new Point(1, 1);
            var obj2 = new Point(1, 1);
            var obj3 = obj1 + obj2;
            Console.WriteLine(obj1 == obj2);
            Console.WriteLine(obj3);

            Console.WriteLine("-----");

            var dict = new Dictionary<Point, string>();
            dict[obj1] = "First";
            Console.WriteLine(dict[obj1]);
            Console.WriteLine(dict[obj2]);
        }
    }
}
