using Nhom1_QuanLyHocVu.Common;
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

        public TaoMonHocKhoaHocDialog(string khoaHoc, string monHoc, string giangVien, string maPhong, string thu)
        {
            InitializeComponent();

            //txtKhoa.Text = maKhoa;
            RenderData();

            cbxTenMonHoc.Text = monHoc;
            txtMaPhong.Text = maPhong;
            cbxGiangVien.Text = giangVien;
            txtThu.Text = thu;
            cbxKhoaHoc.Text = khoaHoc;

            cbxKhoaHoc.Enabled = false;
            cbxTenMonHoc.Enabled = false;
            cbxGiangVien.Enabled = false;
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

        }

        private void cbxTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMonHoc.Text = cbxTenMonHoc.SelectedValue.ToString();

          
            cbxGiangVien.DataSource = entities.GIAOVIENs.Join(entities.DAMNHIEMMONs, x1 => x1.MaGiaoVien, x2 => x2.MaGiaoVien, (x1,x2)=> new {x1.MaGiaoVien, x1.HoTen, x2.MaMonHoc})
                .Where(x => x.MaMonHoc == txtMaMonHoc.Text).Select(x => new { x.MaGiaoVien, x.HoTen }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbxGiangVien.Text.Length >0 && cbxKhoaHoc.Text.Length > 0 && cbxTenMonHoc.Text.Length >0 
                && txtMaPhong.Text.Length > 0 && txtThu.Text.Length > 0)
            {
                if (RangBuocDuLieu.RangBuocDamBaoGioDay(GetMaGiaoVien(), GetThu()))
                {
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Giáo viên đã bị trùng giờ dạy của bản thân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
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
