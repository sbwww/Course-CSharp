using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_1_and_4_2 {
    class Person {
        private string name;
        private int age;
        public void ShowInfo() {
            System.Console.WriteLine("Person:");
            System.Console.WriteLine("name: " + name);
            System.Console.WriteLine(" age: " + age);
        }
        public Person(string name,int age) {
            this.name = name;
            this.age = age;
        }
        public void Judge() {
            string type = "";
            if (age < 15) type = "少年";
            else if (age < 35) type = "青年";
            else if (age < 55) type = "中年";
            else type = "老年";
            System.Console.WriteLine(type);
        }
    }
}
