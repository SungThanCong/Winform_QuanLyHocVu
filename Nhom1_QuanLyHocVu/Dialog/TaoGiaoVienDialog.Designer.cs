namespace Nhom1_QuanLyHocVu.Dialog
{
    partial class TaoGiaoVienDialog
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
            this.btnHuyTaoGV = new System.Windows.Forms.Button();
            this.btnXacNhanTaoGV = new System.Windows.Forms.Button();
            this.txtTaoTenGV = new System.Windows.Forms.TextBox();
            this.txtTaoMaGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaKhoaTaoGV = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHuyTaoGV
            // 
            this.btnHuyTaoGV.Location = new System.Drawing.Point(316, 261);
            this.btnHuyTaoGV.Name = "btnHuyTaoGV";
            this.btnHuyTaoGV.Size = new System.Drawing.Size(83, 33);
            this.btnHuyTaoGV.TabIndex = 13;
            this.btnHuyTaoGV.Text = "Hủy";
            this.btnHuyTaoGV.UseVisualStyleBackColor = true;
            this.btnHuyTaoGV.Click += new System.EventHandler(this.btnHuyTaoGV_Click);
            // 
            // btnXacNhanTaoGV
            // 
            this.btnXacNhanTaoGV.Location = new System.Drawing.Point(186, 261);
            this.btnXacNhanTaoGV.Name = "btnXacNhanTaoGV";
            this.btnXacNhanTaoGV.Size = new System.Drawing.Size(118, 33);
            this.btnXacNhanTaoGV.TabIndex = 12;
            this.btnXacNhanTaoGV.Text = "Xác nhận";
            this.btnXacNhanTaoGV.UseVisualStyleBackColor = true;
            this.btnXacNhanTaoGV.Click += new System.EventHandler(this.btnXacNhanTaoGV_Click);
            // 
            // txtTaoTenGV
            // 
            this.txtTaoTenGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaoTenGV.Location = new System.Drawing.Point(216, 150);
            this.txtTaoTenGV.Name = "txtTaoTenGV";
            this.txtTaoTenGV.Size = new System.Drawing.Size(267, 27);
            this.txtTaoTenGV.TabIndex = 11;
            // 
            // txtTaoMaGV
            // 
            this.txtTaoMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaoMaGV.Location = new System.Drawing.Point(216, 98);
            this.txtTaoMaGV.Name = "txtTaoMaGV";
            this.txtTaoMaGV.Size = new System.Drawing.Size(267, 27);
            this.txtTaoMaGV.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên giáo viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập giáo viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã khoa";
            // 
            // cboMaKhoaTaoGV
            // 
            this.cboMaKhoaTaoGV.FormattingEnabled = true;
            this.cboMaKhoaTaoGV.Location = new System.Drawing.Point(216, 205);
            this.cboMaKhoaTaoGV.Name = "cboMaKhoaTaoGV";
            this.cboMaKhoaTaoGV.Size = new System.Drawing.Size(121, 24);
            this.cboMaKhoaTaoGV.TabIndex = 15;
            // 
            // TaoGiaoVienDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 321);
            this.Controls.Add(this.cboMaKhoaTaoGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuyTaoGV);
            this.Controls.Add(this.btnXacNhanTaoGV);
            this.Controls.Add(this.txtTaoTenGV);
            this.Controls.Add(this.txtTaoMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaoGiaoVienDialog";
            this.Text = "TaoGiaoVienDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuyTaoGV;
        private System.Windows.Forms.Button btnXacNhanTaoGV;
        public System.Windows.Forms.TextBox txtTaoTenGV;
        public System.Windows.Forms.TextBox txtTaoMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboMaKhoaTaoGV;
    }
}