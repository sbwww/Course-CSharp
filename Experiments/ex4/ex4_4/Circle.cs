using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_4 {
    class Circle : Figure {
        double r;
        public Circle(double r) {
            this.r = r;
        }
        override public double Area() {
            System.Console.WriteLine("Circle:");
            return Math.PI * r * r;
        }
    }
}