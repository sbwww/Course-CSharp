using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsgBoxMain {
    public partial class FormMain : Form {
        private ArrayList plugins = new ArrayList();
        public FormMain() {
            InitializeComponent();
        }
        private void LoadAllPlugs() {
            string[] files = Directory.GetFiles(Application.StartupPath + @"\plugins");
            foreach (string file in files) {
                if (file.ToUpper().EndsWith(".DLL")) {
                    try {
                        Assembly ab = Assembly.LoadFrom(file);
                        Type[] types = ab.GetTypes();
                        foreach (Type t in types) {
                            if (t.GetInterface("IMsgPlug") != null) {
                                plugins.Add(ab.CreateInstance(t.FullName));
                                listBox1.Items.Add(t.FullName);
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            LoadAllPlugs();
        }
        private void button2_Click(object sender, EventArgs e) {
            if (this.listBox1.SelectedIndex == -1) return;
            object selObj = this.plugins[this.listBox1.SelectedIndex];
            Type t = selObj.GetType();
            MethodInfo OnShowDlg = t.GetMethod("OnShowDlg");
            MethodInfo OnShowInfo = t.GetMethod("OnShowInfo");

            OnShowDlg.Invoke(selObj, null);
            object returnValue = OnShowInfo.Invoke(selObj, null);
            this.lblMsg.Text = returnValue.ToString();
        }
    }
}
