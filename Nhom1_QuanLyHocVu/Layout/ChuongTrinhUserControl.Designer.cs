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
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvChuongTrinhMonHoc = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxTenChuongTrinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaChuongTrinhMonHoc = new System.Windows.Forms.Button();
            this.btnThemCTMonHoc = new System.Windows.Forms.Button();
            this.cbxHocKy = new System.Windows.Forms.ComboBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxKhoaMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaChuongTrinh = new System.Windows.Forms.Button();
            this.bthThemChuongTrinh = new System.Windows.Forms.Button();
            this.lsvChuongTrinh = new System.Windows.Forms.ListView();
            this.Bzz = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.columnHeader7.Width = 310;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã chương trình";
            this.columnHeader6.Width = 150;
            // 
            // lsvChuongTrinhMonHoc
            // 
            this.lsvChuongTrinhMonHoc.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvChuongTrinhMonHoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9});
            this.lsvChuongTrinhMonHoc.FullRowSelect = true;
            this.lsvChuongTrinhMonHoc.GridLines = true;
            this.lsvChuongTrinhMonHoc.HideSelection = false;
            this.lsvChuongTrinhMonHoc.Location = new System.Drawing.Point(22, 415);
            this.lsvChuongTrinhMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.lsvChuongTrinhMonHoc.MultiSelect = false;
            this.lsvChuongTrinhMonHoc.Name = "lsvChuongTrinhMonHoc";
            this.lsvChuongTrinhMonHoc.OwnerDraw = true;
            this.lsvChuongTrinhMonHoc.Size = new System.Drawing.Size(1022, 246);
            this.lsvChuongTrinhMonHoc.TabIndex = 8;
            this.lsvChuongTrinhMonHoc.UseCompatibleStateImageBehavior = false;
            this.lsvChuongTrinhMonHoc.View = System.Windows.Forms.View.Details;
            this.lsvChuongTrinhMonHoc.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvChuongTrinhMonHoc_DrawColumnHeader);
            this.lsvChuongTrinhMonHoc.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvChuongTrinhMonHoc_DrawItem);
            this.lsvChuongTrinhMonHoc.SelectedIndexChanged += new System.EventHandler(this.lsvChuongTrinhMonHoc_SelectedIndexChanged);
            this.lsvChuongTrinhMonHoc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvChuongTrinhMonHoc_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã môn học";
            this.columnHeader5.Width = 150;
            // 
            // cbxTenChuongTrinh
            // 
            this.cbxTenChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenChuongTrinh.FormattingEnabled = true;
            this.cbxTenChuongTrinh.Items.AddRange(new object[] {
            "Môn"});
            this.cbxTenChuongTrinh.Location = new System.Drawing.Point(265, 16);
            this.cbxTenChuongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTenChuongTrinh.Name = "cbxTenChuongTrinh";
            this.cbxTenChuongTrinh.Size = new System.Drawing.Size(315, 28);
            this.cbxTenChuongTrinh.TabIndex = 1;
            this.cbxTenChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.cbxTenChuongTrinh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chương trình môn học";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoaChuongTrinhMonHoc);
            this.panel2.Controls.Add(this.btnThemCTMonHoc);
            this.panel2.Controls.Add(this.cbxHocKy);
            this.panel2.Controls.Add(this.cbxTenChuongTrinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(22, 350);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 60);
            this.panel2.TabIndex = 7;
            // 
            // btnXoaChuongTrinhMonHoc
            // 
            this.btnXoaChuongTrinhMonHoc.BackColor = System.Drawing.Color.Brown;
            this.btnXoaChuongTrinhMonHoc.FlatAppearance.BorderSize = 0;
            this.btnXoaChuongTrinhMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChuongTrinhMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChuongTrinhMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnXoaChuongTrinhMonHoc.Location = new System.Drawing.Point(915, 16);
            this.btnXoaChuongTrinhMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaChuongTrinhMonHoc.Name = "btnXoaChuongTrinhMonHoc";
            this.btnXoaChuongTrinhMonHoc.Size = new System.Drawing.Size(71, 28);
            this.btnXoaChuongTrinhMonHoc.TabIndex = 12;
            this.btnXoaChuongTrinhMonHoc.Text = "- Xóa";
            this.btnXoaChuongTrinhMonHoc.UseVisualStyleBackColor = false;
            this.btnXoaChuongTrinhMonHoc.Click += new System.EventHandler(this.btnXoaChuongTrinhMonHoc_Click);
            // 
            // btnThemCTMonHoc
            // 
            this.btnThemCTMonHoc.BackColor = System.Drawing.Color.Teal;
            this.btnThemCTMonHoc.FlatAppearance.BorderSize = 0;
            this.btnThemCTMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnThemCTMonHoc.Location = new System.Drawing.Point(820, 16);
            this.btnThemCTMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemCTMonHoc.Name = "btnThemCTMonHoc";
            this.btnThemCTMonHoc.Size = new System.Drawing.Size(91, 28);
            this.btnThemCTMonHoc.TabIndex = 11;
            this.btnThemCTMonHoc.Text = "+ Tạo mới";
            this.btnThemCTMonHoc.UseVisualStyleBackColor = false;
            this.btnThemCTMonHoc.Click += new System.EventHandler(this.btnThemCTMonHoc_Click);
            // 
            // cbxHocKy
            // 
            this.cbxHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHocKy.FormattingEnabled = true;
            this.cbxHocKy.Items.AddRange(new object[] {
            "Môn"});
            this.cbxHocKy.Location = new System.Drawing.Point(584, 16);
            this.cbxHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.cbxHocKy.Name = "cbxHocKy";
            this.cbxHocKy.Size = new System.Drawing.Size(179, 28);
            this.cbxHocKy.TabIndex = 5;
            this.cbxHocKy.SelectedIndexChanged += new System.EventHandler(this.cbxHocKy_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giám đốc chương trình";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Khoa";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên chương trình";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã chương trình";
            this.columnHeader1.Width = 150;
            // 
            // cbxKhoaMonHoc
            // 
            this.cbxKhoaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxKhoaMonHoc.FormattingEnabled = true;
            this.cbxKhoaMonHoc.Items.AddRange(new object[] {
            "Khoa"});
            this.cbxKhoaMonHoc.Location = new System.Drawing.Point(265, 16);
            this.cbxKhoaMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKhoaMonHoc.Name = "cbxKhoaMonHoc";
            this.cbxKhoaMonHoc.Size = new System.Drawing.Size(315, 28);
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
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoaChuongTrinh);
            this.panel1.Controls.Add(this.bthThemChuongTrinh);
            this.panel1.Controls.Add(this.cbxKhoaMonHoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 67);
            this.panel1.TabIndex = 5;
            // 
            // btnXoaChuongTrinh
            // 
            this.btnXoaChuongTrinh.BackColor = System.Drawing.Color.Brown;
            this.btnXoaChuongTrinh.FlatAppearance.BorderSize = 0;
            this.btnXoaChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaChuongTrinh.ForeColor = System.Drawing.Color.White;
            this.btnXoaChuongTrinh.Location = new System.Drawing.Point(915, 18);
            this.btnXoaChuongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaChuongTrinh.Name = "btnXoaChuongTrinh";
            this.btnXoaChuongTrinh.Size = new System.Drawing.Size(71, 28);
            this.btnXoaChuongTrinh.TabIndex = 14;
            this.btnXoaChuongTrinh.Text = "- Xóa";
            this.btnXoaChuongTrinh.UseVisualStyleBackColor = false;
            this.btnXoaChuongTrinh.Click += new System.EventHandler(this.btnXoaChuongTrinh_Click);
            // 
            // bthThemChuongTrinh
            // 
            this.bthThemChuongTrinh.BackColor = System.Drawing.Color.Teal;
            this.bthThemChuongTrinh.FlatAppearance.BorderSize = 0;
            this.bthThemChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthThemChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthThemChuongTrinh.ForeColor = System.Drawing.Color.White;
            this.bthThemChuongTrinh.Location = new System.Drawing.Point(820, 18);
            this.bthThemChuongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.bthThemChuongTrinh.Name = "bthThemChuongTrinh";
            this.bthThemChuongTrinh.Size = new System.Drawing.Size(91, 28);
            this.bthThemChuongTrinh.TabIndex = 13;
            this.bthThemChuongTrinh.Text = "+ Tạo mới";
            this.bthThemChuongTrinh.UseVisualStyleBackColor = false;
            this.bthThemChuongTrinh.Click += new System.EventHandler(this.bthThemChuongTrinh_Click);
            // 
            // lsvChuongTrinh
            // 
            this.lsvChuongTrinh.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvChuongTrinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.Bzz,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvChuongTrinh.FullRowSelect = true;
            this.lsvChuongTrinh.GridLines = true;
            this.lsvChuongTrinh.HideSelection = false;
            this.lsvChuongTrinh.Location = new System.Drawing.Point(22, 85);
            this.lsvChuongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.lsvChuongTrinh.MultiSelect = false;
            this.lsvChuongTrinh.Name = "lsvChuongTrinh";
            this.lsvChuongTrinh.OwnerDraw = true;
            this.lsvChuongTrinh.Size = new System.Drawing.Size(1022, 234);
            this.lsvChuongTrinh.TabIndex = 6;
            this.lsvChuongTrinh.UseCompatibleStateImageBehavior = false;
            this.lsvChuongTrinh.View = System.Windows.Forms.View.Details;
            this.lsvChuongTrinh.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvChuongTrinhMonHoc_DrawColumnHeader);
            this.lsvChuongTrinh.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvChuongTrinhMonHoc_DrawItem);
            this.lsvChuongTrinh.SelectedIndexChanged += new System.EventHandler(this.lsvChuongTrinh_SelectedIndexChanged);
            this.lsvChuongTrinh.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvChuongTrinh_MouseDoubleClick);
            // 
            // Bzz
            // 
            this.Bzz.Text = "Bậc học";
            this.Bzz.Width = 100;
            // 
            // ChuongTrinhUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lsvChuongTrinhMonHoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsvChuongTrinh);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChuongTrinhUserControl";
            this.Size = new System.Drawing.Size(1072, 681);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lsvChuongTrinhMonHoc;
        private System.Windows.Forms.ComboBox cbxTenChuongTrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxHocKy;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ComboBox cbxKhoaMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvChuongTrinh;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader Bzz;
        private System.Windows.Forms.Button btnXoaChuongTrinhMonHoc;
        private System.Windows.Forms.Button btnThemCTMonHoc;
        private System.Windows.Forms.Button btnXoaChuongTrinh;
        private System.Windows.Forms.Button bthThemChuongTrinh;
    }
}
