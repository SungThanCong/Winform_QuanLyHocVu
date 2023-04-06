namespace Nhom1_QuanLyHocVu.Dialog
{
    partial class TaoKhoaDialog
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
            this.txtTaoMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTaoTenKhoa = new System.Windows.Forms.TextBox();
            this.btnXacNhanTaoKhoa = new System.Windows.Forms.Button();
            this.btnHuyTaoKhoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khoa";
            // 
            // txtTaoMaKhoa
            // 
            this.txtTaoMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaoMaKhoa.Location = new System.Drawing.Point(165, 69);
            this.txtTaoMaKhoa.Name = "txtTaoMaKhoa";
            this.txtTaoMaKhoa.Size = new System.Drawing.Size(267, 27);
            this.txtTaoMaKhoa.TabIndex = 3;
            // 
            // txtTaoTenKhoa
            // 
            this.txtTaoTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaoTenKhoa.Location = new System.Drawing.Point(165, 121);
            this.txtTaoTenKhoa.Name = "txtTaoTenKhoa";
            this.txtTaoTenKhoa.Size = new System.Drawing.Size(267, 27);
            this.txtTaoTenKhoa.TabIndex = 4;
            // 
            // btnXacNhanTaoKhoa
            // 
            this.btnXacNhanTaoKhoa.Location = new System.Drawing.Point(141, 175);
            this.btnXacNhanTaoKhoa.Name = "btnXacNhanTaoKhoa";
            this.btnXacNhanTaoKhoa.Size = new System.Drawing.Size(118, 33);
            this.btnXacNhanTaoKhoa.TabIndex = 5;
            this.btnXacNhanTaoKhoa.Text = "Xác nhận";
            this.btnXacNhanTaoKhoa.UseVisualStyleBackColor = true;
            this.btnXacNhanTaoKhoa.Click += new System.EventHandler(this.btnXacNhanTaoKhoa_Click);
            // 
            // btnHuyTaoKhoa
            // 
            this.btnHuyTaoKhoa.Location = new System.Drawing.Point(265, 175);
            this.btnHuyTaoKhoa.Name = "btnHuyTaoKhoa";
            this.btnHuyTaoKhoa.Size = new System.Drawing.Size(83, 33);
            this.btnHuyTaoKhoa.TabIndex = 6;
            this.btnHuyTaoKhoa.Text = "Hủy";
            this.btnHuyTaoKhoa.UseVisualStyleBackColor = true;
            this.btnHuyTaoKhoa.Click += new System.EventHandler(this.btnHuyTaoKhoa_Click);
            // 
            // TaoKhoaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.btnHuyTaoKhoa);
            this.Controls.Add(this.btnXacNhanTaoKhoa);
            this.Controls.Add(this.txtTaoTenKhoa);
            this.Controls.Add(this.txtTaoMaKhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaoKhoaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaoKhoaDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTaoMaKhoa;
        public System.Windows.Forms.TextBox txtTaoTenKhoa;
        private System.Windows.Forms.Button btnXacNhanTaoKhoa;
        private System.Windows.Forms.Button btnHuyTaoKhoa;
    }
}