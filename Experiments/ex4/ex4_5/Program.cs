using System;

namespace ex4_5 {
    class Program {
        static void Main(string[] args) {
            IShape s;
            s = new Rectangle(1, 2);
            System.Console.WriteLine("Rectangle S = " + s.GetArea());
            s = new Triangle(3, 4, 5);
            System.Console.WriteLine("Triangle S = " + s.GetArea());
            s = new Circle(1);
            System.Console.WriteLine("Circle S = " + s.GetArea());
        }
    }
}
