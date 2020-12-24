using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_2 {
    public partial class ex2_2 : Form {
        public ex2_2() {
            InitializeComponent();
        }

        private void ex2_2_Load(object sender, EventArgs e) {
            // ListBox 初始化
            listBoxYueShouRu.Items.Add("100 以下");
            listBoxYueShouRu.Items.Add("1000-2000");
            listBoxYueShouRu.Items.Add("2000-3000");
            listBoxYueShouRu.Items.Add("3000-4000");
            listBoxYueShouRu.Items.Add("4000-5000");
            listBoxYueShouRu.Items.Add("5000-6000");
            listBoxYueShouRu.Items.Add("6000-7000");
            listBoxYueShouRu.Items.Add("6000-7000");
            listBoxYueShouRu.Items.Add("7000-8000");
            listBoxYueShouRu.Items.Add("8000-9000");
            listBoxYueShouRu.Items.Add("9000-10000");
            listBoxYueShouRu.Items.Add("10000 以上");
            // ComboBox 初始化
            comboBoxZhengJianLeiXing.Items.Add("身份证");
            comboBoxZhengJianLeiXing.Items.Add("学生证");
            comboBoxZhengJianLeiXing.Items.Add("教师证");
            comboBoxZhengJianLeiXing.Items.Add("军人证");
            comboBoxZhengJianLeiXing.Items.Add("护照");
        }

        private void listBoxYueShouRu_SelectedIndexChanged(object sender, EventArgs e) {
            labelShouRu.Text = listBoxYueShouRu.SelectedItem.ToString();
        }

        private void comboBoxZhengJianLeiXing_SelectedIndexChanged(object sender, EventArgs e) {
            labelZhengJian.Text = comboBoxZhengJianLeiXing.SelectedItem.ToString();
        }
    }
}