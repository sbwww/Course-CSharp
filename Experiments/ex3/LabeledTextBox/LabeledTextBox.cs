using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabeledTextBox {
    public partial class LabeledTextBox : UserControl {
        public LabeledTextBox() {
            InitializeComponent();
        }
        public string tText { get => textBox1.Text; set => textBox1.Text = value; }
        public string lText { get => label1.Text; set => label1.Text = value; }
    }
}
