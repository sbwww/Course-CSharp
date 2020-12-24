namespace ex3_2 {
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
            this.hexTextBox1 = new HexTextBox.HexTextBox();
            this.SuspendLayout();
            // 
            // hexTextBox1
            // 
            this.hexTextBox1.HexString = "0";
            this.hexTextBox1.Location = new System.Drawing.Point(108, 136);
            this.hexTextBox1.Name = "hexTextBox1";
            this.hexTextBox1.Size = new System.Drawing.Size(604, 28);
            this.hexTextBox1.TabIndex = 0;
            this.hexTextBox1.Text = "0";
            this.hexTextBox1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hexTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HexTextBox.HexTextBox hexTextBox1;
    }
}

