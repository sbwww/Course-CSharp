using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex5_3 {
    public partial class Form2 : Form {
        private Thread thread1, thread2;
        private delegate void AppendStringDelegate(string str);
        private AppendStringDelegate appendStringDelegate;

        public Form2() {
            InitializeComponent();
            appendStringDelegate = new AppendStringDelegate(AppendString);
        }

        public void AppendString(string str) {
            textBox1.Text += str;
        }
        private void Method1() {
            while (true) {
                Thread.Sleep(100);
                textBox1.Invoke(appendStringDelegate, new object[] { "a" });
            }
        }
        private void Method2() {
            while (true) {
                Thread.Sleep(100);
                textBox1.Invoke(appendStringDelegate, new object[] { "b" });
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            thread1 = new Thread(new ThreadStart(Method1));
            thread2 = new Thread(new ThreadStart(Method2));
            thread1.Start();
            thread2.Start();
        }

        private void button2_Click(object sender, EventArgs e) {
            thread1.Abort();
            thread1.Join(10);
            thread2.Abort();
            thread2.Join(10);
            MessageBox.Show("线程1、2终止成功");
        }
    }
}