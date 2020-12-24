using System;

namespace ex4_3 {
    class Program {
        static void DrawShape(double x, double y, Shape shape) {
            shape.Draw(x, y);
            System.Console.WriteLine("S = " + shape.GetArea());
        }
        static void Main(string[] args) {
            DrawShape(10, 10, new Circle(11.4));
            DrawShape(100, 100, new Square(5));
        }
    }
}