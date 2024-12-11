namespace BT_BUOI4
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
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtLuongcanban = new System.Windows.Forms.TextBox();
            this.btn_dongy = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lương căn bản";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(291, 77);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(236, 22);
            this.txtMSSV.TabIndex = 1;
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.Location = new System.Drawing.Point(291, 150);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(236, 22);
            this.txtTennhanvien.TabIndex = 4;
            // 
            // txtLuongcanban
            // 
            this.txtLuongcanban.Location = new System.Drawing.Point(291, 218);
            this.txtLuongcanban.Name = "txtLuongcanban";
            this.txtLuongcanban.Size = new System.Drawing.Size(236, 22);
            this.txtLuongcanban.TabIndex = 5;
            // 
            // btn_dongy
            // 
            this.btn_dongy.Location = new System.Drawing.Point(191, 291);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(113, 41);
            this.btn_dongy.TabIndex = 6;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.UseVisualStyleBackColor = true;
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click_1);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(376, 291);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(97, 41);
            this.btn_boqua.TabIndex = 7;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.txtLuongcanban);
            this.Controls.Add(this.txtTennhanvien);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.TextBox txtLuongcanban;
        private System.Windows.Forms.Button btn_dongy;
        private System.Windows.Forms.Button btn_boqua;
    }
}