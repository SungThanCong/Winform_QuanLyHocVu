using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QuanLyHocVu.Dialog
{
    public partial class TaoKhoaDialog : Form
    {
        public TaoKhoaDialog()
        {
            InitializeComponent();
        }

        private void btnXacNhanTaoKhoa_Click(object sender, EventArgs e)
        {
            if(txtTaoMaKhoa.Text.Length>0 && txtTaoTenKhoa.Text.Length > 0)
            {
                DialogResult = DialogResult.OK;
              
            }
            else
            {
                MessageBox.Show("Mã khoa và tên khoa không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyTaoKhoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
