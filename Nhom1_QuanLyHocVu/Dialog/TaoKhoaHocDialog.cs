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
    public partial class TaoKhoaHocDialog : Form
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public TaoKhoaHocDialog()
        {
            InitializeComponent();

            RenderChuongTrinh();
        }

        public TaoKhoaHocDialog(string TenKhoa, string MaKhoaHoc, string TenKhoaHoc)
        {
            InitializeComponent();

            txtKhoa.Text = TenKhoa;
            txtMaKhoaHoc.Text = MaKhoaHoc;
            txtTenKhoaHoc.Text = TenKhoaHoc;

            RenderChuongTrinh();
        }

        private void RenderChuongTrinh()
        {
            cbxChuongTrinh.ValueMember = "MaChuongTrinh";
            cbxChuongTrinh.DisplayMember = "TenChuongTrinh";
            cbxChuongTrinh.DataSource = entities.CHUONGTRINHs.Select(x => new { x.MaChuongTrinh, x.TenChuongTrinh }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetMaKhoaHoc()
        {
            return txtMaKhoaHoc.Text;
        }

        public string GetTenKhoaHoc()
        {
            return txtTenKhoaHoc.Text;
        }

        public string GetNamBatDau()
        {
            return txtNamBatDau.Text;
        }

        public string GetNamKetThuc()
        {
            return txtNamKetThuc.Text;
        }

        public string GetMaChuongTrinh()
        {
            return cbxChuongTrinh.SelectedValue.ToString();
        }
    }
}
