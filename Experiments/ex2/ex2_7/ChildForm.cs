using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_7 {
    public partial class ChildForm : Form {
        public ChildForm() {
            InitializeComponent();
        }
        private string strText = "";
        private Font boxFont = null;
        public string richText { get => strText; set => this.richTextBox1.Text = strText = value; }
        public Font richBoxFont { get => boxFont; set => this.richTextBox1.Font = value; }

        private void 清空DToolStripMenuItem_Click(object sender, EventArgs e) {
            this.richText = "";
        }

        private void 重置RToolStripMenuItem_Click(object sender, EventArgs e) {
            this.richText = "上下文菜单演示";
        }

        private void 帮助HToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("上下文菜单帮助","帮助");
        }

    }
}
