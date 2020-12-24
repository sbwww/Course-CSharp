using System;

namespace ex4_6 {
    class Program {
        static void Main(string[] args) {
            Teacher teacher = new Teacher("The teacher");
            Student student1 = new Student("The student");
            Student student2 = new Student("Another student");
            teacher.TestEvent += new Teacher.delegateType(student1.ReceivePaper);
            teacher.TestEvent += new Teacher.delegateType(student2.ReceivePaper);
            teacher.Start();
            Console.WriteLine();
            student1.EndEvent += new Student.delegateType(teacher.ReceiveAnswerSheet);
            student2.EndEvent += new Student.delegateType(teacher.ReceiveAnswerSheet);
            student1.Submit();
            student2.Submit();
        }
    }
}
