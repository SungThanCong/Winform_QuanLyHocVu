using Nhom1_QuanLyHocVu.Layout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QuanLyHocVu
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

       


       
        private void navToKhoa_Click(object sender, MouseEventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new KhoaUserControl());
        }

        private void navToMonHoc_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new MonHocUserControl());
        }

        private void navToChuongTrinh_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new ChuongTrinhUserControl());
        }

        private void navToKhoaHoc_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(new KhoaHocUserControl());
        }

        private void navToKhoa_Leave(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
