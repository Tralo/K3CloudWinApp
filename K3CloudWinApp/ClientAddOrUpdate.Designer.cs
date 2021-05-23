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
            this.tb_clientname = new System.Windows.Forms.TextBox();
            this.btn_addUpdate = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_custId = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称";
            // 
            // tb_clientname
            // 
            this.tb_clientname.Location = new System.Drawing.Point(177, 38);
            this.tb_clientname.Name = "tb_clientname";
            this.tb_clientname.Size = new System.Drawing.Size(238, 28);
            this.tb_clientname.TabIndex = 1;
            // 
            // btn_addUpdate
            // 
            this.btn_addUpdate.Location = new System.Drawing.Point(448, 27);
            this.btn_addUpdate.Name = "btn_addUpdate";
            this.btn_addUpdate.Size = new System.Drawing.Size(115, 47);
            this.btn_addUpdate.TabIndex = 2;
            this.btn_addUpdate.Text = "新增";
            this.btn_addUpdate.UseVisualStyleBackColor = true;
            this.btn_addUpdate.Click += new System.EventHandler(this.btn_addUpdate_Click);
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(73, 240);
            this.tb_show.Multiline = true;
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(704, 261);
            this.tb_show.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "客户Id";
            // 
            // tb_custId
            // 
            this.tb_custId.Location = new System.Drawing.Point(177, 101);
            this.tb_custId.Name = "tb_custId";
            this.tb_custId.Size = new System.Drawing.Size(238, 28);
            this.tb_custId.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(448, 101);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 44);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // ClientAddOrUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 590);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tb_custId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.btn_addUpdate);
            this.Controls.Add(this.tb_clientname);
            this.Controls.Add(this.label1);
            this.Name = "ClientAddOrUpdate";
            this.Text = "客户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_clientname;
        private System.Windows.Forms.Button btn_addUpdate;
        private System.Windows.Forms.TextBox tb_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_custId;
        private System.Windows.Forms.Button btn_update;
    }
}