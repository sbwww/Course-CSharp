using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using mcMath;

namespace ex3_1 {
    public partial class mcClient : Form {
        public mcClient() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            mcMathComp number = new mcMathComp();
            number.tra = number.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            if (number.tra < 0) {
                MessageBox.Show("和为负", "提示");
            }
            textBox4.Text = number.tra.ToString();
        }
    }
}