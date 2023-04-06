namespace Nhom1_QuanLyHocVu.Layout
{
    partial class KhoaUserControl
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
            this.lsvGV = new System.Windows.Forms.ListView();
            this.colTenGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaGv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvKhoa = new System.Windows.Forms.ListView();
            this.colKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.btnTaoKhoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnTaoGV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvGV
            // 
            this.lsvGV.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvGV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenGv,
            this.colMaGv});
            this.lsvGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvGV.FullRowSelect = true;
            this.lsvGV.GridLines = true;
            this.lsvGV.HideSelection = false;
            this.lsvGV.Location = new System.Drawing.Point(721, 121);
            this.lsvGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvGV.Name = "lsvGV";
            this.lsvGV.OwnerDraw = true;
            this.lsvGV.Size = new System.Drawing.Size(668, 683);
            this.lsvGV.TabIndex = 10;
            this.lsvGV.UseCompatibleStateImageBehavior = false;
            this.lsvGV.View = System.Windows.Forms.View.Details;
            this.lsvGV.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvGV_DrawColumnHeader);
            this.lsvGV.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvGV_DrawItem);
            this.lsvGV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvGV_MouseDoubleClick);
            // 
            // colTenGv
            // 
            this.colTenGv.Text = "Giáo viên";
            this.colTenGv.Width = 350;
            // 
            // colMaGv
            // 
            this.colMaGv.Text = "Mã GV";
            this.colMaGv.Width = 150;
            // 
            // lsvKhoa
            // 
            this.lsvKhoa.BackColor = System.Drawing.Color.Gainsboro;
            this.lsvKhoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colKhoa,
            this.colMaKhoa});
            this.lsvKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvKhoa.FullRowSelect = true;
            this.lsvKhoa.GridLines = true;
            this.lsvKhoa.HideSelection = false;
            this.lsvKhoa.Location = new System.Drawing.Point(35, 121);
            this.lsvKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvKhoa.Name = "lsvKhoa";
            this.lsvKhoa.OwnerDraw = true;
            this.lsvKhoa.Size = new System.Drawing.Size(641, 683);
            this.lsvKhoa.TabIndex = 9;
            this.lsvKhoa.UseCompatibleStateImageBehavior = false;
            this.lsvKhoa.View = System.Windows.Forms.View.Details;
            this.lsvKhoa.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.lsvKhoa_DrawColumnHeader);
            this.lsvKhoa.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.lsvKhoa_DrawItem);
            this.lsvKhoa.SelectedIndexChanged += new System.EventHandler(this.lsvKhoa_SelectedIndexChanged);
            this.lsvKhoa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvKhoa_MouseDoubleClick);
            // 
            // colKhoa
            // 
            this.colKhoa.Text = "Khoa";
            this.colKhoa.Width = 350;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.Text = "Mã Khoa";
            this.colMaKhoa.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoaKhoa);
            this.panel1.Controls.Add(this.btnTaoKhoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(35, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 68);
            this.panel1.TabIndex = 7;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.BackColor = System.Drawing.Color.Brown;
            this.btnXoaKhoa.FlatAppearance.BorderSize = 0;
            this.btnXoaKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoa.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoa.Location = new System.Drawing.Point(504, 18);
            this.btnXoaKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(83, 30);
            this.btnXoaKhoa.TabIndex = 6;
            this.btnXoaKhoa.Text = "- Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = false;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
            // 
            // btnTaoKhoa
            // 
            this.btnTaoKhoa.BackColor = System.Drawing.Color.Teal;
            this.btnTaoKhoa.FlatAppearance.BorderSize = 0;
            this.btnTaoKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoKhoa.ForeColor = System.Drawing.Color.White;
            this.btnTaoKhoa.Location = new System.Drawing.Point(388, 18);
            this.btnTaoKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoKhoa.Name = "btnTaoKhoa";
            this.btnTaoKhoa.Size = new System.Drawing.Size(109, 30);
            this.btnTaoKhoa.TabIndex = 5;
            this.btnTaoKhoa.Text = "+ Tạo mới";
            this.btnTaoKhoa.UseVisualStyleBackColor = false;
            this.btnTaoKhoa.Click += new System.EventHandler(this.btnTaoKhoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giáo viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoaGV);
            this.panel2.Controls.Add(this.btnTaoGV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(721, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 68);
            this.panel2.TabIndex = 8;
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.BackColor = System.Drawing.Color.Brown;
            this.btnXoaGV.FlatAppearance.BorderSize = 0;
            this.btnXoaGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGV.ForeColor = System.Drawing.Color.White;
            this.btnXoaGV.Location = new System.Drawing.Point(528, 18);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(83, 30);
            this.btnXoaGV.TabIndex = 7;
            this.btnXoaGV.Text = "- Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = false;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnTaoGV
            // 
            this.btnTaoGV.BackColor = System.Drawing.Color.Teal;
            this.btnTaoGV.FlatAppearance.BorderSize = 0;
            this.btnTaoGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoGV.ForeColor = System.Drawing.Color.White;
            this.btnTaoGV.Location = new System.Drawing.Point(413, 18);
            this.btnTaoGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoGV.Name = "btnTaoGV";
            this.btnTaoGV.Size = new System.Drawing.Size(109, 30);
            this.btnTaoGV.TabIndex = 6;
            this.btnTaoGV.Text = "+ Tạo mới";
            this.btnTaoGV.UseVisualStyleBackColor = false;
            this.btnTaoGV.Click += new System.EventHandler(this.btnTaoGV_Click);
            // 
            // KhoaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lsvGV);
            this.Controls.Add(this.lsvKhoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KhoaUserControl";
            this.Size = new System.Drawing.Size(1429, 838);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvGV;
        private System.Windows.Forms.ColumnHeader colTenGv;
        private System.Windows.Forms.ColumnHeader colMaGv;
        private System.Windows.Forms.ListView lsvKhoa;
        private System.Windows.Forms.ColumnHeader colKhoa;
        private System.Windows.Forms.ColumnHeader colMaKhoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaoKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTaoGV;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.Button btnXoaGV;
    }
}
