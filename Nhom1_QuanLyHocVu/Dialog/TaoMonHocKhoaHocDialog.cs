﻿using Nhom1_QuanLyHocVu.Common;
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
        string maChuongTrinh = "";
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
            cbxKhoaHoc.SelectedValue = khoaHoc;
            cbxTenMonHoc.Text = monHoc;
            cbxGiangVien.SelectedValue = giangVien;

            txtMaPhong.Text = maPhong;
            txtThu.Text = thu;

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
            cbxKhoaHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxKhoaHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbxTenMonHoc.ValueMember = "MaMonHoc";
            cbxTenMonHoc.DisplayMember = "TenMonHoc";
            cbxTenMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxTenMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        private void cbxTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaMonHoc.Text = cbxTenMonHoc.SelectedValue.ToString();

            cbxGiangVien.ValueMember = "MaGiaoVien";
            cbxGiangVien.DisplayMember = "HoTen";
            cbxGiangVien.DataSource = entities.GIAOVIENs
                .Join(entities.DAMNHIEMMONs, x1 => x1.MaGiaoVien, x2 => x2.MaGiaoVien, (x1,x2)=> new {x1.MaGiaoVien, x1.HoTen, x2.MaMonHoc, x2.MaChuongTrinh})
                .Where(x => x.MaMonHoc == txtMaMonHoc.Text && x.MaChuongTrinh == maChuongTrinh )
                .Select(x => new { x.MaGiaoVien, x.HoTen })
                .ToList();
            cbxGiangVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxGiangVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbxGiangVien.Text.Length >0 && cbxKhoaHoc.Text.Length > 0 && cbxTenMonHoc.Text.Length >0 
                && txtMaPhong.Text.Length > 0 && txtThu.Text.Length > 0)
            {
                if (RangBuocDuLieu.RangBuocDamBaoGioDay(GetMaGiaoVien(), GetThu(), GetMaKhoaHoc(), GetMaMonHoc(), GetMaPhong()) == -1)
                {
                    MessageBox.Show("Giáo viên đã bị trùng lịch dạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else if (RangBuocDuLieu.RangBuocDamBaoGioDay(GetMaGiaoVien(), GetThu(), GetMaKhoaHoc(), GetMaMonHoc(), GetMaPhong()) == -2)
                {

                    MessageBox.Show("Phòng học đã bị trùng giờ dạy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    DialogResult = DialogResult.OK;
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

        private void cbxKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbxTenMonHoc.Text = "";
            cbxGiangVien.Text = "";
            txtMaMonHoc.Text = "";
            cbxGiangVien.DataSource = null;

            var maKH = cbxKhoaHoc.SelectedValue.ToString();

            maChuongTrinh = entities.KHOAHOCs.Find(maKH).CHUONGTRINH.MaChuongTrinh;
            


            var MonHoc = entities.CHUONGTRINHMONHOCs
                .Where(x => x.MaChuongTrinh == maChuongTrinh)
                .Select(x => new { x.MONHOC.MaMonHoc, x.MONHOC.TenMonHoc }).ToList();
            
            cbxTenMonHoc.DataSource = MonHoc.Where(x => RangBuocDuLieu.RangBuocMonHoc(x.MaMonHoc) == true).ToList();
        }
    }
}
