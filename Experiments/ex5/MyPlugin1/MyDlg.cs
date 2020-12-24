using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMsg;

namespace MyPlugin1 {
    public class MyDlg : Form, IMsgPlug {
        public void OnShowDlg() {
            this.Text = "插件子窗体 申博文";
            this.ShowDialog();
        }
        public string OnShowInfo() {
            return "MyDlg";
            // throw new NotImplementedException();
        }
    }
}
