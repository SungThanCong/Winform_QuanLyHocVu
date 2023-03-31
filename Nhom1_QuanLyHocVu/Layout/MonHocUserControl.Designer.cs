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
            this.cbxKhoaMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsvMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxMonDamNhanMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvDamNhanMon = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDamNhanMon = new System.Windows.Forms.PictureBox();
            this.bthThemMonHoc = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamNhanMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bthThemMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bthThemMonHoc);
            this.panel1.Controls.Add(this.cbxKhoaMonHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 82);
            this.panel1.TabIndex = 0;
            // 
            // cbxKhoaMonHoc
            // 
            this.cbxKhoaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaMonHoc.FormattingEnabled = true;
            this.cbxKhoaMonHoc.Items.AddRange(new object[] {
            "Khoa"});
            this.cbxKhoaMonHoc.Location = new System.Drawing.Point(327, 13);
            this.cbxKhoaMonHoc.Name = "cbxKhoaMonHoc";
            this.cbxKhoaMonHoc.Size = new System.Drawing.Size(333, 33);
            this.cbxKhoaMonHoc.TabIndex = 1;
            this.cbxKhoaMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxKhoaMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // lsvMonHoc
            // 
            this.lsvMonHoc.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lsvMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader12});
            this.lsvMonHoc.FullRowSelect = true;
            this.lsvMonHoc.GridLines = true;
            this.lsvMonHoc.HideSelection = false;
            this.lsvMonHoc.Location = new System.Drawing.Point(24, 91);
            this.lsvMonHoc.MultiSelect = false;
            this.lsvMonHoc.Name = "lsvMonHoc";
            this.lsvMonHoc.Size = new System.Drawing.Size(1149, 228);
            this.lsvMonHoc.TabIndex = 2;
            this.lsvMonHoc.UseCompatibleStateImageBehavior = false;
            this.lsvMonHoc.View = System.Windows.Forms.View.Details;
            this.lsvMonHoc.SelectedIndexChanged += new System.EventHandler(this.lsvMonHoc_SelectedIndexChanged);
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
            // columnHeader5
            // 
            this.columnHeader5.Text = "Xóa";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Sửa";
            this.columnHeader12.Width = 80;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDamNhanMon);
            this.panel2.Controls.Add(this.cbxMonDamNhanMon);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(24, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 74);
            this.panel2.TabIndex = 3;
            // 
            // cbxMonDamNhanMon
            // 
            this.cbxMonDamNhanMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonDamNhanMon.FormattingEnabled = true;
            this.cbxMonDamNhanMon.Items.AddRange(new object[] {
            "Môn"});
            this.cbxMonDamNhanMon.Location = new System.Drawing.Point(328, 17);
            this.cbxMonDamNhanMon.Name = "cbxMonDamNhanMon";
            this.cbxMonDamNhanMon.Size = new System.Drawing.Size(332, 33);
            this.cbxMonDamNhanMon.TabIndex = 1;
            this.cbxMonDamNhanMon.SelectedIndexChanged += new System.EventHandler(this.cbxMonDamNhanMon_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đảm nhận môn";
            // 
            // lsvDamNhanMon
            // 
            this.lsvDamNhanMon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lsvDamNhanMon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsvDamNhanMon.FullRowSelect = true;
            this.lsvDamNhanMon.GridLines = true;
            this.lsvDamNhanMon.HideSelection = false;
            this.lsvDamNhanMon.Location = new System.Drawing.Point(24, 405);
            this.lsvDamNhanMon.MultiSelect = false;
            this.lsvDamNhanMon.Name = "lsvDamNhanMon";
            this.lsvDamNhanMon.Size = new System.Drawing.Size(1149, 265);
            this.lsvDamNhanMon.TabIndex = 4;
            this.lsvDamNhanMon.UseCompatibleStateImageBehavior = false;
            this.lsvDamNhanMon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Môn học";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Chương trình";
            this.columnHeader7.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giáo viên";
            this.columnHeader8.Width = 250;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Đảm nhận chính";
            this.columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Xóa";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sửa";
            this.columnHeader11.Width = 80;
            // 
            // btnDamNhanMon
            // 
            this.btnDamNhanMon.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.btnDamNhanMon.Location = new System.Drawing.Point(874, 13);
            this.btnDamNhanMon.Name = "btnDamNhanMon";
            this.btnDamNhanMon.Size = new System.Drawing.Size(78, 36);
            this.btnDamNhanMon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnDamNhanMon.TabIndex = 4;
            this.btnDamNhanMon.TabStop = false;
            this.btnDamNhanMon.Click += new System.EventHandler(this.btnDamNhanMon_Click);
            // 
            // bthThemMonHoc
            // 
            this.bthThemMonHoc.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.button_them;
            this.bthThemMonHoc.Location = new System.Drawing.Point(874, 13);
            this.bthThemMonHoc.Name = "bthThemMonHoc";
            this.bthThemMonHoc.Size = new System.Drawing.Size(78, 36);
            this.bthThemMonHoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bthThemMonHoc.TabIndex = 3;
            this.bthThemMonHoc.TabStop = false;
            // 
            // MonHocUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvDamNhanMon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsvMonHoc);
            this.Controls.Add(this.panel1);
            this.Name = "MonHocUserControl";
            this.Size = new System.Drawing.Size(1204, 673);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDamNhanMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bthThemMonHoc)).EndInit();
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
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox bthThemMonHoc;
        private System.Windows.Forms.PictureBox btnDamNhanMon;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}
