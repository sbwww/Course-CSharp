namespace ex2_3 {
    partial class ex2_3 {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerCalendar = new System.Windows.Forms.DateTimePicker();
            this.monthCalendarCalendar = new System.Windows.Forms.MonthCalendar();
            this.trackBarCalendar = new System.Windows.Forms.TrackBar();
            this.labelLowSpeed = new System.Windows.Forms.Label();
            this.labelHighSpeed = new System.Windows.Forms.Label();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.timerCalendar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerCalendar
            // 
            this.dateTimePickerCalendar.Location = new System.Drawing.Point(373, 59);
            this.dateTimePickerCalendar.Name = "dateTimePickerCalendar";
            this.dateTimePickerCalendar.ShowUpDown = true;
            this.dateTimePickerCalendar.Size = new System.Drawing.Size(305, 28);
            this.dateTimePickerCalendar.TabIndex = 0;
            // 
            // monthCalendarCalendar
            // 
            this.monthCalendarCalendar.Location = new System.Drawing.Point(373, 115);
            this.monthCalendarCalendar.Name = "monthCalendarCalendar";
            this.monthCalendarCalendar.TabIndex = 1;
            // 
            // trackBarCalendar
            // 
            this.trackBarCalendar.Location = new System.Drawing.Point(76, 78);
            this.trackBarCalendar.Name = "trackBarCalendar";
            this.trackBarCalendar.Size = new System.Drawing.Size(183, 69);
            this.trackBarCalendar.TabIndex = 2;
            this.trackBarCalendar.Scroll += new System.EventHandler(this.trackBarCalendar_Scroll);
            // 
            // labelLowSpeed
            // 
            this.labelLowSpeed.AutoSize = true;
            this.labelLowSpeed.Location = new System.Drawing.Point(73, 150);
            this.labelLowSpeed.Name = "labelLowSpeed";
            this.labelLowSpeed.Size = new System.Drawing.Size(44, 18);
            this.labelLowSpeed.TabIndex = 3;
            this.labelLowSpeed.Text = "低速";
            // 
            // labelHighSpeed
            // 
            this.labelHighSpeed.AutoSize = true;
            this.labelHighSpeed.Location = new System.Drawing.Point(222, 150);
            this.labelHighSpeed.Name = "labelHighSpeed";
            this.labelHighSpeed.Size = new System.Drawing.Size(44, 18);
            this.labelHighSpeed.TabIndex = 4;
            this.labelHighSpeed.Text = "高速";
            // 
            // buttonRun
            // 
            this.buttonRun.Enabled = false;
            this.buttonRun.ForeColor = System.Drawing.SystemColors.GrayText;
            this.buttonRun.Location = new System.Drawing.Point(130, 215);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 40);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "运行";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(130, 261);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 40);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(130, 307);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 38);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "重置";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // timerCalendar
            // 
            this.timerCalendar.Enabled = true;
            this.timerCalendar.Interval = 1000;
            this.timerCalendar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ex2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.labelHighSpeed);
            this.Controls.Add(this.labelLowSpeed);
            this.Controls.Add(this.trackBarCalendar);
            this.Controls.Add(this.monthCalendarCalendar);
            this.Controls.Add(this.dateTimePickerCalendar);
            this.Name = "ex2_3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ex2_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerCalendar;
        private System.Windows.Forms.MonthCalendar monthCalendarCalendar;
        private System.Windows.Forms.TrackBar trackBarCalendar;
        private System.Windows.Forms.Label labelLowSpeed;
        private System.Windows.Forms.Label labelHighSpeed;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Timer timerCalendar;
    }
}

