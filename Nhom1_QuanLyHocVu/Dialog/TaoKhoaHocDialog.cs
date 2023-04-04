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


        public TaoKhoaHocDialog(string MaKhoaHoc, string TenKhoaHoc, string ChuongTrinh, string NamBatDau,string NamKetThuc)
        {
            InitializeComponent();

            RenderChuongTrinh();


            txtMaKhoaHoc.Text = MaKhoaHoc;
            txtTenKhoaHoc.Text = TenKhoaHoc;
            cbxChuongTrinh.Text = ChuongTrinh;
            txtNamBatDau.Text = NamBatDau;
            txtNamKetThuc.Text = NamKetThuc;

        }

        private void RenderChuongTrinh()
        {
            cbxChuongTrinh.ValueMember = "MaChuongTrinh";
            cbxChuongTrinh.DisplayMember = "TenChuongTrinh";
            cbxChuongTrinh.DataSource = entities.CHUONGTRINHs.Select(x => new { x.MaChuongTrinh, x.TenChuongTrinh }).ToList();
            cbxChuongTrinh.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxChuongTrinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenKhoaHoc.Text.Length >0 && txtMaKhoaHoc.Text.Length > 0 && txtNamBatDau.Text.Length >0 && txtNamKetThuc.Text.Length >0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Lỗi");
            }
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

        public void SetMaKhoaHocEnable(bool value)
        {
            txtMaKhoaHoc.ReadOnly = !value;
            if(value == false)
            {
                txtMaKhoaHoc.BackColor = Color.LightGray;
            }
        }

        private void cbxChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            CHUONGTRINH ct = entities.CHUONGTRINHs.Find(cbxChuongTrinh.SelectedValue.ToString());

            txtKhoa.Text = ct.KHOA.TenKhoa;
        }
    }
}
