using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_6 {
    class Student {
        string name;
        public delegate void delegateType();
        public event delegateType EndEvent;

        public Student(string name) {
            this.name = name;
        }
        public void Submit() {
            Console.WriteLine(name + " submitted paper");
            if (EndEvent != null)
                EndEvent();
        }
        public void ReceivePaper() {
            Console.WriteLine(name + " received paper");
        }
    }
}