using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_5 {
    class Circle : IShape {
        double r;
        public Circle(double r) {
            this.r = r;
        }
        public double GetArea() {
            return Math.PI * r * r;
        }
    }
}
