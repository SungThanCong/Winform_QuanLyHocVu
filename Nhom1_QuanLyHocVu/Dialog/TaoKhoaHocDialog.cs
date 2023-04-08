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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if(int.Parse(txtNamKetThuc.Text) - int.Parse(txtNamBatDau.Text) > 7)
                    MessageBox.Show("Khoảng thời gian của một khóa học không thể lớn hơn 7", "Lỗi");
                else if(int.Parse(txtNamKetThuc.Text) - int.Parse(txtNamBatDau.Text) < 0)
                {
                    MessageBox.Show("Năm kết thúc phải lớn hơn hoặc bằng năm bắt đầu", "Lỗi");

                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

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

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            var textbox = (System.Windows.Forms.TextBox)sender;
            int minValue = 1; // giá trị tối thiểu
            int maxValue = 9999; // giá trị tối đa

            if (!int.TryParse(textbox.Text, out int value))
            {
                textbox.Text = minValue.ToString();
            }
            else if (value < minValue)
            {
                textbox.Text = minValue.ToString();
            }
            else if (value > maxValue)
            {
                textbox.Text = maxValue.ToString();
            }
        }
    }
}
