using Nhom1_QuanLyHocVu.Common;
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
    public partial class MonHocUserControl : UserControl
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();


        public MonHocUserControl()
        {
            InitializeComponent();

            LoadData();
            
        }

        private void LoadData()
        {
            var dsKhoa = entities.KHOAs.ToList();
            var dsMon = entities.MONHOCs.ToList();

            // load data cho combobox
            cbxKhoaMonHoc.ValueMember = "MaKhoa";
            cbxKhoaMonHoc.DisplayMember = "TenKhoa";
            cbxKhoaMonHoc.DataSource = dsKhoa.Select(x => new {x.TenKhoa, x.MaKhoa}).ToList();
            cbxKhoaMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxKhoaMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


            cbxMonDamNhanMon.ValueMember = "MaMonHoc";
            cbxMonDamNhanMon.DisplayMember = "TenMonHoc";
            cbxMonDamNhanMon.DataSource = dsMon.Select(x => new {x.TenMonHoc, x.MaMonHoc}).ToList();
            cbxMonDamNhanMon.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMonDamNhanMon.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

     



        }

        private void lsvMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxKhoaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBox)sender;
            var value = cbx.SelectedValue;
            var khoa = entities.KHOAs.Find(value);
            if(khoa != null)
            {
                LoadMonHocListView(value.ToString());
            }
        }

        private void cbxMonDamNhanMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBox)sender;
            var value = cbx.SelectedValue;
            var monhoc = entities.MONHOCs.Find(value);
            if (monhoc != null)
            {
                LoadDamNhiemMonListView(value.ToString());
            }
        }

        private void LoadMonHocListView(string maKhoa)
        {
            lsvMonHoc.Items.Clear();
            using (var db = new QuanLyHocVuEntities())
            {
                var monhocs = db.MONHOCs.Where(x => x.MaKhoa == maKhoa).ToList();
                foreach (var monhoc in monhocs)
                {
                    ListViewItem item = new ListViewItem(monhoc.MaMonHoc);
                    item.SubItems.Add(monhoc.TenMonHoc);
                    item.SubItems.Add(monhoc.KHOA.TenKhoa);
                    item.SubItems.Add(monhoc.SoTinChi.Value + "");

                    lsvMonHoc.Items.Add(item);
                }
            }
            
        }

        private void LoadDamNhiemMonListView(string maMonHoc)
        {
            lsvDamNhanMon.Items.Clear();
            using(var db = new QuanLyHocVuEntities())
            {
                var damNhiemMons = db.DAMNHIEMMONs.Where(x => x.MaMonHoc == maMonHoc).ToList();
                foreach (var damNhiemMon in damNhiemMons)
                {
                    ListViewItem item = new ListViewItem(damNhiemMon.MONHOC.TenMonHoc);
                    item.SubItems.Add(damNhiemMon.CHUONGTRINH.TenChuongTrinh);
                    item.SubItems.Add(damNhiemMon.GIAOVIEN.HoTen);
                    item.SubItems.Add(damNhiemMon.CoLaDamNhiemChinh.Value + "");
                    item.SubItems.Add(damNhiemMon.MaMonHoc);
                    item.SubItems.Add(damNhiemMon.MaChuongTrinh);
                    item.SubItems.Add(damNhiemMon.MaGiaoVien);
                    lsvDamNhanMon.Items.Add(item);
                }
            }
            
        }

        private void btnDamNhanMon_Click(object sender, EventArgs e)
        {
            TaoDamNhiemMon dialog = new TaoDamNhiemMon();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var maGV = dialog.txtGiaoVien.SelectedValue.ToString();
                    var maMonHoc = dialog.txtMonHoc.SelectedValue.ToString();
                    var maChuongTrinh = dialog.txtChuongTrinh.SelectedValue.ToString();
                    var damNhiemChinh = dialog.ckbDamNhiemChinh.Checked;

                    if (KTDKDamNhiemMon(maGV))
                    {
                        using(var db = new QuanLyHocVuEntities())
                        {
                            DAMNHIEMMON data = new DAMNHIEMMON();
                            data.MaGiaoVien = maGV;
                            data.MaMonHoc = maMonHoc;
                            data.MaChuongTrinh = maChuongTrinh;
                            data.CoLaDamNhiemChinh = damNhiemChinh ? 1 : 0;

                            db.DAMNHIEMMONs.Add(data);
                            int result = db.SaveChanges();

                            if (result > 0)
                            {
                                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDamNhiemMonListView(maMonHoc);
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Một giáo viên chỉ có thể đảm nhiệm chính tối đa 5 môn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool KTDKDamNhiemMon(string maGV)
        {
            var dsDamNhiem = entities.DAMNHIEMMONs.Where(x => x.MaGiaoVien == maGV && x.CoLaDamNhiemChinh == 1).Select(x => x.MaMonHoc).Distinct().ToList();
            if(dsDamNhiem.Count > 5)
            {
                return false;
            }
            return true;
        }

        private void lsvDamNhanMon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaoDamNhiemMon dialog = new TaoDamNhiemMon(lsvDamNhanMon.SelectedItems[0].SubItems[0].Text,
                    lsvDamNhanMon.SelectedItems[0].SubItems[1].Text, lsvDamNhanMon.SelectedItems[0].SubItems[2].Text
                    , lsvDamNhanMon.SelectedItems[0].SubItems[3].Text);
            dialog.SetMonHocEnable(false);
            dialog.SetChuongTrinhEnable(false);
            dialog.SetGiaoVienEnable(false);
          

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using(var db = new QuanLyHocVuEntities())
                {
                    try
                    {
                        DAMNHIEMMON damNhiem = db.DAMNHIEMMONs.Where(x => x.MaGiaoVien == dialog.txtGiaoVien.SelectedValue.ToString() &&
                        x.MaMonHoc == dialog.txtMonHoc.SelectedValue.ToString() && x.MaChuongTrinh == dialog.txtChuongTrinh.SelectedValue.ToString()).FirstOrDefault();

                        if (damNhiem != null)
                        {
                            damNhiem.CoLaDamNhiemChinh = dialog.ckbDamNhiemChinh.Checked == true ? 1 : 0;


                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Sửa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDamNhiemMonListView(damNhiem.MaMonHoc);
                            }
                            else
                            {
                                MessageBox.Show("Sửa môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btnXoaDamNhanMon_Click(object sender, EventArgs e)
        {
            if (lsvDamNhanMon.SelectedItems.Count > 0) // kiểm tra xem có dòng được chọn hay không
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    string maMon = lsvDamNhanMon.SelectedItems[0].SubItems[4].Text;
                    string maCT = lsvDamNhanMon.SelectedItems[0].SubItems[5].Text;
                    string maGV = lsvDamNhanMon.SelectedItems[0].SubItems[6].Text;
                    using(var db = new QuanLyHocVuEntities())
                    {
                        var damNhanMon = db.DAMNHIEMMONs.Where(x => x.MaMonHoc == maMon && x.MaChuongTrinh == maCT && x.MaGiaoVien == maGV).FirstOrDefault();

                        if (damNhanMon != null)
                            db.DAMNHIEMMONs.Remove(damNhanMon);
                        try
                        {
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDamNhiemMonListView(maMon);

                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng\nError: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                 
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng dữ liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bthThemMonHoc_Click(object sender, EventArgs e)
        {
            TaoMonHocDialog dialog = new TaoMonHocDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                try { 
                    using(var db = new QuanLyHocVuEntities())
                    {
                        MONHOC data = new MONHOC();
                        data.MaKhoa = dialog.GetMaKhoa();
                        data.MaMonHoc = dialog.GetMaMon();
                        data.TenMonHoc = dialog.GetTenMonHoc();
                        data.SoTinChi = int.Parse(dialog.GetSoTinChi());

                        db.MONHOCs.Add(data);

                        int result = db.SaveChanges();
                        if(result > 0)
                        {
                            MessageBox.Show("Thêm môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMonHocListView(cbxKhoaMonHoc.SelectedValue.ToString());
                            cbxMonDamNhanMon.DataSource = db.MONHOCs.Select(x => new { x.TenMonHoc, x.MaMonHoc }).ToList();



                        }
                        else
                        {
                            MessageBox.Show("Thêm môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }                
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lsvMonHoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string maMon = lsvMonHoc.SelectedItems[0].SubItems[0].Text;
            string tenMon = lsvMonHoc.SelectedItems[0].SubItems[1].Text;
            string tenKhoa = lsvMonHoc.SelectedItems[0].SubItems[2].Text;
            string soTinChi = lsvMonHoc.SelectedItems[0].SubItems[3].Text;

            TaoMonHocDialog dialog = new TaoMonHocDialog(maMon,tenMon,tenKhoa,soTinChi);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var db = new QuanLyHocVuEntities())
                    {
                        MONHOC data = db.MONHOCs.Find(maMon);
                        data.MaKhoa = dialog.GetMaKhoa();
                        data.TenMonHoc = dialog.GetTenMonHoc();
                        data.SoTinChi = int.Parse(dialog.GetSoTinChi());


                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Sửa môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMonHocListView(cbxKhoaMonHoc.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Thêm môn học thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            if (lsvMonHoc.SelectedItems.Count > 0) // kiểm tra xem có dòng được chọn hay không
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    using(var db = new QuanLyHocVuEntities())
                    {
                        string maMon = lsvMonHoc.SelectedItems[0].SubItems[0].Text;


                        var monHoc = db.MONHOCs.Find(maMon);

                        if (monHoc != null)
                                db.MONHOCs.Remove(monHoc);
                        try
                        {
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadMonHocListView(maMon);

                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng\nError: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng dữ liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lsvDamNhanMon_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ListViewStyle.HeaderStyle(e);
        }

        private void lsvDamNhanMon_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            ListViewStyle.ItemStyle(e);

        }
    }
}
