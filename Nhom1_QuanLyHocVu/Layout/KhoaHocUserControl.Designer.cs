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
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaMonHocKhoaHoc = new System.Windows.Forms.Button();
            this.btnThemMonHocKhoaHoc = new System.Windows.Forms.Button();
            this.cbxMonHoc = new System.Windows.Forms.ComboBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvKhoaHoc = new System.Windows.Forms.ListView();
            this.cbxKhoaKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.btnThemKhoaHoc = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
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
            this.columnHeader8.Width = 300;
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
            this.lsvMonHocKhoaHoc.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvMonHocKhoaHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lsvMonHocKhoaHoc.FullRowSelect = true;
            this.lsvMonHocKhoaHoc.GridLines = true;
            this.lsvMonHocKhoaHoc.HideSelection = false;
            this.lsvMonHocKhoaHoc.Location = new System.Drawing.Point(25, 505);
            this.lsvMonHocKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvMonHocKhoaHoc.MultiSelect = false;
            this.lsvMonHocKhoaHoc.Name = "lsvMonHocKhoaHoc";
            this.lsvMonHocKhoaHoc.OwnerDraw = true;
            this.lsvMonHocKhoaHoc.Size = new System.Drawing.Size(1369, 309);
            this.lsvMonHocKhoaHoc.TabIndex = 8;
            this.lsvMonHocKhoaHoc.UseCompatibleStateImageBehavior = false;
            this.lsvMonHocKhoaHoc.View = System.Windows.Forms.View.Details;
            this.lsvMonHocKhoaHoc.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvKhoaHoc_DrawColumnHeader);
            this.lsvMonHocKhoaHoc.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvKhoaHoc_DrawItem);
            this.lsvMonHocKhoaHoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvMonHocKhoaHoc_MouseDoubleClick);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Phòng";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Width = 0;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Width = 0;
            // 
            // cbxKhoaHoc
            // 
            this.cbxKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaHoc.FormattingEnabled = true;
            this.cbxKhoaHoc.Items.AddRange(new object[] {
            "Môn"});
            this.cbxKhoaHoc.Location = new System.Drawing.Point(299, 17);
            this.cbxKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxKhoaHoc.Name = "cbxKhoaHoc";
            this.cbxKhoaHoc.Size = new System.Drawing.Size(412, 33);
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
            this.panel2.Controls.Add(this.btnXoaMonHocKhoaHoc);
            this.panel2.Controls.Add(this.btnThemMonHocKhoaHoc);
            this.panel2.Controls.Add(this.cbxMonHoc);
            this.panel2.Controls.Add(this.cbxKhoaHoc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 425);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 73);
            this.panel2.TabIndex = 7;
            // 
            // btnXoaMonHocKhoaHoc
            // 
            this.btnXoaMonHocKhoaHoc.BackColor = System.Drawing.Color.Brown;
            this.btnXoaMonHocKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnXoaMonHocKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMonHocKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMonHocKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnXoaMonHocKhoaHoc.Location = new System.Drawing.Point(1228, 17);
            this.btnXoaMonHocKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaMonHocKhoaHoc.Name = "btnXoaMonHocKhoaHoc";
            this.btnXoaMonHocKhoaHoc.Size = new System.Drawing.Size(95, 34);
            this.btnXoaMonHocKhoaHoc.TabIndex = 12;
            this.btnXoaMonHocKhoaHoc.Text = "- Xóa";
            this.btnXoaMonHocKhoaHoc.UseVisualStyleBackColor = false;
            this.btnXoaMonHocKhoaHoc.Click += new System.EventHandler(this.btnXoaMonHocKhoaHoc_Click);
            // 
            // btnThemMonHocKhoaHoc
            // 
            this.btnThemMonHocKhoaHoc.BackColor = System.Drawing.Color.Teal;
            this.btnThemMonHocKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnThemMonHocKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMonHocKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMonHocKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnThemMonHocKhoaHoc.Location = new System.Drawing.Point(1101, 17);
            this.btnThemMonHocKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemMonHocKhoaHoc.Name = "btnThemMonHocKhoaHoc";
            this.btnThemMonHocKhoaHoc.Size = new System.Drawing.Size(121, 34);
            this.btnThemMonHocKhoaHoc.TabIndex = 11;
            this.btnThemMonHocKhoaHoc.Text = "+ Tạo mới";
            this.btnThemMonHocKhoaHoc.UseVisualStyleBackColor = false;
            this.btnThemMonHocKhoaHoc.Click += new System.EventHandler(this.btnThemMonHocKhoaHoc_Click);
            // 
            // cbxMonHoc
            // 
            this.cbxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonHoc.FormattingEnabled = true;
            this.cbxMonHoc.Items.AddRange(new object[] {
            "Môn"});
            this.cbxMonHoc.Location = new System.Drawing.Point(717, 16);
            this.cbxMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxMonHoc.Name = "cbxMonHoc";
            this.cbxMonHoc.Size = new System.Drawing.Size(349, 33);
            this.cbxMonHoc.TabIndex = 5;
            this.cbxMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbxMonHoc_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Năm kết thúc";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Năm bắt đầu";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chương trình";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên khóa học";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khóa học";
            this.columnHeader1.Width = 150;
            // 
            // lsvKhoaHoc
            // 
            this.lsvKhoaHoc.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvKhoaHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvKhoaHoc.FullRowSelect = true;
            this.lsvKhoaHoc.GridLines = true;
            this.lsvKhoaHoc.HideSelection = false;
            this.lsvKhoaHoc.Location = new System.Drawing.Point(25, 102);
            this.lsvKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvKhoaHoc.MultiSelect = false;
            this.lsvKhoaHoc.Name = "lsvKhoaHoc";
            this.lsvKhoaHoc.OwnerDraw = true;
            this.lsvKhoaHoc.Size = new System.Drawing.Size(1369, 288);
            this.lsvKhoaHoc.TabIndex = 6;
            this.lsvKhoaHoc.UseCompatibleStateImageBehavior = false;
            this.lsvKhoaHoc.View = System.Windows.Forms.View.Details;
            this.lsvKhoaHoc.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvKhoaHoc_DrawColumnHeader);
            this.lsvKhoaHoc.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvKhoaHoc_DrawItem);
            this.lsvKhoaHoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvKhoaHoc_MouseDoubleClick);
            // 
            // cbxKhoaKhoaHoc
            // 
            this.cbxKhoaKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaKhoaHoc.FormattingEnabled = true;
            this.cbxKhoaKhoaHoc.Items.AddRange(new object[] {
            "Khoa"});
            this.cbxKhoaKhoaHoc.Location = new System.Drawing.Point(297, 21);
            this.cbxKhoaKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxKhoaKhoaHoc.Name = "cbxKhoaKhoaHoc";
            this.cbxKhoaKhoaHoc.Size = new System.Drawing.Size(453, 33);
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
            this.panel1.Controls.Add(this.btnXoaMonHoc);
            this.panel1.Controls.Add(this.btnThemKhoaHoc);
            this.panel1.Controls.Add(this.cbxKhoaKhoaHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 82);
            this.panel1.TabIndex = 5;
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.BackColor = System.Drawing.Color.Brown;
            this.btnXoaMonHoc.FlatAppearance.BorderSize = 0;
            this.btnXoaMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(1227, 22);
            this.btnXoaMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(95, 34);
            this.btnXoaMonHoc.TabIndex = 10;
            this.btnXoaMonHoc.Text = "- Xóa";
            this.btnXoaMonHoc.UseVisualStyleBackColor = false;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaKhoaHoc_Click);
            // 
            // btnThemKhoaHoc
            // 
            this.btnThemKhoaHoc.BackColor = System.Drawing.Color.Teal;
            this.btnThemKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnThemKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnThemKhoaHoc.Location = new System.Drawing.Point(1100, 22);
            this.btnThemKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKhoaHoc.Name = "btnThemKhoaHoc";
            this.btnThemKhoaHoc.Size = new System.Drawing.Size(121, 34);
            this.btnThemKhoaHoc.TabIndex = 9;
            this.btnThemKhoaHoc.Text = "+ Tạo mới";
            this.btnThemKhoaHoc.UseVisualStyleBackColor = false;
            this.btnThemKhoaHoc.Click += new System.EventHandler(this.btnThemKhoaHoc_Click);
            // 
            // KhoaHocUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvMonHocKhoaHoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lsvKhoaHoc);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoaHocUserControl";
            this.Size = new System.Drawing.Size(1429, 838);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbxKhoaHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvKhoaHoc;
        private System.Windows.Forms.ComboBox cbxKhoaKhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxMonHoc;
        private System.Windows.Forms.Button btnXoaMonHoc;
        private System.Windows.Forms.Button btnThemKhoaHoc;
        private System.Windows.Forms.Button btnXoaMonHocKhoaHoc;
        private System.Windows.Forms.Button btnThemMonHocKhoaHoc;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
    }
}
