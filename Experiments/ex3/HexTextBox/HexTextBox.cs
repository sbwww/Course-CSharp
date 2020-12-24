using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexTextBox {
    public partial class HexTextBox : System.Windows.Forms.TextBox {
        public HexTextBox() {
            InitializeComponent();
        }

        private void hexTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            char c = e.KeyChar;
            System.Console.WriteLine(c);
            if (char.IsDigit(c) || c <= 'F' && c >= 'A') ;
            else if (c <= 'f' && c >= 'a') e.KeyChar = (char)(c + 'A' - 'a');
            else e.KeyChar = default;
            System.Console.WriteLine(Text);
            System.Console.WriteLine(Value);
            System.Console.WriteLine(HexString);
        }

        public int Value { get => Convert.ToInt32(Text, 16); set => Text = Convert.ToString(value, 16); }
        public string HexString { get => Text; set => Text = value; }
    }
}