using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_5 {
    class Triangle : IShape {
        double a;
        double b;
        double c;
        public Triangle(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetArea() {
            double p = (a + b + c) / 2.0;
            double ans = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return ans;
        }
    }
}
