using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_6 {
    static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ex2_6());
        }
    }

    public class Student {
        private string id, name, sex;
        private int age, scor1, scor2;

        public Student(string id, string name, string sex, int age, int scor1, int scor2) {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.scor1 = scor1;
            this.scor2 = scor2;
        }

        public Student(string id, string name, string sex, int age) {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public int Scor1 { get => scor1; set => scor1 = value; }
        public int Scor2 { get => scor2; set => scor2 = value; }

        public int Total() {
            return Scor1 + Scor2;
        }

        public double Average() {
            return (0.0 + Scor1 + Scor2) / 2;
        }

    }

}
