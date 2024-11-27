namespace datalistview
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "tEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "lUONGCOBAN";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(177, 38);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(271, 20);
            this.txtMSNV.TabIndex = 3;
            this.txtMSNV.TextChanged += new System.EventHandler(this.txtMSNV_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(177, 78);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(271, 20);
            this.txtTenNV.TabIndex = 4;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(177, 128);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(271, 20);
            this.txtLuongCB.TabIndex = 5;
            this.txtLuongCB.TextChanged += new System.EventHandler(this.txtLuongCB_TextChanged);
            // 
            // btndongy
            // 
            this.btndongy.Location = new System.Drawing.Point(148, 213);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(75, 23);
            this.btndongy.TabIndex = 6;
            this.btndongy.Text = "dong y";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(345, 213);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(75, 23);
            this.btnboqua.TabIndex = 7;
            this.btnboqua.Text = "bo qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 311);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
    }
}