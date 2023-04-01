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
    public partial class TaoMonHocKhoaHocDialog : Form
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public TaoMonHocKhoaHocDialog()
        {
            InitializeComponent();

            RenderData();
        }

        public TaoMonHocKhoaHocDialog(string maKhoa)
        {
            InitializeComponent();

            //txtKhoa.Text = maKhoa;
            RenderData();

        }

        public void RenderData()
        {
            //khoa hoc
            cbxKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbxKhoaHoc.ValueMember = "MaKhoaHoc";
            cbxKhoaHoc.DataSource = entities.KHOAHOCs.Select(x => new { x.MaKhoaHoc, x.TenKhoaHoc }).ToList();

            cbxTenMonHoc.ValueMember = "MaMonHoc";
            cbxTenMonHoc.DisplayMember = "TenMonHoc";
            cbxTenMonHoc.DataSource = entities.MONHOCs.Select(x => new { x.MaMonHoc, x.TenMonHoc }).ToList();

            cbxGiangVien.ValueMember = "MaGiaoVien";
            cbxGiangVien.DisplayMember = "HoTen";
            cbxGiangVien.DataSource = entities.GIAOVIENs.Select(x => new { x.MaGiaoVien, x.HoTen }).ToList();

        }

        private void cbxTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMonHoc.Text = cbxTenMonHoc.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbxGiangVien.Text.Length >0 && cbxKhoaHoc.Text.Length > 0 && cbxTenMonHoc.Text.Length >0 
                && txtMaPhong.Text.Length > 0 && txtThu.Text.Length > 0)
                DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetMaKhoaHoc()
        {
            return cbxKhoaHoc.SelectedValue.ToString();
        }

        public string GetMaMonHoc()
        {
            return cbxTenMonHoc.SelectedValue.ToString();
        }

        public string GetMaGiaoVien()
        {
            return cbxGiangVien.SelectedValue.ToString();
        }

        public string GetMaPhong()
        {
            return txtMaPhong.Text;
        }

        public string GetThu()
        {
            return txtThu.Text;
        }
    }
}
