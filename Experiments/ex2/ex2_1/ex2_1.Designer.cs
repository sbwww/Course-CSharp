namespace ex2_1 {
    partial class ex2_1 {
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
            this.SexGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.HobbyGroupBox = new System.Windows.Forms.GroupBox();
            this.HobbyCheckBox4 = new System.Windows.Forms.CheckBox();
            this.HobbyCheckBox3 = new System.Windows.Forms.CheckBox();
            this.HobbyCheckBox2 = new System.Windows.Forms.CheckBox();
            this.HobbyCheckBox1 = new System.Windows.Forms.CheckBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.HobbyInfoLabel = new System.Windows.Forms.Label();
            this.SexInfoLabel = new System.Windows.Forms.Label();
            this.SexGroupBox.SuspendLayout();
            this.HobbyGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SexGroupBox
            // 
            this.SexGroupBox.Controls.Add(this.FemaleRadioButton);
            this.SexGroupBox.Controls.Add(this.MaleRadioButton);
            this.SexGroupBox.Location = new System.Drawing.Point(86, 61);
            this.SexGroupBox.Name = "SexGroupBox";
            this.SexGroupBox.Size = new System.Drawing.Size(200, 194);
            this.SexGroupBox.TabIndex = 0;
            this.SexGroupBox.TabStop = false;
            this.SexGroupBox.Text = "性别";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FemaleRadioButton.Location = new System.Drawing.Point(21, 121);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(51, 22);
            this.FemaleRadioButton.TabIndex = 3;
            this.FemaleRadioButton.Text = "女";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            this.FemaleRadioButton.CheckedChanged += new System.EventHandler(this.FemaleRadioButton_CheckedChanged);
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaleRadioButton.Location = new System.Drawing.Point(21, 54);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(51, 22);
            this.MaleRadioButton.TabIndex = 2;
            this.MaleRadioButton.Text = "男";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            this.MaleRadioButton.CheckedChanged += new System.EventHandler(this.MaleRadioButton_CheckedChanged);
            // 
            // HobbyGroupBox
            // 
            this.HobbyGroupBox.Controls.Add(this.HobbyCheckBox4);
            this.HobbyGroupBox.Controls.Add(this.HobbyCheckBox3);
            this.HobbyGroupBox.Controls.Add(this.HobbyCheckBox2);
            this.HobbyGroupBox.Controls.Add(this.HobbyCheckBox1);
            this.HobbyGroupBox.Location = new System.Drawing.Point(394, 61);
            this.HobbyGroupBox.Name = "HobbyGroupBox";
            this.HobbyGroupBox.Size = new System.Drawing.Size(328, 194);
            this.HobbyGroupBox.TabIndex = 1;
            this.HobbyGroupBox.TabStop = false;
            this.HobbyGroupBox.Text = "爱好";
            // 
            // HobbyCheckBox4
            // 
            this.HobbyCheckBox4.AutoSize = true;
            this.HobbyCheckBox4.Location = new System.Drawing.Point(151, 122);
            this.HobbyCheckBox4.Name = "HobbyCheckBox4";
            this.HobbyCheckBox4.Size = new System.Drawing.Size(79, 22);
            this.HobbyCheckBox4.TabIndex = 3;
            this.HobbyCheckBox4.Text = "爱好4";
            this.HobbyCheckBox4.UseVisualStyleBackColor = true;
            this.HobbyCheckBox4.CheckedChanged += new System.EventHandler(this.HobbyCheckBox4_CheckedChanged);
            // 
            // HobbyCheckBox3
            // 
            this.HobbyCheckBox3.AutoSize = true;
            this.HobbyCheckBox3.Location = new System.Drawing.Point(30, 122);
            this.HobbyCheckBox3.Name = "HobbyCheckBox3";
            this.HobbyCheckBox3.Size = new System.Drawing.Size(79, 22);
            this.HobbyCheckBox3.TabIndex = 2;
            this.HobbyCheckBox3.Text = "爱好3";
            this.HobbyCheckBox3.UseVisualStyleBackColor = true;
            this.HobbyCheckBox3.CheckedChanged += new System.EventHandler(this.HobbyCheckBox3_CheckedChanged);
            // 
            // HobbyCheckBox2
            // 
            this.HobbyCheckBox2.AutoSize = true;
            this.HobbyCheckBox2.Location = new System.Drawing.Point(151, 56);
            this.HobbyCheckBox2.Name = "HobbyCheckBox2";
            this.HobbyCheckBox2.Size = new System.Drawing.Size(79, 22);
            this.HobbyCheckBox2.TabIndex = 1;
            this.HobbyCheckBox2.Text = "爱好2";
            this.HobbyCheckBox2.UseVisualStyleBackColor = true;
            this.HobbyCheckBox2.CheckedChanged += new System.EventHandler(this.HobbyCheckBox2_CheckedChanged);
            // 
            // HobbyCheckBox1
            // 
            this.HobbyCheckBox1.AutoSize = true;
            this.HobbyCheckBox1.Location = new System.Drawing.Point(30, 55);
            this.HobbyCheckBox1.Name = "HobbyCheckBox1";
            this.HobbyCheckBox1.Size = new System.Drawing.Size(79, 22);
            this.HobbyCheckBox1.TabIndex = 0;
            this.HobbyCheckBox1.Text = "爱好1";
            this.HobbyCheckBox1.UseVisualStyleBackColor = true;
            this.HobbyCheckBox1.CheckedChanged += new System.EventHandler(this.HobbyCheckBox1_CheckedChanged);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.HobbyInfoLabel);
            this.InfoGroupBox.Controls.Add(this.SexInfoLabel);
            this.InfoGroupBox.Location = new System.Drawing.Point(86, 284);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(636, 141);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "用户信息";
            // 
            // HobbyInfoLabel
            // 
            this.HobbyInfoLabel.AutoSize = true;
            this.HobbyInfoLabel.Location = new System.Drawing.Point(18, 108);
            this.HobbyInfoLabel.Name = "HobbyInfoLabel";
            this.HobbyInfoLabel.Size = new System.Drawing.Size(80, 18);
            this.HobbyInfoLabel.TabIndex = 1;
            this.HobbyInfoLabel.Text = "爱好未知";
            // 
            // SexInfoLabel
            // 
            this.SexInfoLabel.AutoSize = true;
            this.SexInfoLabel.Location = new System.Drawing.Point(18, 43);
            this.SexInfoLabel.Name = "SexInfoLabel";
            this.SexInfoLabel.Size = new System.Drawing.Size(80, 18);
            this.SexInfoLabel.TabIndex = 0;
            this.SexInfoLabel.Text = "性别未知";
            // 
            // ex2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.HobbyGroupBox);
            this.Controls.Add(this.SexGroupBox);
            this.Name = "ex2_1";
            this.Text = "单选框和复选框";
            this.SexGroupBox.ResumeLayout(false);
            this.SexGroupBox.PerformLayout();
            this.HobbyGroupBox.ResumeLayout(false);
            this.HobbyGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SexGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.GroupBox HobbyGroupBox;
        private System.Windows.Forms.CheckBox HobbyCheckBox4;
        private System.Windows.Forms.CheckBox HobbyCheckBox3;
        private System.Windows.Forms.CheckBox HobbyCheckBox2;
        private System.Windows.Forms.CheckBox HobbyCheckBox1;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label HobbyInfoLabel;
        private System.Windows.Forms.Label SexInfoLabel;
    }
}