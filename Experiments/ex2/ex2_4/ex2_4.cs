using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_4 {
    public partial class ex2_4 : Form {
        public ex2_4() {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            string msg = "";
            msg += textBoxNumber.Text + "\n";
            msg += textBoxName.Text + "\n";
            msg += textBoxSignature.Text + "\n";
            if (radioButtonMale.Checked == true)
                msg += radioButtonMale.Text + "\n";
            else
                msg += radioButtonFemale.Text + "\n";
            msg += textBoxAge.Text + "\n";
            msg += comboBoxBloodType.Text + "\n";
            msg += comboBoxOccupation.Text + "\n";
            msg += comboBoxZodiac.Text + "\n";
            msg += dateTimePickerCalendar.Text + "\n";
            msg += textBoxEmail.Text + "\n";
            msg += textBoxAcademy.Text + "\n";
            msg += richTextBoxProfile.Text + "\n";
            MessageBox.Show(msg);
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            textBoxNumber.Text = default;
            textBoxName.Text = default;
            textBoxSignature.Text = default;
            radioButtonMale.Checked = default;
            radioButtonFemale.Checked = default;
            textBoxAge.Text = default;
            comboBoxBloodType.Text = default;
            comboBoxOccupation.Text = default;
            comboBoxZodiac.Text = default;
            dateTimePickerCalendar.Text = default;
            textBoxEmail.Text = default;
            textBoxAcademy.Text = default;
            richTextBoxProfile.Text = default;
        }
    }
}