using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2_3 {
    public partial class ex2_3 : Form {
        public ex2_3() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            dateTimePickerCalendar.Value = dateTimePickerCalendar.Value.AddSeconds(trackBarCalendar.Value * 60 + 1);
            monthCalendarCalendar.TodayDate = dateTimePickerCalendar.Value;
        }

        private void ex2_3_Load(object sender, EventArgs e) {
            dateTimePickerCalendar.Value = DateTime.Now;
            monthCalendarCalendar.TodayDate = DateTime.Now;
        }

        private void trackBarCalendar_Scroll(object sender, EventArgs e) {
            if (trackBarCalendar.Value > 0)
                timerCalendar.Interval = 10;
            else
                timerCalendar.Interval = 1000;
        }

        private void buttonRun_Click(object sender, EventArgs e) {
            buttonStop.ForeColor = buttonReset.ForeColor;
            buttonStop.Enabled = true;
            timerCalendar.Enabled = true;
            buttonRun.ForeColor = Color.Gray;
            buttonRun.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            buttonRun.ForeColor = buttonReset.ForeColor;
            buttonRun.Enabled = true;
            timerCalendar.Enabled = false;
            buttonStop.ForeColor = Color.Gray;
            buttonStop.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e) {
            trackBarCalendar.Value = 0;
            dateTimePickerCalendar.ResetText();
        }
    }
}
