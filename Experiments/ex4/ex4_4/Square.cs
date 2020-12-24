using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_4 {
    class Square : Figure {
        double a;
        public Square(double a) {
            this.a = a;
        }
        override public double Area() {
            System.Console.WriteLine("Square:");
            return a * a;
        }
    }
}