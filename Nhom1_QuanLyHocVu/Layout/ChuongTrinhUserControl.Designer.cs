namespace Nhom1_QuanLyHocVu.Layout
{
    partial class ChuongTrinhUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvChuongTrinhMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemCTMonHoc = new System.Windows.Forms.PictureBox();
            this.cbxTenChuongTrinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bthThemChuongTrinh = new System.Windows.Forms.PictureBox();
            this.cbxKhoaMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvChuongTrinh = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemCTMonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bthThemChuongTrinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sửa";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Học kỳ";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Môn học";
            this.columnHeader8.Width = 300;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên chương trình";
            this.columnHeader7.Width = 350;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã chương trình";
            this.columnHeader6.Width = 150;
            // 
            // lsvChuongTrinhMonHoc
            // 
            this.lsvChuongTrinhMonHoc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lsvChuongTrinhMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvChuongTrinhMonHoc.FullRowSelect = true;
            this.lsvChuongTrinhMonHoc.GridLines = true;
            this.lsvChuongTrinhMonHoc.HideSelection = false;
            this.lsvChuongTrinhMonHoc.Location = new System.Drawing.Point(28, 405);
            this.lsvChuongTrinhMonHoc.MultiSelect = false;
            this.lsvChuongTrinhMonHoc.Name = "lsvChuongTrinhMonHoc";
            this.lsvChuongTrinhMonHoc.Size = new System.Drawing.Size(1149, 265);
            this.lsvChuongTrinhMonHoc.TabIndex = 8;
            this.lsvChuongTrinhMonHoc.UseCompatibleStateImageBehavior = false;
            this.lsvChuongTrinhMonHoc.View = System.Windows.Forms.View.Details;
            this.lsvChuongTrinhMonHoc.SelectedIndexChanged += new System.EventHandler(this.lsvChuongTrinhMonHoc_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Xóa";
            this.columnHeader10.Width = 80;
            // 
            // btnThemCTMonHoc
            // 
            this.btnThemCTMonHoc.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.btnThemCTMonHoc.Location = new System.Drawing.Point(1009, 13);
            this.btnThemCTMonHoc.Name = "btnThemCTMonHoc";
            this.btnThemCTMonHoc.Size = new System.Drawing.Size(78, 36);
            this.btnThemCTMonHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnThemCTMonHoc.TabIndex = 4;
            this.btnThemCTMonHoc.TabStop = false;
            this.btnThemCTMonHoc.Click += new System.EventHandler(this.btnThemCTMonHoc_Click);
            // 
            // cbxTenChuongTrinh
            // 
            this.cbxTenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenChuongTrinh.FormattingEnabled = true;
            this.cbxTenChuongTrinh.Items.AddRange(new object[] {
            "Môn"});
            this.cbxTenChuongTrinh.Location = new System.Drawing.Point(391, 13);
            this.cbxTenChuongTrinh.Name = "cbxTenChuongTrinh";
            this.cbxTenChuongTrinh.Size = new System.Drawing.Size(357, 33);
            this.cbxTenChuongTrinh.TabIndex = 1;
            this.cbxTenChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.cbxTenChuongTrinh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chương trình môn học";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxHocKy);
            this.panel2.Controls.Add(this.btnThemCTMonHoc);
            this.panel2.Controls.Add(this.cbxTenChuongTrinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 74);
            this.panel2.TabIndex = 7;
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Items.AddRange(new object[] {
            "Môn"});
            this.cbxHocKy.Location = new System.Drawing.Point(754, 13);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(150, 33);
            this.cbxHocKy.TabIndex = 5;
            this.cbxHocKy.SelectedIndexChanged += new System.EventHandler(this.cbxHocKy_SelectedIndexChanged);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Sửa";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xóa";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giám đốc chương trình";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khoa";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên chương trình";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã chương trình";
            this.columnHeader1.Width = 150;
            // 
            // bthThemChuongTrinh
            // 
            this.bthThemChuongTrinh.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.bthThemChuongTrinh.Location = new System.Drawing.Point(1008, 17);
            this.bthThemChuongTrinh.Name = "bthThemChuongTrinh";
            this.bthThemChuongTrinh.Size = new System.Drawing.Size(78, 36);
            this.bthThemChuongTrinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bthThemChuongTrinh.TabIndex = 3;
            this.bthThemChuongTrinh.TabStop = false;
            this.bthThemChuongTrinh.Click += new System.EventHandler(this.bthThemChuongTrinh_Click);
            // 
            // cbxKhoaMonHoc
            // 
            this.cbxKhoaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaMonHoc.FormattingEnabled = true;
            this.cbxKhoaMonHoc.Items.AddRange(new object[] {
            "Khoa"});
            this.cbxKhoaMonHoc.Location = new System.Drawing.Point(390, 20);
            this.cbxKhoaMonHoc.Name = "cbxKhoaMonHoc";
            this.cbxKhoaMonHoc.Size = new System.Drawing.Size(377, 33);
            this.cbxKhoaMonHoc.TabIndex = 1;
            this.cbxKhoaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bthThemChuongTrinh);
            this.panel1.Controls.Add(this.cbxKhoaMonHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 82);
            this.panel1.TabIndex = 5;
            // 
            // lsvChuongTrinh
            // 
            this.lsvChuongTrinh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lsvChuongTrinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader12});
            this.lsvChuongTrinh.FullRowSelect = true;
            this.lsvChuongTrinh.GridLines = true;
            this.lsvChuongTrinh.HideSelection = false;
            this.lsvChuongTrinh.Location = new System.Drawing.Point(28, 91);
            this.lsvChuongTrinh.MultiSelect = false;
            this.lsvChuongTrinh.Name = "lsvChuongTrinh";
            this.lsvChuongTrinh.Size = new System.Drawing.Size(1149, 228);
            this.lsvChuongTrinh.TabIndex = 6;
            this.lsvChuongTrinh.UseCompatibleStateImageBehavior = false;
            this.lsvChuongTrinh.View = System.Windows.Forms.View.Details;
            this.lsvChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.lsvChuongTrinh_SelectedIndexChanged);
            this.lsvChuongTrinh.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvChuongTrinh_MouseDoubleClick);
            // 
            // ChuongTrinhUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvChuongTrinhMonHoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvChuongTrinh);
            this.Name = "ChuongTrinhUserControl";
            this.Size = new System.Drawing.Size(1204, 673);
            ((System.ComponentModel.ISupportInitialize)(this.btnThemCTMonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bthThemChuongTrinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lsvChuongTrinhMonHoc;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.PictureBox btnThemCTMonHoc;
        private System.Windows.Forms.ComboBox cbxTenChuongTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox bthThemChuongTrinh;
        private System.Windows.Forms.ComboBox cbxKhoaMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvChuongTrinh;
    }
}
