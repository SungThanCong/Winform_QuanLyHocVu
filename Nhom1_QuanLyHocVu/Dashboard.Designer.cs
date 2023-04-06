using System.Data.Entity.Core.Metadata.Edm;
using System.Windows.Forms;

namespace Nhom1_QuanLyHocVu
{
    partial class Dashboard
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
            this.menu1 = new Layout.Menu(this);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.profileBar1 = new Nhom1_QuanLyHocVu.Layout.ProfileBar();
            this.navToKhoa = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navToChuongTrinh = new System.Windows.Forms.Panel();
            this.zz = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.navToMonHoc = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navToKhoaHoc = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navToKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navToChuongTrinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zz)).BeginInit();
            this.navToMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.navToKhoaHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(112, 729);
            this.menu1.TabIndex = 0;
            this.menu1.Load += new System.EventHandler(this.menu1_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.menu1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 729);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(111, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 729);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 1);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.profileBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(112, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 48);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 53);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(719, 435);
            this.panel7.TabIndex = 2;
            // 
            // profileBar1
            // 
            this.profileBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileBar1.Location = new System.Drawing.Point(0, 0);
            this.profileBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profileBar1.Name = "profileBar1";
            this.profileBar1.Size = new System.Drawing.Size(1072, 48);
            this.profileBar1.TabIndex = 0;
            this.profileBar1.Load += new System.EventHandler(this.profileBar1_Load);
            // 
            // navToKhoa
            // 
            this.navToKhoa.BackColor = System.Drawing.Color.Teal;
            this.navToKhoa.Controls.Add(this.pictureBox1);
            this.navToKhoa.Controls.Add(this.label1);
            this.navToKhoa.Location = new System.Drawing.Point(20, 22);
            this.navToKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.navToKhoa.Name = "navToKhoa";
            this.navToKhoa.Size = new System.Drawing.Size(486, 295);
            this.navToKhoa.TabIndex = 6;
            this.navToKhoa.Leave += new System.EventHandler(this.navToKhoa_Leave);
            this.navToKhoa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.navToKhoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.Smiley_5;
            this.pictureBox1.Location = new System.Drawing.Point(375, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(204, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa";
            // 
            // navToChuongTrinh
            // 
            this.navToChuongTrinh.BackColor = System.Drawing.Color.Teal;
            this.navToChuongTrinh.Controls.Add(this.zz);
            this.navToChuongTrinh.Controls.Add(this.label2);
            this.navToChuongTrinh.Location = new System.Drawing.Point(20, 359);
            this.navToChuongTrinh.Margin = new System.Windows.Forms.Padding(2);
            this.navToChuongTrinh.Name = "navToChuongTrinh";
            this.navToChuongTrinh.Size = new System.Drawing.Size(486, 293);
            this.navToChuongTrinh.TabIndex = 7;
            this.navToChuongTrinh.Click += new System.EventHandler(this.navToChuongTrinh_Click);
            // 
            // zz
            // 
            this.zz.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.Smiley_9;
            this.zz.Location = new System.Drawing.Point(375, 22);
            this.zz.Margin = new System.Windows.Forms.Padding(2);
            this.zz.Name = "zz";
            this.zz.Size = new System.Drawing.Size(52, 57);
            this.zz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zz.TabIndex = 3;
            this.zz.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(169, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chương trình";
            // 
            // navToMonHoc
            // 
            this.navToMonHoc.BackColor = System.Drawing.Color.Teal;
            this.navToMonHoc.Controls.Add(this.pictureBox2);
            this.navToMonHoc.Controls.Add(this.label3);
            this.navToMonHoc.Location = new System.Drawing.Point(544, 22);
            this.navToMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.navToMonHoc.Name = "navToMonHoc";
            this.navToMonHoc.Size = new System.Drawing.Size(486, 295);
            this.navToMonHoc.TabIndex = 8;
            this.navToMonHoc.Click += new System.EventHandler(this.navToMonHoc_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.Smiley_7;
            this.pictureBox2.Location = new System.Drawing.Point(392, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(206, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Môn học";
            // 
            // navToKhoaHoc
            // 
            this.navToKhoaHoc.BackColor = System.Drawing.Color.Teal;
            this.navToKhoaHoc.Controls.Add(this.pictureBox4);
            this.navToKhoaHoc.Controls.Add(this.label4);
            this.navToKhoaHoc.Location = new System.Drawing.Point(544, 359);
            this.navToKhoaHoc.Margin = new System.Windows.Forms.Padding(2);
            this.navToKhoaHoc.Name = "navToKhoaHoc";
            this.navToKhoaHoc.Size = new System.Drawing.Size(486, 293);
            this.navToKhoaHoc.TabIndex = 9;
            this.navToKhoaHoc.Click += new System.EventHandler(this.navToKhoaHoc_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Nhom1_QuanLyHocVu.Properties.Resources.Smiley_11;
            this.pictureBox4.Location = new System.Drawing.Point(392, 22);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(206, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khóa học";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.navToKhoaHoc);
            this.mainPanel.Controls.Add(this.navToMonHoc);
            this.mainPanel.Controls.Add(this.navToChuongTrinh);
            this.mainPanel.Controls.Add(this.navToKhoa);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(112, 48);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1072, 681);
            this.mainPanel.TabIndex = 6;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 729);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.navToKhoa.ResumeLayout(false);
            this.navToKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navToChuongTrinh.ResumeLayout(false);
            this.navToChuongTrinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zz)).EndInit();
            this.navToMonHoc.ResumeLayout(false);
            this.navToMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.navToKhoaHoc.ResumeLayout(false);
            this.navToKhoaHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Layout.Menu menu1;
        private System.Windows.Forms.Panel panel2;
        private Layout.ProfileBar profileBar1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel navToKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel navToChuongTrinh;
        private System.Windows.Forms.PictureBox zz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel navToMonHoc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel navToKhoaHoc;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Panel mainPanel;
        private Panel panel4;
        private Panel panel3;
    }
}