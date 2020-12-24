using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_1 {
    public partial class ex2_1 : Form {
        public ex2_1() {
            InitializeComponent();
        }

        public void setInfo() {
            string[] sexList = { "男", "女" };
            string[] hobbyList = { "爱好未知", "吃饭", "睡觉", "上课", "作业" };
            int sexIndex = MaleRadioButton.Checked ? 0 : 1;
            int[] hobbyIndex = { 0, 0, 0, 0, 0 };
            hobbyIndex[1] = HobbyCheckBox1.Checked ? 1 : 0;
            hobbyIndex[2] = HobbyCheckBox2.Checked ? 1 : 0;
            hobbyIndex[3] = HobbyCheckBox3.Checked ? 1 : 0;
            hobbyIndex[4] = HobbyCheckBox4.Checked ? 1 : 0;
            SexInfoLabel.Text = sexList[sexIndex];
            HobbyInfoLabel.Text = "";
            for (int i = 1; i <= 4; ++i) {
                HobbyInfoLabel.Text += hobbyIndex[i] == 1 ? hobbyList[i] + " " : "";
            }
            if (HobbyInfoLabel.Text == "")
                HobbyInfoLabel.Text = hobbyList[0];
        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e) {
            setInfo();
        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e) {
            setInfo();
        }

        private void HobbyCheckBox1_CheckedChanged(object sender, EventArgs e) {
            setInfo();
        }

        private void HobbyCheckBox2_CheckedChanged(object sender, EventArgs e) {
            setInfo();
        }

        private void HobbyCheckBox3_CheckedChanged(object sender, EventArgs e) {
            setInfo();
        }

        private void HobbyCheckBox4_CheckedChanged(object sender, EventArgs e) {
            setInfo();
        }
    }
}