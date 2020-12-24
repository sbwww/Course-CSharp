using System;

namespace ex1_4 {
    public class Student {
        private string no;
        private string name;
        private string sex;
        private int age;
        private string school;

        public string No { get => no; set => no = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public string School { get => school; set => school = value; }

        public bool VaildCheck(string no, string name, string sex, int age, string school) {
            bool flag = true;
            if (no.Length != 8) {
                System.Console.WriteLine("Wrong paras No (length)");
                flag = false;
            }
            try {
                Convert.ToInt32(no);
            } catch (FormatException) {
                System.Console.WriteLine("Wrong paras No (digit only)");
                flag = false;
            }
            sex = sex.Trim();
            if (sex != "男" && sex != "女") {
                System.Console.WriteLine("Wrong paras Sex (男 or 女)");
                flag = false;
            }
            if (age < 1 || age > 200) {
                System.Console.WriteLine("Wrong paras Age (1~200)");
                flag = false;
            }
            return flag;
        }
        public Student(string no, string name, string sex, int age, string school) {
            System.Console.WriteLine("No.{0}\nName: {1}\nSex: {2}\nAge: {3}\nSchool: {4}", no, name, sex, age, school);
            if (VaildCheck(no, name, sex, age, school) == false) {
                return;
            }
            System.Console.WriteLine("Correct paras");
            No = no;
            Name = name;
            Age = age;
            School = school;
        }
    }
    class ex1_4 {
        static void Main(string[] args) {
            System.Console.WriteLine("Test 1");
            Student stu1 = new Student("20188329", "sbw", "男", 20, "cs");
            System.Console.WriteLine("\nTest 2");
            Student stu2 = new Student("2018832x", "sbw", "男人", 201, "cs");
            System.Console.WriteLine("\nTest 3");
            Student stu3 = new Student("20188329x", "sbw", "男", 20, "cs");
        }
    }
}