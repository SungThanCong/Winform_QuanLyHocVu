using Nhom1_QuanLyHocVu.Common;
using Nhom1_QuanLyHocVu.Dialog;
using Nhom1_QuanLyHocVu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            cbxKhoaKhoaHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxKhoaKhoaHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


            cbxKhoaHoc.ValueMember = "MaKhoaHoc";
            cbxKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbxKhoaHoc.DataSource = entities.KHOAHOCs.Select(x => new { x.MaKhoaHoc, x.TenKhoaHoc }).ToList();
            cbxKhoaHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxKhoaHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbxMonHoc.ValueMember = "MaMonHoc";
            cbxMonHoc.DisplayMember = "TenMonHoc";
            cbxMonHoc.DataSource = entities.MONHOCs.Select(x => new { x.MaMonHoc, x.TenMonHoc }).ToList()
                .Where(x => RangBuocDuLieu.RangBuocMonHoc(x.MaMonHoc) == true).ToList();
            cbxMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //cbxGiaoVien.ValueMember = "MaGiaoVien";
            //cbxGiaoVien.DisplayMember = "HoTen";
            //cbxGiaoVien.DataSource = entities.GIAOVIENs.Select(x => new { x.MaGiaoVien, x.HoTen }).ToList();
            //cbxGiaoVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            //cbxGiaoVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


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
            using (var db = new QuanLyHocVuEntities())
            {
                var data = db.KHOAHOCs.Where(x => x.CHUONGTRINH.MaKhoa == maKhoa).ToList();
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
           
        }

        private void ReloadMonHocKhoaHoc(string maKhoaHoc, string maMon)
        {
            lsvMonHocKhoaHoc.Items.Clear();
            using(var db = new QuanLyHocVuEntities())
            {
                var data = db.KHOAHOCMONs.Where(x => x.MaKhoaHoc == maKhoaHoc && x.MaMonHoc == maMon).ToList();
                foreach (var mhkh in data)
                {
                    ListViewItem item = new ListViewItem(mhkh.MaMonHoc);
                    item.SubItems.Add(mhkh.MONHOC.TenMonHoc);
                    item.SubItems.Add(mhkh.KHOAHOC.TenKhoaHoc);
                    item.SubItems.Add(mhkh.GIAOVIEN.HoTen);
                    item.SubItems.Add(mhkh.MaPhong);
                    item.SubItems.Add(mhkh.MaThu);
                    item.SubItems.Add(mhkh.MaKhoaHoc);
                    item.SubItems.Add(mhkh.MaGiaoVien_day);


                    lsvMonHocKhoaHoc.Items.Add(item);
                }
            }
           
        }

        private void cbxKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxKhoaHoc.SelectedItem != null && cbxMonHoc.SelectedItem != null)
                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(),cbxMonHoc.SelectedValue.ToString());
        }

        private void btnThemKhoaHoc_Click(object sender, EventArgs e)
        {
            TaoKhoaHocDialog taoKhoaHocDialog = new TaoKhoaHocDialog();
            if (taoKhoaHocDialog.ShowDialog() == DialogResult.OK)
            {
                using (var db = new QuanLyHocVuEntities())
                {
                    try
                    {

                        KHOAHOC khoahoc = new KHOAHOC();
                        khoahoc.MaChuongTrinh = taoKhoaHocDialog.GetMaChuongTrinh();
                        khoahoc.MaKhoaHoc = taoKhoaHocDialog.GetMaKhoaHoc();
                        khoahoc.TenKhoaHoc = taoKhoaHocDialog.GetTenKhoaHoc();
                        khoahoc.NamBatDau = int.Parse(taoKhoaHocDialog.GetNamBatDau());
                        khoahoc.NamKetThuc = int.Parse(taoKhoaHocDialog.GetNamKetThuc());

                        db.KHOAHOCs.Add(khoahoc);
                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadKhoaHoc(cbxKhoaKhoaHoc.SelectedValue.ToString());

                            cbxKhoaHoc.DataSource = entities.KHOAHOCs.Select(x => new { x.MaKhoaHoc, x.TenKhoaHoc }).ToList();

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
        }



        private void cbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxKhoaHoc.SelectedItem != null && cbxMonHoc.SelectedItem != null)

                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(), cbxMonHoc.SelectedValue.ToString());
        }

        private void btnThemMonHocKhoaHoc_Click(object sender, EventArgs e)
        {
            TaoMonHocKhoaHocDialog dialog = new TaoMonHocKhoaHocDialog();
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                using(var db = new QuanLyHocVuEntities())
                try
                {
                    KHOAHOCMON data = new KHOAHOCMON();
                    data.MaThu = dialog.GetThu();
                    data.MaPhong = dialog.GetMaPhong();
                    data.MaGiaoVien_day = dialog.GetMaGiaoVien();
                    data.MaKhoaHoc = dialog.GetMaKhoaHoc();
                    data.MaMonHoc = dialog.GetMaMonHoc();

                    db.KHOAHOCMONs.Add(data);

                    int result = db.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadMonHocKhoaHoc(data.MaKhoaHoc, data.MaMonHoc);

                        cbxMonHoc.SelectedValue = data.MaMonHoc;
                        cbxKhoaHoc.SelectedValue = data.MaKhoaHoc;
                        
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

        private void lsvKhoaHoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string maKH = lsvKhoaHoc.SelectedItems[0].SubItems[0].Text;
            string tenKH = lsvKhoaHoc.SelectedItems[0].SubItems[1].Text;
            string tenCT = lsvKhoaHoc.SelectedItems[0].SubItems[2].Text;
            string namBD = lsvKhoaHoc.SelectedItems[0].SubItems[3].Text;
            string namKT = lsvKhoaHoc.SelectedItems[0].SubItems[4].Text;

            TaoKhoaHocDialog dialog = new TaoKhoaHocDialog(maKH,tenKH, tenCT, namBD, namKT);
            dialog.SetMaKhoaHocEnable(false);

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                using(var db = new QuanLyHocVuEntities())
                {
                    KHOAHOC khoaHoc = db.KHOAHOCs.Find(maKH);

                    if (khoaHoc != null)
                    {
                        try
                        {
                            khoaHoc.TenKhoaHoc = dialog.GetTenKhoaHoc();
                            khoaHoc.MaChuongTrinh = dialog.GetMaChuongTrinh();
                            khoaHoc.NamBatDau = int.Parse(dialog.GetNamBatDau());
                            khoaHoc.NamKetThuc = int.Parse(dialog.GetNamKetThuc());

                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Sửa khóa học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ReloadKhoaHoc(cbxKhoaKhoaHoc.SelectedValue.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Sửa khóa học không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
               
            }

        }

        private void btnXoaKhoaHoc_Click(object sender, EventArgs e)
        {
            if (lsvKhoaHoc.SelectedItems.Count > 0) // kiểm tra xem có dòng được chọn hay không
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    using(var db = new QuanLyHocVuEntities())
                    {
                        string maKhoaHoc = lsvKhoaHoc.SelectedItems[0].SubItems[0].Text;
                        var khoaHoc = db.KHOAHOCs.Find(maKhoaHoc);

                        db.KHOAHOCs.Remove(khoaHoc);
                        try
                        {
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ReloadKhoaHoc(cbxKhoaKhoaHoc.SelectedValue.ToString());

                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu không đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng dữ liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lsvMonHocKhoaHoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string maMH = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[0].Text;
            string tenMH = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[1].Text;
            string khoaHoc = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[6].Text;
            string giaoVien = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[7].Text;
            string phong = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[4].Text;
            string thu = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[5].Text;


            TaoMonHocKhoaHocDialog dialog = new TaoMonHocKhoaHocDialog(khoaHoc, tenMH, giaoVien, phong, thu);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using(var db = new QuanLyHocVuEntities())
                {
                    KHOAHOCMON khm = db.KHOAHOCMONs.Where(x => x.MaKhoaHoc == khoaHoc && x.MaPhong == phong && x.MaMonHoc == maMH
             && x.MaGiaoVien_day == giaoVien && x.MaThu == thu).FirstOrDefault();

                    if (khm != null)
                    {
                        try
                        {
                            khm.MaThu = dialog.GetThu();
                            khm.MaPhong = dialog.GetMaPhong();

                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Sửa khóa học - môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(), cbxMonHoc.SelectedValue.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Sửa khóa học - môn học không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
             
            }
        }

        private void btnXoaMonHocKhoaHoc_Click(object sender, EventArgs e)
        {
            if (lsvMonHocKhoaHoc.SelectedItems.Count > 0) // kiểm tra xem có dòng được chọn hay không
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    string maMH = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[0].Text;
                    string tenMH = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[1].Text;
                    string khoaHoc = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[6].Text;
                    string giaoVien = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[7].Text;
                    string phong = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[4].Text;
                    string thu = lsvMonHocKhoaHoc.SelectedItems[0].SubItems[5].Text;

                    using(var db = new QuanLyHocVuEntities())
                    {
                     

                        KHOAHOCMON khm = db.KHOAHOCMONs.Where(x => x.MaKhoaHoc == khoaHoc && x.MaPhong == phong && x.MaMonHoc == maMH
                && x.MaGiaoVien_day == giaoVien && x.MaThu == thu).FirstOrDefault();


                        db.KHOAHOCMONs.Remove(khm);

                        try
                        {
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ReloadMonHocKhoaHoc(cbxKhoaHoc.SelectedValue.ToString(), cbxMonHoc.SelectedValue.ToString());
                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu không đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng dữ liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lsvKhoaHoc_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ListViewStyle.HeaderStyle(e);
        }

        private void lsvKhoaHoc_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            ListViewStyle.ItemStyle(e);
        }
    }
}
