using System;

namespace ex4_1_and_4_2{
    class Program {
        static void Main(string[] args) {
            Person person = new Person("申博文", 20);
            person.ShowInfo();
            person.Judge();
            Student student = new Student("申博文", 20, "201883290091");
            student.ShowInfo();
            student.ShowNum();
        }
    }
}
