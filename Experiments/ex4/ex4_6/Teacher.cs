using System;
using System.Collections.Generic;
using System.Text;

namespace ex4_6 {
    class Teacher {
        string name;
        public delegate void delegateType();
        public event delegateType TestEvent;

        public Teacher(string name) {
            this.name = name;
        }
        public void Start() {
            Console.WriteLine(name + " started a test");
            if (TestEvent != null)
                TestEvent();
        }
        public void ReceiveAnswerSheet() {
            Console.WriteLine(name + " received answer sheet");
        }
    }
}