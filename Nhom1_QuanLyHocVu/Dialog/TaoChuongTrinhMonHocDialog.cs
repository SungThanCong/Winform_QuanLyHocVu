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
    public partial class TaoChuongTrinhMonHocDialog : Form
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public TaoChuongTrinhMonHocDialog()
        {
            InitializeComponent();
            RenderMaMonHoc();
        }

        public TaoChuongTrinhMonHocDialog(string TenKhoa, string MaChuongTrinh, string TenChuongTrinh, string HocKi)
        {
            InitializeComponent();
            txtKhoa.Text = TenKhoa;
            txtMaChuongTrinh.Text = MaChuongTrinh;
            txtTenChuongTrinh.Text = TenChuongTrinh;
            txtHocKi.Text = HocKi;

            txtKhoa.ReadOnly = true;
            txtMaChuongTrinh.ReadOnly = true;
            txtTenChuongTrinh.ReadOnly = true;
            txtHocKi.ReadOnly = true;

            RenderMaMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetMaMonHoc()
        {
            return cbxMaMonHoc.SelectedValue.ToString();
        }

        private void RenderMaMonHoc()
        {
            cbxMaMonHoc.ValueMember = "MaMonHoc";
            cbxMaMonHoc.DisplayMember = "TenMonHoc";
            cbxMaMonHoc.DataSource = entities.MONHOCs.Select(x => new {x.MaMonHoc, x.TenMonHoc}).ToList();
        }
    }
}
