namespace ex3_3 {
    partial class Form1 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labeledTextBox3 = new LabeledTextBox.LabeledTextBox();
            this.labeledTextBox2 = new LabeledTextBox.LabeledTextBox();
            this.labeledTextBox1 = new LabeledTextBox.LabeledTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(269, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Results";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeledTextBox3
            // 
            this.labeledTextBox3.Location = new System.Drawing.Point(410, 35);
            this.labeledTextBox3.lText = "年龄";
            this.labeledTextBox3.Name = "labeledTextBox3";
            this.labeledTextBox3.Size = new System.Drawing.Size(193, 100);
            this.labeledTextBox3.TabIndex = 2;
            this.labeledTextBox3.tText = "";
            // 
            // labeledTextBox2
            // 
            this.labeledTextBox2.Location = new System.Drawing.Point(211, 35);
            this.labeledTextBox2.lText = "性别";
            this.labeledTextBox2.Name = "labeledTextBox2";
            this.labeledTextBox2.Size = new System.Drawing.Size(193, 100);
            this.labeledTextBox2.TabIndex = 1;
            this.labeledTextBox2.tText = "";
            // 
            // labeledTextBox1
            // 
            this.labeledTextBox1.Location = new System.Drawing.Point(12, 35);
            this.labeledTextBox1.lText = "姓名";
            this.labeledTextBox1.Name = "labeledTextBox1";
            this.labeledTextBox1.Size = new System.Drawing.Size(193, 100);
            this.labeledTextBox1.TabIndex = 0;
            this.labeledTextBox1.tText = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeledTextBox3);
            this.Controls.Add(this.labeledTextBox2);
            this.Controls.Add(this.labeledTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabeledTextBox.LabeledTextBox labeledTextBox1;
        private LabeledTextBox.LabeledTextBox labeledTextBox2;
        private LabeledTextBox.LabeledTextBox labeledTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

