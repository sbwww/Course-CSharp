using System;

namespace ex4_4 {
    class Program {
        static void Main(string[] args) {
            Circle circle = new Circle(11.4);
            Square square = new Square(5);
            System.Console.WriteLine(circle.Area());
            System.Console.WriteLine(square.Area());
        }
    }
}
