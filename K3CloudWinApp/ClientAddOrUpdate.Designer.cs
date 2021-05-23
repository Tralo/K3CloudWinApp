namespace K3CloudWinApp
{
    partial class ClientAddOrUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addUpdate = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 1;
            // 
            // btn_addUpdate
            // 
            this.btn_addUpdate.Location = new System.Drawing.Point(414, 27);
            this.btn_addUpdate.Name = "btn_addUpdate";
            this.btn_addUpdate.Size = new System.Drawing.Size(115, 47);
            this.btn_addUpdate.TabIndex = 2;
            this.btn_addUpdate.Text = "新增";
            this.btn_addUpdate.UseVisualStyleBackColor = true;
            this.btn_addUpdate.Click += new System.EventHandler(this.btn_addUpdate_Click);
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(58, 108);
            this.tb_show.Multiline = true;
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(704, 261);
            this.tb_show.TabIndex = 3;
            // 
            // ClientAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 590);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.btn_addUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ClientAddOrUpdate";
            this.Text = "客户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addUpdate;
        private System.Windows.Forms.TextBox tb_show;
    }
}