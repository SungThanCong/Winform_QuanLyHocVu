using Nhom1_QuanLyHocVu.Dialog;
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

        private void cbxKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxKhoaHoc.SelectedItem != null && cbxMonHoc.SelectedItem != null && cbxGiaoVien.SelectedItem != null)
                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(),cbxMonHoc.SelectedValue.ToString(), 
                    cbxGiaoVien.SelectedValue.ToString());
        }

        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            TaoKhoaHocDialog taoKhoaHocDialog = new TaoKhoaHocDialog();
            if (taoKhoaHocDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    KHOAHOC khoahoc = new KHOAHOC();
                    khoahoc.MaChuongTrinh = taoKhoaHocDialog.GetMaChuongTrinh();
                    khoahoc.MaKhoaHoc = taoKhoaHocDialog.GetMaKhoaHoc();
                    khoahoc.TenKhoaHoc = taoKhoaHocDialog.GetTenKhoaHoc();
                    khoahoc.NamBatDau = int.Parse(taoKhoaHocDialog.GetNamBatDau());
                    khoahoc.NamKetThuc = int.Parse(taoKhoaHocDialog.GetNamKetThuc());

                    entities.KHOAHOCs.Add(khoahoc);
                    int result = entities.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liêu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void cbxGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoaHoc.SelectedItem != null && cbxMonHoc.SelectedItem != null && cbxGiaoVien.SelectedItem != null)

                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(), cbxMonHoc.SelectedValue.ToString(),
                cbxGiaoVien.SelectedValue.ToString());
        }

        private void cbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoaHoc.SelectedItem != null && cbxMonHoc.SelectedItem != null && cbxGiaoVien.SelectedItem != null)

                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(), cbxMonHoc.SelectedValue.ToString(),
                cbxGiaoVien.SelectedValue.ToString());
        }

        private void btnThemMonHocKhoaHoc_Click(object sender, EventArgs e)
        {
            TaoMonHocKhoaHocDialog dialog = new TaoMonHocKhoaHocDialog();
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                try
                {
                    KHOAHOCMON data = new KHOAHOCMON();
                    data.MaThu = dialog.GetThu();
                    data.MaPhong = dialog.GetMaPhong();
                    data.MaGiaoVien_day = dialog.GetMaGiaoVien();
                    data.MaKhoaHoc = dialog.GetMaKhoaHoc();
                    data.MaMonHoc = dialog.GetMaMonHoc();

                    entities.KHOAHOCMONs.Add(data);

                    int result = entities.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liêu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }
    }
}
