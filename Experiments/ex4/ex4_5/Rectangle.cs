using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_5 {
    class Rectangle : IShape {
        double a;
        double b;
        public Rectangle(double a, double b) {
            this.a = a;
            this.b = b;
        }
        public double GetArea() {
            return a * b;
        }
    }
}
