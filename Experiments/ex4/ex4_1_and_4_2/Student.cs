using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_1_and_4_2 {
    class Student : Person {
        private string number;
        public Student(string name, int age, string number) : base(name, age) {
            this.number = number;
        }
        new public void ShowInfo() {
            System.Console.WriteLine("Student:");
            base.ShowInfo();
        }
        public void ShowNum() {
            System.Console.WriteLine(" num: " + number);
        }
    }
}