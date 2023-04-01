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
    public partial class ChuongTrinhUserControl : UserControl
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public ChuongTrinhUserControl()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            var dsKhoa = entities.KHOAs.ToList();
            var dsChuongTrinhMonHoc = entities.CHUONGTRINHMONHOCs.ToList();


            // load data cho combobox
            cbxKhoaMonHoc.DisplayMember = "TenKhoa";
            cbxKhoaMonHoc.ValueMember = "MaKhoa";
            cbxKhoaMonHoc.DataSource = dsKhoa.Select(x => new {x.TenKhoa, x.MaKhoa}).ToList();

            cbxTenChuongTrinh.ValueMember = "MaChuongTrinh";
            cbxTenChuongTrinh.DisplayMember = "TenChuongTrinh";
            cbxTenChuongTrinh.DataSource = dsChuongTrinhMonHoc.Select(x => new {x.MaChuongTrinh, x.CHUONGTRINH.TenChuongTrinh}).Distinct().ToList();
         


            ////load data ban đầu cho 2 listview
            //var selectedKhoa = dsKhoa.Count > 0 ? dsKhoa.ElementAt(0) : null;
            //var selectedChuongTrinhMonHoc = dsChuongTrinhMonHoc.Count > 0 ? dsChuongTrinhMonHoc.ElementAt(0) : null;
           

        }

        private void cbxTenChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTenChuongTrinh.SelectedIndex >= 0)
            {
                var chuongTrinhMonHoc = entities.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == cbxTenChuongTrinh.SelectedValue).ToList();
                cbxHocKy.DataSource = chuongTrinhMonHoc.Select(x => x.HocKy).Distinct().OrderBy(x => x.Value).ToList();
            }
        }

        private void lsvChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvChuongTrinhMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBox)sender;
            var value = cbx.SelectedValue;
            var chuongTrinh = entities.CHUONGTRINHs.Find(cbxTenChuongTrinh.SelectedValue);
            if (chuongTrinh != null)
            {
                LoadChuongTrinhMonHocListView(cbxTenChuongTrinh.SelectedValue.ToString(), int.Parse(value+""));
            }
        }

        private void cbxKhoaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBox)sender;
            var value = cbx.SelectedValue;
            var khoa = entities.KHOAs.Find(value);
            if (khoa != null)
            {
                LoadChuongTrinhListView(khoa.MaKhoa);
            }
        }

        private void LoadChuongTrinhListView(string maKhoa)
        {
            lsvChuongTrinh.Items.Clear();
            var chuongTrinhs = entities.CHUONGTRINHs.Where(x => x.MaKhoa == maKhoa).ToList();
            foreach (var chuongTrinh in chuongTrinhs)
            {
                ListViewItem item = new ListViewItem(chuongTrinh.MaChuongTrinh);
                item.SubItems.Add(chuongTrinh.TenChuongTrinh);
                item.SubItems.Add(chuongTrinh.KHOA.TenKhoa);
                item.SubItems.Add(chuongTrinh.GIAOVIEN.HoTen);
                item.SubItems.Add("Xóa");
                item.SubItems.Add("Sửa");
                lsvChuongTrinh.Items.Add(item);
            }
        }

        private void LoadChuongTrinhMonHocListView(string maChuongTrinh, int hocKy)
        {
            lsvChuongTrinhMonHoc.Items.Clear();
            var chuongTrinhMonHocs = entities.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == maChuongTrinh && x.HocKy.Value == hocKy).ToList();
            foreach (var CTMonHoc in chuongTrinhMonHocs)
            {
                ListViewItem item = new ListViewItem(CTMonHoc.MaChuongTrinh);
                item.SubItems.Add(CTMonHoc.CHUONGTRINH.TenChuongTrinh);
                item.SubItems.Add(CTMonHoc.MONHOC.TenMonHoc);
                item.SubItems.Add(CTMonHoc.HocKy.Value +"");
                item.SubItems.Add("Xóa");
                item.SubItems.Add("Sửa");
                lsvChuongTrinhMonHoc.Items.Add(item);
            }
        }

        private void bthThemChuongTrinh_Click(object sender, EventArgs e)
        {   
            if(cbxKhoaMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                TaoChuongTrinhDialog dialog = new TaoChuongTrinhDialog(cbxKhoaMonHoc.Text);
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CHUONGTRINH chuongTrinh = new CHUONGTRINH();
                        chuongTrinh.MaKhoa = cbxKhoaMonHoc.SelectedValue.ToString();
                        chuongTrinh.MaChuongTrinh = dialog.txtMaChuongTrinh.Text;
                        chuongTrinh.TenChuongTrinh = dialog.txtTenChuongTrinh.Text;
                        chuongTrinh.MaBacHoc = "DH";
                        chuongTrinh.MaGiaoVien_GiamDocCT = dialog.cbxGiamDocChuongTrinh.SelectedValue.ToString();

                        entities.CHUONGTRINHs.Add(chuongTrinh);
                        int result = entities.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm chương trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChuongTrinhListView(cbxKhoaMonHoc.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Thêm chương trình không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
            }

        }

        private void lsvChuongTrinh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaoChuongTrinhDialog dialog = new TaoChuongTrinhDialog(cbxKhoaMonHoc.Text);
            dialog.txtMaChuongTrinh.ReadOnly = true;
            dialog.txtTenKhoa.Enabled = true;
            dialog.txtMaChuongTrinh.Text = lsvChuongTrinh.SelectedItems[0].SubItems[0].Text;
            dialog.txtTenChuongTrinh.Text = lsvChuongTrinh.SelectedItems[0].SubItems[1].Text;
            dialog.cbxGiamDocChuongTrinh.Text = lsvChuongTrinh.SelectedItems[0].SubItems[3].Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CHUONGTRINH chuongTrinh = entities.CHUONGTRINHs.Find(dialog.txtMaChuongTrinh.Text);

                    chuongTrinh.MaKhoa = dialog.txtTenKhoa.SelectedValue.ToString();
                    chuongTrinh.TenChuongTrinh = dialog.txtTenChuongTrinh.Text;
                    chuongTrinh.MaBacHoc = "DH";
                    chuongTrinh.MaGiaoVien_GiamDocCT = dialog.cbxGiamDocChuongTrinh.SelectedValue.ToString();

                    int result = entities.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show("Sửa chương trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa chương trình không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnThemCTMonHoc_Click(object sender, EventArgs e)
        {
            if (cbxTenChuongTrinh.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn chương trình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cbxHocKy.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn phải chọn học kì", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string maCT = cbxTenChuongTrinh.SelectedValue.ToString();
                var chuongTrinh = entities.CHUONGTRINHs.Find(maCT);

                TaoChuongTrinhMonHocDialog dialog = new TaoChuongTrinhMonHocDialog(chuongTrinh.KHOA.TenKhoa, chuongTrinh.MaChuongTrinh,
                    chuongTrinh.TenChuongTrinh, cbxHocKy.SelectedValue.ToString());
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CHUONGTRINHMONHOC CTMH = new CHUONGTRINHMONHOC();
                        CTMH.MaMonHoc = dialog.GetMaMonHoc();
                        CTMH.MaChuongTrinh = chuongTrinh.MaChuongTrinh;
                        CTMH.HocKy = int.Parse(cbxHocKy.SelectedValue.ToString());
                      
                        entities.CHUONGTRINHMONHOCs.Add(CTMH);
                        int result = entities.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm chương trình - môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChuongTrinhMonHocListView(cbxTenChuongTrinh.SelectedValue.ToString(), int.Parse(cbxHocKy.SelectedValue.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("Thêm chương trình - môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
