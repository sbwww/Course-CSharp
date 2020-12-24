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
    public partial class Form1 : Form {
        private StringBuilder sb = new StringBuilder();
        private Thread thread1, thread2;

        public Form1() {
            InitializeComponent();
        }

        private void AppendString(string s) {
            lock(sb) {
                sb.Append(s);
            }
        }
        private void Method1() {
            while (true) {
                Thread.Sleep(100);
                AppendString("a");
            }
        }

        private void Method2() {
            while (true) {
                Thread.Sleep(100);
                AppendString("b");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            sb.Remove(0, sb.Length);
            timer1.Enabled = true;
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
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (thread1.IsAlive || thread2.IsAlive)textBox1.Text = sb.ToString();
            else timer1.Enabled = false;
        }
    }
}