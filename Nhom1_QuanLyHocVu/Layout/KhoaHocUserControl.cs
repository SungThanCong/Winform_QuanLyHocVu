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

namespace Nhom1_QuanLyHocVu.Layout
{
    public partial class KhoaHocUserControl : UserControl
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public KhoaHocUserControl()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            cbxKhoaKhoaHoc.DisplayMember = "TenKhoa";
            cbxKhoaKhoaHoc.ValueMember = "MaKhoa";
            cbxKhoaKhoaHoc.DataSource = entities.KHOAs.Select(x => new { x.MaKhoa, x.TenKhoa}).ToList();

            cbxKhoaHoc.ValueMember = "MaKhoaHoc";
            cbxKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbxKhoaHoc.DataSource = entities.KHOAHOCs.Select(x => new { x.MaKhoaHoc, x.TenKhoaHoc }).ToList();

            cbxMonHoc.ValueMember = "MaMonHoc";
            cbxMonHoc.DisplayMember = "TenMonHoc";
            cbxMonHoc.DataSource = entities.MONHOCs.Select(x => new { x.MaMonHoc, x.TenMonHoc }).ToList();

            cbxGiaoVien.ValueMember = "MaGiaoVien";
            cbxGiaoVien.DisplayMember = "HoTen";
            cbxGiaoVien.DataSource = entities.GIAOVIENs.Select(x => new { x.MaGiaoVien, x.HoTen }).ToList();

        }

        private void cbxKhoaKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBox)sender;
            var value = cbx.SelectedValue;
            var khoa = entities.KHOAs.Find(value);
            if (khoa != null)
            {
                ReloadKhoaHoc(value.ToString());
            }
        }

        private void ReloadKhoaHoc(string maKhoa)
        {
            lsvKhoaHoc.Items.Clear();
            var data = entities.KHOAHOCs.Where(x => x.CHUONGTRINH.MaKhoa == maKhoa).ToList();
            foreach (var khoahoc in data)
            {
                ListViewItem item = new ListViewItem(khoahoc.MaKhoaHoc);
                item.SubItems.Add(khoahoc.TenKhoaHoc);
                item.SubItems.Add(khoahoc.CHUONGTRINH.TenChuongTrinh);
                item.SubItems.Add(khoahoc.NamBatDau.ToString());
                item.SubItems.Add(khoahoc.NamKetThuc.ToString());
                lsvKhoaHoc.Items.Add(item);
            }
        }

        private void ReloadMonHocKhoaHoc(string maKhoaHoc, string maMon, string maGV)
        {
            lsvMonHocKhoaHoc.Items.Clear();
            var data = entities.KHOAHOCMONs.Where(x => x.MaKhoaHoc == maKhoaHoc && x.MaMonHoc == maMon && x.MaGiaoVien_day == maGV).ToList();
            foreach (var mhkh in data)
            {
                ListViewItem item = new ListViewItem(mhkh.MaMonHoc);
                item.SubItems.Add(mhkh.MONHOC.TenMonHoc);
                item.SubItems.Add(mhkh.KHOAHOC.TenKhoaHoc);
                item.SubItems.Add(mhkh.GIAOVIEN.HoTen);
                item.SubItems.Add(mhkh.MaPhong);
                item.SubItems.Add(mhkh.MaThu);

                lsvKhoaHoc.Items.Add(item);
            }
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void cbxKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
