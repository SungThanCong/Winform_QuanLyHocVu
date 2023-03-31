using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QuanLyHocVu.Layout
{
    public partial class Menu : UserControl
    {
        private Form parentForm;
        public Menu(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navKhoa_Click(object sender, EventArgs e)
        {
            ((Dashboard)parentForm).mainPanel.Controls.Clear();
            ((Dashboard)parentForm).mainPanel.Controls.Add(new KhoaUserControl());
            
        }

        private void navMonHoc_Click(object sender, EventArgs e)
        {
            ((Dashboard)parentForm).mainPanel.Controls.Clear();
            ((Dashboard)parentForm).mainPanel.Controls.Add(new MonHocUserControl());
        }

        private void navChuongTrinh_Click(object sender, EventArgs e)
        {
            ((Dashboard)parentForm).mainPanel.Controls.Clear();
            ((Dashboard)parentForm).mainPanel.Controls.Add(new ChuongTrinhUserControl());
        }

        private void navKhoaHoc_Click(object sender, EventArgs e)
        {
            ((Dashboard)parentForm).mainPanel.Controls.Clear();
            ((Dashboard)parentForm).mainPanel.Controls.Add(new KhoaHocUserControl());
        }
    }
}
