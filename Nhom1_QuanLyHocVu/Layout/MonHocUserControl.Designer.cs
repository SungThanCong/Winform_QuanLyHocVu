namespace Nhom1_QuanLyHocVu.Layout
{
    partial class MonHocUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaMonHoc = new System.Windows.Forms.PictureBox();
            this.bthThemMonHoc = new System.Windows.Forms.PictureBox();
            this.cbxKhoaMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaDamNhanMon = new System.Windows.Forms.PictureBox();
            this.btnDamNhanMon = new System.Windows.Forms.PictureBox();
            this.cbxMonDamNhanMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvDamNhanMon = new System.Windows.Forms.ListView();
            this.colMonHocDNM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChuongTrinhDNM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaoVienDNM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bthThemMonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaDamNhanMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamNhanMon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoaMonHoc);
            this.panel1.Controls.Add(this.bthThemMonHoc);
            this.panel1.Controls.Add(this.cbxKhoaMonHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 67);
            this.panel1.TabIndex = 0;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.note_pencil;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(802, 16);
            this.btnXoaMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(26, 30);
            this.btnXoaMonHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnXoaMonHoc.TabIndex = 5;
            this.btnXoaMonHoc.TabStop = false;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // bthThemMonHoc
            // 
            this.bthThemMonHoc.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.bthThemMonHoc.Location = new System.Drawing.Point(739, 16);
            this.bthThemMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bthThemMonHoc.Name = "bthThemMonHoc";
            this.bthThemMonHoc.Size = new System.Drawing.Size(58, 30);
            this.bthThemMonHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bthThemMonHoc.TabIndex = 3;
            this.bthThemMonHoc.TabStop = false;
            this.bthThemMonHoc.Click += new System.EventHandler(this.bthThemMonHoc_Click);
            // 
            // cbxKhoaMonHoc
            // 
            this.cbxKhoaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaMonHoc.FormattingEnabled = true;
            this.cbxKhoaMonHoc.Items.AddRange(new object[] {
            "Khoa"});
            this.cbxKhoaMonHoc.Location = new System.Drawing.Point(245, 16);
            this.cbxKhoaMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxKhoaMonHoc.Name = "cbxKhoaMonHoc";
            this.cbxKhoaMonHoc.Size = new System.Drawing.Size(250, 28);
            this.cbxKhoaMonHoc.TabIndex = 1;
            this.cbxKhoaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // lsvMonHoc
            // 
            this.lsvMonHoc.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvMonHoc.FullRowSelect = true;
            this.lsvMonHoc.GridLines = true;
            this.lsvMonHoc.HideSelection = false;
            this.lsvMonHoc.Location = new System.Drawing.Point(18, 74);
            this.lsvMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvMonHoc.MultiSelect = false;
            this.lsvMonHoc.Name = "lsvMonHoc";
            this.lsvMonHoc.OwnerDraw = true;
            this.lsvMonHoc.Size = new System.Drawing.Size(863, 186);
            this.lsvMonHoc.TabIndex = 2;
            this.lsvMonHoc.UseCompatibleStateImageBehavior = false;
            this.lsvMonHoc.View = System.Windows.Forms.View.Details;
            this.lsvMonHoc.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvDamNhanMon_DrawColumnHeader);
            this.lsvMonHoc.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvDamNhanMon_DrawItem);
            this.lsvMonHoc.SelectedIndexChanged += new System.EventHandler(this.lsvMonHoc_SelectedIndexChanged);
            this.lsvMonHoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvMonHoc_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã môn học";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên môn học";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khoa";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số tín chỉ";
            this.columnHeader4.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoaDamNhanMon);
            this.panel2.Controls.Add(this.btnDamNhanMon);
            this.panel2.Controls.Add(this.cbxMonDamNhanMon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 264);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 60);
            this.panel2.TabIndex = 3;
            // 
            // btnXoaDamNhanMon
            // 
            this.btnXoaDamNhanMon.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.note_pencil;
            this.btnXoaDamNhanMon.Location = new System.Drawing.Point(802, 15);
            this.btnXoaDamNhanMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaDamNhanMon.Name = "btnXoaDamNhanMon";
            this.btnXoaDamNhanMon.Size = new System.Drawing.Size(26, 31);
            this.btnXoaDamNhanMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnXoaDamNhanMon.TabIndex = 6;
            this.btnXoaDamNhanMon.TabStop = false;
            this.btnXoaDamNhanMon.Click += new System.EventHandler(this.btnXoaDamNhanMon_Click);
            // 
            // btnDamNhanMon
            // 
            this.btnDamNhanMon.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.btnDamNhanMon.Location = new System.Drawing.Point(740, 15);
            this.btnDamNhanMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDamNhanMon.Name = "btnDamNhanMon";
            this.btnDamNhanMon.Size = new System.Drawing.Size(58, 31);
            this.btnDamNhanMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDamNhanMon.TabIndex = 4;
            this.btnDamNhanMon.TabStop = false;
            this.btnDamNhanMon.Click += new System.EventHandler(this.btnDamNhanMon_Click);
            // 
            // cbxMonDamNhanMon
            // 
            this.cbxMonDamNhanMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonDamNhanMon.FormattingEnabled = true;
            this.cbxMonDamNhanMon.Items.AddRange(new object[] {
            "Môn"});
            this.cbxMonDamNhanMon.Location = new System.Drawing.Point(246, 14);
            this.cbxMonDamNhanMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMonDamNhanMon.Name = "cbxMonDamNhanMon";
            this.cbxMonDamNhanMon.Size = new System.Drawing.Size(250, 28);
            this.cbxMonDamNhanMon.TabIndex = 1;
            this.cbxMonDamNhanMon.SelectedIndexChanged += new System.EventHandler(this.cbxMonDamNhanMon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đảm nhiệm môn";
            // 
            // lsvDamNhanMon
            // 
            this.lsvDamNhanMon.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvDamNhanMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMonHocDNM,
            this.colChuongTrinhDNM,
            this.colGiaoVienDNM,
            this.columnHeader9,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvDamNhanMon.FullRowSelect = true;
            this.lsvDamNhanMon.GridLines = true;
            this.lsvDamNhanMon.HideSelection = false;
            this.lsvDamNhanMon.Location = new System.Drawing.Point(18, 329);
            this.lsvDamNhanMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsvDamNhanMon.MultiSelect = false;
            this.lsvDamNhanMon.Name = "lsvDamNhanMon";
            this.lsvDamNhanMon.OwnerDraw = true;
            this.lsvDamNhanMon.Size = new System.Drawing.Size(863, 216);
            this.lsvDamNhanMon.TabIndex = 4;
            this.lsvDamNhanMon.UseCompatibleStateImageBehavior = false;
            this.lsvDamNhanMon.View = System.Windows.Forms.View.Details;
            this.lsvDamNhanMon.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvDamNhanMon_DrawColumnHeader);
            this.lsvDamNhanMon.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvDamNhanMon_DrawItem);
            this.lsvDamNhanMon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvDamNhanMon_MouseDoubleClick);
            // 
            // colMonHocDNM
            // 
            this.colMonHocDNM.Text = "Môn học";
            this.colMonHocDNM.Width = 200;
            // 
            // colChuongTrinhDNM
            // 
            this.colChuongTrinhDNM.Text = "Chương trình";
            this.colChuongTrinhDNM.Width = 300;
            // 
            // colGiaoVienDNM
            // 
            this.colGiaoVienDNM.Text = "Giáo viên";
            this.colGiaoVienDNM.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Đảm nhiệm chính";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 0;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 0;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 0;
            // 
            // MonHocUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvDamNhanMon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsvMonHoc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MonHocUserControl";
            this.Size = new System.Drawing.Size(903, 547);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bthThemMonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoaDamNhanMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamNhanMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxKhoaMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvMonHoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxMonDamNhanMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvDamNhanMon;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox bthThemMonHoc;
        private System.Windows.Forms.PictureBox btnDamNhanMon;
        private System.Windows.Forms.ColumnHeader colMonHocDNM;
        private System.Windows.Forms.ColumnHeader colChuongTrinhDNM;
        private System.Windows.Forms.ColumnHeader colGiaoVienDNM;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.PictureBox btnXoaMonHoc;
        private System.Windows.Forms.PictureBox btnXoaDamNhanMon;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}
