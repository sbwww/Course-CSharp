using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_6 {
    public partial class ex2_6 : Form {
        private Student student;
        public void CreateStudent(Student stu) { student = stu; }
        public bool IsNull() {
            if (txtID.Text.Trim() == "" ||
                txtName.Text.Trim() == "" ||
                txtSex.Text.Trim() == "" ||
                txtAge.Text.Trim() == "")
                return true;
            return false;
        }
        public bool IsIncomplete() {
            if (IsNull())
                return true;
            if (txtScor1.Text.Trim() == "" ||
                txtScor2.Text.Trim() == "")
                return true;
            return false;
        }
        public void SetStudent(string id, string name, string sex, int age, int scor1, int scor2) {
            student.Id = id;
            student.Name = name;
            student.Sex = sex;
            student.Age = age;
            student.Scor1 = scor1;
            student.Scor2 = scor2;
        }
        public string CountScor(Student s) {
            string result = "";
            result += "成绩1：" + student.Scor1 + "\n成绩2：" + student.Scor2;
            return result;
        }
        public string ShowStudent(Student stu) {
            string result = "";
            result += "学号：" + student.Id + "\n姓名：" + student.Name + "\n性别：" + student.Sex + "\n年龄：" + student.Age;
            if (student.Scor1 >= 0)
                result += "\n成绩1：" + student.Scor1;
            if (student.Scor2 >= 0)
                result += "\n成绩2：" + student.Scor2;
            return result;
        }

        public ex2_6() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (IsNull()) {
                lblResult.Text = "请重新输入信息";
            } else if (IsIncomplete()) {
                Student stu = new Student(
                    txtID.Text.Trim(),
                    txtName.Text.Trim(),
                    txtSex.Text.Trim(),
                    Convert.ToInt32(txtAge.Text.Trim())
                );
                student = stu;
            } else {
                Student stu = new Student(
                    txtID.Text.Trim(),
                    txtName.Text.Trim(),
                    txtSex.Text.Trim(),
                    Convert.ToInt32(txtAge.Text.Trim()),
                    Convert.ToInt32(txtScor1.Text.Trim()),
                    Convert.ToInt32(txtScor2.Text.Trim())
                );
                student = stu;
            }
            lblResult.Text = ShowStudent(student);
        }

        private void button2_Click(object sender, EventArgs e) {
            if (txtID.Text.Trim() == student.Id &&
                txtName.Text.Trim() == student.Name &&
                txtSex.Text.Trim() == student.Sex &&
                Convert.ToInt32(txtAge.Text.Trim()) == student.Age &&
                Convert.ToInt32(txtScor1.Text.Trim()) == student.Scor1 &&
                Convert.ToInt32(txtScor2.Text.Trim()) == student.Scor2) {
                lblResult.Text = "无改动";
            } else {
                if (IsNull()) {
                    lblResult.Text = "请重新输入信息";
                } else if (IsIncomplete()) {
                    SetStudent(txtID.Text.Trim(),
                        txtName.Text.Trim(),
                        txtSex.Text.Trim(),
                        Convert.ToInt32(txtAge.Text.Trim()),
                        default, default
                    );
                    lblResult.Text = ShowStudent(student);
                } else {
                    SetStudent(txtID.Text.Trim(),
                        txtName.Text.Trim(),
                        txtSex.Text.Trim(),
                        Convert.ToInt32(txtAge.Text.Trim()),
                        Convert.ToInt32(txtScor1.Text.Trim()),
                        Convert.ToInt32(txtScor2.Text.Trim())
                    );
                }
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            string result = "";
            result += "总分：" + student.Total();
            result += "\n均分：" + student.Average();
            lblResult.Text = result;
        }
    }
}