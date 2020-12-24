using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_7 {
    public partial class ex2_7 : Form {
        public ex2_7() {
            InitializeComponent();
        }
        static int n = 0;
        private void ex2_7_Load(object sender, EventArgs e) {
            toolStripStatusLabel1.Text = "当前日期" + DateTime.Now.ToString();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e) {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            ++n;
            child.Text = "新建文件" + n;
            this.toolStripStatusLabel2.Text = "状态：新建文件";
            child.Show();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e) {
            ChildForm child = new ChildForm();
            openFileDialog1.Filter = "*.txt|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string strname = openFileDialog1.FileName;
                child.Text = strname;
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("utf-8"));
                child.richText = sr.ReadToEnd();
                sr.Close();
                child.MdiParent = this;
                child.Show();
                toolStripStatusLabel2.Text = toolStripStatusLabel1.Text + "打开文件";
            }
        }

        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.ActiveMdiChild != null) {
                ChildForm child = (ChildForm)this.ActiveMdiChild;
                this.fontDialog1.ShowDialog();
                fontDialog1.AllowVectorFonts = true;
                fontDialog1.FixedPitchOnly = true;
                fontDialog1.ShowApply = true;
                fontDialog1.ShowEffects = true;
                child.richBoxFont = fontDialog1.Font;
            }
        }

        private void 层叠AToolStripMenuItem_Click(object sender, EventArgs e) {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
