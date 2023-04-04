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
    public partial class TaoMonHocDialog : Form
    {
        public TaoMonHocDialog()
        {
            InitializeComponent();

            RenderKhoa();
        }

        public TaoMonHocDialog(string MaMonHoc, string TenMonHoc, string TenKhoa, string SoTinChi)
        {
            InitializeComponent();

            RenderKhoa();

            txtMaMonHoc.Text = MaMonHoc;
            txtTenMonHoc.Text = TenMonHoc;
            cbxKhoa.Text = TenKhoa;
            txtSoTinChi.Text = SoTinChi;

            txtMaMonHoc.ReadOnly = true;
        }

        private void RenderKhoa()
        {
            using(var db = new QuanLyHocVuEntities())
            {
                cbxKhoa.DisplayMember = "TenKhoa";
                cbxKhoa.ValueMember = "MaKhoa";
                cbxKhoa.DataSource = db.KHOAs.Select(x => new { x.MaKhoa, x.TenKhoa }).ToList();
                cbxKhoa.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbxKhoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaMonHoc.Text.Length >0 && txtTenMonHoc.Text.Length > 0 && txtSoTinChi.Text.Length > 0 && cbxKhoa.SelectedIndex > -1)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string GetMaMon()
        {
            return txtMaMonHoc.Text;
        }
        public string GetTenMonHoc()
        {
            return txtTenMonHoc.Text;
        }
        public string GetMaKhoa()
        {
            return cbxKhoa.SelectedValue.ToString();
        }
        public string GetSoTinChi()
        {
            return txtSoTinChi.Text;
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
