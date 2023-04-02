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

        public TaoChuongTrinhMonHocDialog(string MaChuongTrinh, string HocKi)
        {
            InitializeComponent();
            cbxMaChuongTrinh.Text = MaChuongTrinh;
            txtHocKi.Text = HocKi;

            RenderMaMonHoc();
        }
        public TaoChuongTrinhMonHocDialog(string MaChuongTrinh,string MaMonHoc, string HocKi)
        {
            InitializeComponent();
            cbxMaChuongTrinh.Text = MaChuongTrinh;
            cbxMaMonHoc.Text = MaMonHoc;
            txtHocKi.Text = HocKi;

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

            cbxMaChuongTrinh.DataSource = entities.CHUONGTRINHs.Select(x => x.MaChuongTrinh).ToList();
        }

        private void cbxMaChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenChuongTrinh.Text = entities.CHUONGTRINHs.Find(cbxMaChuongTrinh.SelectedValue.ToString()).TenChuongTrinh;
        }

        public void SetChuongTrinhEnable(bool value)
        {
            cbxMaChuongTrinh.Enabled = value;
        }

        public void SetMonHocEnable(bool value)
        {
            cbxMaMonHoc.Enabled = value;
        }
    }
}
