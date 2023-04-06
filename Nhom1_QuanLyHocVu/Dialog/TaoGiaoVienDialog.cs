using Nhom1_QuanLyHocVu.Model;
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
    public partial class TaoGiaoVienDialog : Form
    {
        QuanLyHocVuEntities QuanLyHocVuEntities = new QuanLyHocVuEntities();

        public TaoGiaoVienDialog()
        {
            InitializeComponent();

            RenderData();
        }

        private void RenderData()
        {
            var dsMaKhoa = QuanLyHocVuEntities.KHOAs.Select(x => x.MaKhoa).ToList();
            cboMaKhoaTaoGV.DataSource = dsMaKhoa;
            cboMaKhoaTaoGV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMaKhoaTaoGV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnXacNhanTaoGV_Click(object sender, EventArgs e)
        {
            if (txtTaoMaGV.Text.Length > 0 && txtTaoTenGV.Text.Length > 0)
            {
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Mã giáo viên và tên giáo viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }

        private void btnHuyTaoGV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
