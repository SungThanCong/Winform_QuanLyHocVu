namespace Nhom1_QuanLyHocVu.Dialog
{
    partial class TaoChuongTrinhMonHocDialog
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
            this.cbxMaMonHoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenChuongTrinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHocKi = new System.Windows.Forms.TextBox();
            this.cbxMaChuongTrinh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMaMonHoc
            // 
            this.cbxMaMonHoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaMonHoc.FormattingEnabled = true;
            this.cbxMaMonHoc.Location = new System.Drawing.Point(68, 202);
            this.cbxMaMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaMonHoc.Name = "cbxMaMonHoc";
            this.cbxMaMonHoc.Size = new System.Drawing.Size(679, 33);
            this.cbxMaMonHoc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Môn học";
            // 
            // txtTenChuongTrinh
            // 
            this.txtTenChuongTrinh.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChuongTrinh.Location = new System.Drawing.Point(251, 124);
            this.txtTenChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenChuongTrinh.Name = "txtTenChuongTrinh";
            this.txtTenChuongTrinh.ReadOnly = true;
            this.txtTenChuongTrinh.Size = new System.Drawing.Size(496, 30);
            this.txtTenChuongTrinh.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên chương trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Chương trình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chương trình môn học";
            // 
            // btnThem
            // 
            this.btnThem.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.btn_luu;
            this.btnThem.Location = new System.Drawing.Point(659, 322);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 42);
            this.btnThem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnThem.TabIndex = 19;
            this.btnThem.TabStop = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.btn_huy;
            this.btnHuy.Location = new System.Drawing.Point(571, 322);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 42);
            this.btnHuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHuy.TabIndex = 18;
            this.btnHuy.TabStop = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Học kì";
            // 
            // txtHocKi
            // 
            this.txtHocKi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKi.Location = new System.Drawing.Point(67, 286);
            this.txtHocKi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocKi.Name = "txtHocKi";
            this.txtHocKi.Size = new System.Drawing.Size(148, 30);
            this.txtHocKi.TabIndex = 24;
            // 
            // cbxMaChuongTrinh
            // 
            this.cbxMaChuongTrinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxMaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaChuongTrinh.FormattingEnabled = true;
            this.cbxMaChuongTrinh.Location = new System.Drawing.Point(68, 121);
            this.cbxMaChuongTrinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMaChuongTrinh.Name = "cbxMaChuongTrinh";
            this.cbxMaChuongTrinh.Size = new System.Drawing.Size(147, 33);
            this.cbxMaChuongTrinh.TabIndex = 25;
            this.cbxMaChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.cbxMaChuongTrinh_SelectedIndexChanged);
            // 
            // TaoChuongTrinhMonHocDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 416);
            this.Controls.Add(this.cbxMaChuongTrinh);
            this.Controls.Add(this.txtHocKi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxMaMonHoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenChuongTrinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TaoChuongTrinhMonHocDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoChuongTrinhMonHocDialog";
            ((System.ComponentModel.ISupportInitialize)(this.btnThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox cbxMaMonHoc;
        private System.Windows.Forms.PictureBox btnThem;
        private System.Windows.Forms.PictureBox btnHuy;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtTenChuongTrinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtHocKi;
        public System.Windows.Forms.ComboBox cbxMaChuongTrinh;
    }
}