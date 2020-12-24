namespace ex2_2 {
    partial class ex2_2 {
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
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.labelShouRu = new System.Windows.Forms.Label();
            this.labelZhengJian = new System.Windows.Forms.Label();
            this.listBoxYueShouRu = new System.Windows.Forms.ListBox();
            this.comboBoxZhengJianLeiXing = new System.Windows.Forms.ComboBox();
            this.labelYueShouRu = new System.Windows.Forms.Label();
            this.labelZhengJianLeiXing = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.labelShouRu);
            this.groupBoxUser.Controls.Add(this.labelZhengJian);
            this.groupBoxUser.Location = new System.Drawing.Point(369, 89);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(369, 268);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "用户信息";
            // 
            // labelShouRu
            // 
            this.labelShouRu.AutoSize = true;
            this.labelShouRu.Location = new System.Drawing.Point(18, 81);
            this.labelShouRu.Name = "labelShouRu";
            this.labelShouRu.Size = new System.Drawing.Size(44, 18);
            this.labelShouRu.TabIndex = 0;
            this.labelShouRu.Text = "收入";
            // 
            // labelZhengJian
            // 
            this.labelZhengJian.AutoSize = true;
            this.labelZhengJian.Location = new System.Drawing.Point(18, 167);
            this.labelZhengJian.Name = "labelZhengJian";
            this.labelZhengJian.Size = new System.Drawing.Size(44, 18);
            this.labelZhengJian.TabIndex = 3;
            this.labelZhengJian.Text = "证件";
            // 
            // listBoxYueShouRu
            // 
            this.listBoxYueShouRu.FormattingEnabled = true;
            this.listBoxYueShouRu.ItemHeight = 18;
            this.listBoxYueShouRu.Location = new System.Drawing.Point(93, 122);
            this.listBoxYueShouRu.Name = "listBoxYueShouRu";
            this.listBoxYueShouRu.Size = new System.Drawing.Size(228, 130);
            this.listBoxYueShouRu.TabIndex = 1;
            this.listBoxYueShouRu.SelectedIndexChanged += new System.EventHandler(this.listBoxYueShouRu_SelectedIndexChanged);
            // 
            // comboBoxZhengJianLeiXing
            // 
            this.comboBoxZhengJianLeiXing.FormattingEnabled = true;
            this.comboBoxZhengJianLeiXing.Location = new System.Drawing.Point(93, 331);
            this.comboBoxZhengJianLeiXing.Name = "comboBoxZhengJianLeiXing";
            this.comboBoxZhengJianLeiXing.Size = new System.Drawing.Size(121, 26);
            this.comboBoxZhengJianLeiXing.TabIndex = 2;
            this.comboBoxZhengJianLeiXing.SelectedIndexChanged += new System.EventHandler(this.comboBoxZhengJianLeiXing_SelectedIndexChanged);
            // 
            // labelYueShouRu
            // 
            this.labelYueShouRu.AutoSize = true;
            this.labelYueShouRu.Location = new System.Drawing.Point(90, 89);
            this.labelYueShouRu.Name = "labelYueShouRu";
            this.labelYueShouRu.Size = new System.Drawing.Size(62, 18);
            this.labelYueShouRu.TabIndex = 4;
            this.labelYueShouRu.Text = "月收入";
            // 
            // labelZhengJianLeiXing
            // 
            this.labelZhengJianLeiXing.AutoSize = true;
            this.labelZhengJianLeiXing.Location = new System.Drawing.Point(90, 293);
            this.labelZhengJianLeiXing.Name = "labelZhengJianLeiXing";
            this.labelZhengJianLeiXing.Size = new System.Drawing.Size(80, 18);
            this.labelZhengJianLeiXing.TabIndex = 5;
            this.labelZhengJianLeiXing.Text = "证件类型";
            // 
            // ex2_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelZhengJianLeiXing);
            this.Controls.Add(this.labelYueShouRu);
            this.Controls.Add(this.comboBoxZhengJianLeiXing);
            this.Controls.Add(this.listBoxYueShouRu);
            this.Controls.Add(this.groupBoxUser);
            this.Name = "ex2_2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ex2_2_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label labelShouRu;
        private System.Windows.Forms.Label labelZhengJian;
        private System.Windows.Forms.ListBox listBoxYueShouRu;
        private System.Windows.Forms.ComboBox comboBoxZhengJianLeiXing;
        private System.Windows.Forms.Label labelYueShouRu;
        private System.Windows.Forms.Label labelZhengJianLeiXing;
    }
}

