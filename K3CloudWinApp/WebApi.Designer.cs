namespace K3CloudWinApp
{
    partial class WebApi
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
            this.btn_research = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.tb_show = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_research
            // 
            this.btn_research.Location = new System.Drawing.Point(263, 89);
            this.btn_research.Name = "btn_research";
            this.btn_research.Size = new System.Drawing.Size(124, 48);
            this.btn_research.TabIndex = 0;
            this.btn_research.Text = "查询";
            this.btn_research.UseVisualStyleBackColor = true;
            this.btn_research.Click += new System.EventHandler(this.btn_research_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "或者编码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入内码";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(235, 29);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 28);
            this.tb_id.TabIndex = 3;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(462, 29);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(108, 28);
            this.tb_number.TabIndex = 4;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(757, 89);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(144, 48);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "删除";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 89);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(155, 48);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "新增";
            this.btn_create.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(511, 89);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(127, 48);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // tb_show
            // 
            this.tb_show.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_show.Location = new System.Drawing.Point(42, 183);
            this.tb_show.Multiline = true;
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(982, 580);
            this.tb_show.TabIndex = 8;
            // 
            // WebApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 792);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_research);
            this.Name = "WebApi";
            this.Text = "客户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_research;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox tb_show;
    }
}