using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_3 {
    class Square : Shape {
        double a;
        public Square(double a) {
            this.a = a;
        }
        override public void Draw(double x, double y) {
            System.Console.WriteLine("Square:");
            System.Console.WriteLine("(" + x + ", " + y + ")");
            System.Console.WriteLine("a = " + a);
        }
        override public double GetArea() {
            return a * a;
        }
    }
}
