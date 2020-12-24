using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5_2 {
    public partial class Form1 : Form {

        List<PhoneBook> MyPB;

        public Form1() {
            InitializeComponent();
        }

        private void FillList(List<PhoneBook> MyPB) {
            listView1.Items.Clear();
            foreach (PhoneBook PB in MyPB) {
                ListViewItem item = new ListViewItem(PB.Name);
                item.SubItems.AddRange(new string[] { PB.Number, PB.Email });
                listView1.Items.Add(item);
            }
            MyPB.Sort(new NameComparer());
        }

        private void Form1_Load(object sender, EventArgs e) {
            MyPB = new List<PhoneBook>();
            PhoneBook zhang = new PhoneBook("张", "12345678", "zhang@163.com");
            PhoneBook li = new PhoneBook("李", "12345678", "li@163.com");
            PhoneBook wang = new PhoneBook("王", "12345678", "wang@163.com");
            MyPB.Add(zhang);
            MyPB.Add(li);
            MyPB.Add(wang);
            FillList(MyPB);
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!Regex.IsMatch(txtName.Text, "[\u4e00-\u9fa5]$") || !Regex.IsMatch(txtNumber.Text, @"^0{0,1}(13[0-9]|15[7-9]|15[0-2]|18[6-8])[0-9]{8}$") || !Regex.IsMatch(txtEmail.Text, @"^\w+([-+.]w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")) {
                MessageBox.Show("输入有误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            PhoneBook phone = new PhoneBook(txtName.Text, txtNumber.Text, txtEmail.Text);
            MyPB.Add(phone);
            FillList(MyPB);
            txtName.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
        }

        private void button2_Click(object sender, EventArgs e) {
            if (listView1.SelectedItems.Count == 0) {
                MessageBox.Show("没有删除选项");
                return;
            }
            int index = listView1.SelectedItems[0].Index;
            MyPB.RemoveAt(index);
            FillList(MyPB);
            txtName.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) {
            string count = string.Format("总共有{0}个电话", MyPB.Count.ToString());
            MessageBox.Show(count);
        }

        private void button4_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void 写入ToolStripMenuItem_Click(object sender, EventArgs e) {
            FileStream FS = new FileStream(Application.StartupPath + "address.dat", FileMode.OpenOrCreate);
            BinaryWriter BW = new BinaryWriter(FS);
            foreach (PhoneBook PB in MyPB) {
                BW.Write(PB.Name);
                BW.Write(PB.Number);
                BW.Write(PB.Email);
            }
            FS.Close();
            BW.Close();
        }

        private void 读取ToolStripMenuItem_Click(object sender, EventArgs e) {
            FileStream FS = new FileStream(Application.StartupPath + "address.dat", FileMode.Open);
            BinaryReader BR = new BinaryReader(FS);
            while (BR.PeekChar() != -1) {
                PhoneBook PB = new PhoneBook(BR.ReadString(), BR.ReadString(), BR.ReadString());
                MyPB.Add(PB);
            }
            FS.Close();
            BR.Close();
            FillList(MyPB);
        }
    }
}