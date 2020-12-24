using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_3 {
    class Circle : Shape {
        double r;
        public Circle(double r) {
            this.r = r;
        }
        override public void Draw(double x, double y) {
            System.Console.WriteLine("Circle:");
            System.Console.WriteLine("(" + x + ", " + y + ")");
            System.Console.WriteLine("r = " + r);
        }
        override public double GetArea() {
            return Math.PI * r * r;
        }
    }
}
