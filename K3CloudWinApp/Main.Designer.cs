namespace K3CloudWinApp
{
    partial class Main
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
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_material = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(45, 52);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(93, 38);
            this.btn_client.TabIndex = 0;
            this.btn_client.Text = "客户";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_material
            // 
            this.btn_material.Location = new System.Drawing.Point(203, 52);
            this.btn_material.Name = "btn_material";
            this.btn_material.Size = new System.Drawing.Size(103, 38);
            this.btn_material.TabIndex = 1;
            this.btn_material.Text = "物料";
            this.btn_material.UseVisualStyleBackColor = true;
            this.btn_material.Click += new System.EventHandler(this.btn_material_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Location = new System.Drawing.Point(365, 52);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(108, 38);
            this.btn_supplier.TabIndex = 2;
            this.btn_supplier.Text = "供应商";
            this.btn_supplier.UseVisualStyleBackColor = true;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 289);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.btn_material);
            this.Controls.Add(this.btn_client);
            this.Name = "Main";
            this.Text = "主界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_material;
        private System.Windows.Forms.Button btn_supplier;
    }
}