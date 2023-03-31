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

            cbxMonDamNhanMon.ValueMember = "MaMonHoc";
            cbxMonDamNhanMon.DisplayMember = "TenMonHoc";
            cbxMonDamNhanMon.DataSource = dsMon.Select(x => new {x.TenMonHoc, x.MaMonHoc}).ToList();

            ////load data ban đầu cho 2 listview
            //var selectedKhoa = dsKhoa.Count > 0 ? dsKhoa.ElementAt(0) : null;
            //var selectedMon = dsMon.Count > 0 ? dsMon.ElementAt(0) : null;
            
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
            var monhocs = entities.MONHOCs.Where(x => x.MaKhoa == maKhoa).ToList();
            foreach (var monhoc in monhocs)
            {
                ListViewItem item = new ListViewItem(monhoc.MaMonHoc);
                item.SubItems.Add(monhoc.TenMonHoc);
                item.SubItems.Add(monhoc.KHOA.TenKhoa);
                item.SubItems.Add(monhoc.SoTinChi.Value + "");
                item.SubItems.Add("Xóa");
                item.SubItems.Add("Sửa");
                lsvMonHoc.Items.Add(item);
            }
        }

        private void LoadDamNhiemMonListView(string maMonHoc)
        {
            lsvDamNhanMon.Items.Clear();
            var damNhiemMons = entities.DAMNHIEMMONs.Where(x => x.MaMonHoc == maMonHoc).ToList();
            foreach (var damNhiemMon in damNhiemMons)
            {
                ListViewItem item = new ListViewItem(damNhiemMon.MONHOC.TenMonHoc);
                item.SubItems.Add(damNhiemMon.CHUONGTRINH.TenChuongTrinh);
                item.SubItems.Add(damNhiemMon.GIAOVIEN.HoTen);
                item.SubItems.Add(damNhiemMon.CoLaDamNhiemChinh.Value + "");
                item.SubItems.Add("Xóa");
                item.SubItems.Add("Sửa");
                lsvDamNhanMon.Items.Add(item);
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
                        DAMNHIEMMON data = new DAMNHIEMMON();
                        data.MaGiaoVien = maGV;
                        data.MaMonHoc = maMonHoc;
                        data.MaChuongTrinh = maChuongTrinh;
                        data.CoLaDamNhiemChinh =  damNhiemChinh ? 1 : 0;

                        entities.DAMNHIEMMONs.Add(data);
                        int result = entities.SaveChanges();

                        if (result > 0)
                        {
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
    }
}
