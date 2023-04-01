namespace Nhom1_QuanLyHocVu.Layout
{
    partial class KhoaHocUserControl
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
            this.lsvMonHocKhoaHoc = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemMonHocKhoaHoc = new System.Windows.Forms.PictureBox();
            this.cbxKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxGiaoVien = new System.Windows.Forms.ComboBox();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvKhoaHoc = new System.Windows.Forms.ListView();
            this.btnThemKhoaHoc = new System.Windows.Forms.PictureBox();
            this.cbxKhoaKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemMonHocKhoaHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemKhoaHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Thứ";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Giáo viên";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Khóa học";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tên môn học";
            this.columnHeader7.Width = 300;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã môn học";
            this.columnHeader6.Width = 150;
            // 
            // lsvMonHocKhoaHoc
            // 
            this.lsvMonHocKhoaHoc.BackColor = System.Drawing.Color.Lavender;
            this.lsvMonHocKhoaHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvMonHocKhoaHoc.FullRowSelect = true;
            this.lsvMonHocKhoaHoc.GridLines = true;
            this.lsvMonHocKhoaHoc.HideSelection = false;
            this.lsvMonHocKhoaHoc.Location = new System.Drawing.Point(28, 405);
            this.lsvMonHocKhoaHoc.MultiSelect = false;
            this.lsvMonHocKhoaHoc.Name = "lsvMonHocKhoaHoc";
            this.lsvMonHocKhoaHoc.Size = new System.Drawing.Size(1149, 265);
            this.lsvMonHocKhoaHoc.TabIndex = 8;
            this.lsvMonHocKhoaHoc.UseCompatibleStateImageBehavior = false;
            this.lsvMonHocKhoaHoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Phòng";
            this.columnHeader10.Width = 80;
            // 
            // btnThemMonHocKhoaHoc
            // 
            this.btnThemMonHocKhoaHoc.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.btnThemMonHocKhoaHoc.Location = new System.Drawing.Point(1026, 14);
            this.btnThemMonHocKhoaHoc.Name = "btnThemMonHocKhoaHoc";
            this.btnThemMonHocKhoaHoc.Size = new System.Drawing.Size(78, 36);
            this.btnThemMonHocKhoaHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnThemMonHocKhoaHoc.TabIndex = 4;
            this.btnThemMonHocKhoaHoc.TabStop = false;
            this.btnThemMonHocKhoaHoc.Click += new System.EventHandler(this.btnThemMonHocKhoaHoc_Click);
            // 
            // cbxKhoaHoc
            // 
            this.cbxKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaHoc.FormattingEnabled = true;
            this.cbxKhoaHoc.Items.AddRange(new object[] {
            "Môn"});
            this.cbxKhoaHoc.Location = new System.Drawing.Point(328, 17);
            this.cbxKhoaHoc.Name = "cbxKhoaHoc";
            this.cbxKhoaHoc.Size = new System.Drawing.Size(202, 33);
            this.cbxKhoaHoc.TabIndex = 1;
            this.cbxKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Môn học khóa học";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbxGiaoVien);
            this.panel2.Controls.Add(this.cbxMonHoc);
            this.panel2.Controls.Add(this.btnThemMonHocKhoaHoc);
            this.panel2.Controls.Add(this.cbxKhoaHoc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(28, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 74);
            this.panel2.TabIndex = 7;
            // 
            // cbxGiaoVien
            // 
            this.cbxGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGiaoVien.FormattingEnabled = true;
            this.cbxGiaoVien.Items.AddRange(new object[] {
            "Môn"});
            this.cbxGiaoVien.Location = new System.Drawing.Point(779, 17);
            this.cbxGiaoVien.Name = "cbxGiaoVien";
            this.cbxGiaoVien.Size = new System.Drawing.Size(202, 33);
            this.cbxGiaoVien.TabIndex = 6;
            this.cbxGiaoVien.SelectedIndexChanged += new System.EventHandler(this.cbxGiaoVien_SelectedIndexChanged);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Items.AddRange(new object[] {
            "Môn"});
            this.cbxMonHoc.Location = new System.Drawing.Point(549, 17);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(202, 33);
            this.cbxMonHoc.TabIndex = 5;
            this.cbxMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxMonHoc_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Năm kết thúc";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm bắt đầu";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chương trình";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khóa học";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khóa học";
            this.columnHeader1.Width = 150;
            // 
            // lsvKhoaHoc
            // 
            this.lsvKhoaHoc.BackColor = System.Drawing.Color.Lavender;
            this.lsvKhoaHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvKhoaHoc.FullRowSelect = true;
            this.lsvKhoaHoc.GridLines = true;
            this.lsvKhoaHoc.HideSelection = false;
            this.lsvKhoaHoc.Location = new System.Drawing.Point(28, 91);
            this.lsvKhoaHoc.MultiSelect = false;
            this.lsvKhoaHoc.Name = "lsvKhoaHoc";
            this.lsvKhoaHoc.Size = new System.Drawing.Size(1149, 228);
            this.lsvKhoaHoc.TabIndex = 6;
            this.lsvKhoaHoc.UseCompatibleStateImageBehavior = false;
            this.lsvKhoaHoc.View = System.Windows.Forms.View.Details;
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(869, 17);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(78, 36);
            this.btnThemKhoaHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnThemKhoaHoc.TabIndex = 3;
            this.btnThemKhoaHoc.TabStop = false;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // cbxKhoaKhoaHoc
            // 
            this.cbxKhoaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaKhoaHoc.FormattingEnabled = true;
            this.cbxKhoaKhoaHoc.Items.AddRange(new object[] {
            "Khoa"});
            this.cbxKhoaKhoaHoc.Location = new System.Drawing.Point(327, 20);
            this.cbxKhoaKhoaHoc.Name = "cbxKhoaKhoaHoc";
            this.cbxKhoaKhoaHoc.Size = new System.Drawing.Size(333, 33);
            this.cbxKhoaKhoaHoc.TabIndex = 1;
            this.cbxKhoaKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaKhoaHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khóa học";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThemKhoaHoc);
            this.panel1.Controls.Add(this.cbxKhoaKhoaHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 82);
            this.panel1.TabIndex = 5;
            // 
            // KhoaHocUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvMonHocKhoaHoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsvKhoaHoc);
            this.Controls.Add(this.panel1);
            this.Name = "KhoaHocUserControl";
            this.Size = new System.Drawing.Size(1204, 673);
            ((System.ComponentModel.ISupportInitialize)(this.btnThemMonHocKhoaHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemKhoaHoc)).EndInit();
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
        private System.Windows.Forms.ListView lsvMonHocKhoaHoc;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.PictureBox btnThemMonHocKhoaHoc;
        private System.Windows.Forms.ComboBox cbxKhoaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvKhoaHoc;
        private System.Windows.Forms.PictureBox btnThemKhoaHoc;
        private System.Windows.Forms.ComboBox cbxKhoaKhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxGiaoVien;
        private System.Windows.Forms.ComboBox cbxMonHoc;
    }
}
