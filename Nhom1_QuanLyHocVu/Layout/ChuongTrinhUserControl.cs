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
            var dsChuongTrinhMonHoc = entities.CHUONGTRINHs.ToList();


            // load data cho combobox
            cbxKhoaMonHoc.DisplayMember = "TenKhoa";
            cbxKhoaMonHoc.ValueMember = "MaKhoa";
            cbxKhoaMonHoc.DataSource = dsKhoa.Select(x => new {x.TenKhoa, x.MaKhoa}).ToList();
            cbxKhoaMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxKhoaMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbxTenChuongTrinh.ValueMember = "MaChuongTrinh";
            cbxTenChuongTrinh.DisplayMember = "TenChuongTrinh";
            cbxTenChuongTrinh.DataSource = dsChuongTrinhMonHoc.Select(x => new {x.MaChuongTrinh, x.TenChuongTrinh}).Distinct().ToList();
            cbxTenChuongTrinh.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxTenChuongTrinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;



            ////load data ban đầu cho 2 listview
            //var selectedKhoa = dsKhoa.Count > 0 ? dsKhoa.ElementAt(0) : null;
            //var selectedChuongTrinhMonHoc = dsChuongTrinhMonHoc.Count > 0 ? dsChuongTrinhMonHoc.ElementAt(0) : null;


        }

        private void cbxTenChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxTenChuongTrinh.SelectedIndex >= 0)
            {
                cbxHocKy.Text = "";

                using (var db = new QuanLyHocVuEntities())
                {
                    var chuongTrinhMonHoc = db.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == cbxTenChuongTrinh.SelectedValue).ToList();
                    cbxHocKy.DataSource = chuongTrinhMonHoc.Select(x => x.HocKy).Distinct().OrderBy(x => x.Value).ToList();

                    if (cbxHocKy.Items.Count < 1)
                    {
                        lsvChuongTrinhMonHoc.Items.Clear();
                    }
                }
              
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
            using (var db = new QuanLyHocVuEntities())
            {
                var chuongTrinh = db.CHUONGTRINHs.Find(cbxTenChuongTrinh.SelectedValue);
                if (chuongTrinh != null)
                {
                    LoadChuongTrinhMonHocListView(cbxTenChuongTrinh.SelectedValue.ToString(), int.Parse(value + ""));
                }
            }

           
        }

        private void cbxKhoaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbx = (ComboBox)sender;
            var value = cbx.SelectedValue;
            using (var db = new QuanLyHocVuEntities())
            {
                var khoa = db.KHOAs.Find(value);
                if (khoa != null)
                {
                    LoadChuongTrinhListView(khoa.MaKhoa);
                }
            }
            
        }

        private void LoadChuongTrinhListView(string maKhoa)
        {
            lsvChuongTrinh.Items.Clear();
            using(var db = new QuanLyHocVuEntities())
            {
                var chuongTrinhs = db.CHUONGTRINHs.Where(x => x.MaKhoa == maKhoa).ToList();
                foreach (var chuongTrinh in chuongTrinhs)
                {

                    ListViewItem item = new ListViewItem(chuongTrinh.MaChuongTrinh);
                    item.SubItems.Add(chuongTrinh.TenChuongTrinh);
                    item.SubItems.Add(chuongTrinh.MaBacHoc);

                    item.SubItems.Add(chuongTrinh.KHOA.TenKhoa);
                    item.SubItems.Add(chuongTrinh.GIAOVIEN.HoTen);

                    lsvChuongTrinh.Items.Add(item);
                }
            }
            
        
         
        }

        private void LoadChuongTrinhMonHocListView(string maChuongTrinh, int hocKy)
        {
            lsvChuongTrinhMonHoc.Items.Clear();
            using (var db = new QuanLyHocVuEntities())
            {
                var chuongTrinhMonHocs = db.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == maChuongTrinh && x.HocKy.Value == hocKy).ToList();
                foreach (var CTMonHoc in chuongTrinhMonHocs)
                {
                    ListViewItem item = new ListViewItem(CTMonHoc.MaChuongTrinh);
                    item.SubItems.Add(CTMonHoc.CHUONGTRINH.TenChuongTrinh);
                    item.SubItems.Add(CTMonHoc.MONHOC.MaMonHoc);
                    item.SubItems.Add(CTMonHoc.MONHOC.TenMonHoc);
                    item.SubItems.Add(CTMonHoc.HocKy.Value + "");

                    lsvChuongTrinhMonHoc.Items.Add(item);
                }
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
                    using (var db = new QuanLyHocVuEntities())
                    {
                        try
                        {

                            CHUONGTRINH chuongTrinh = new CHUONGTRINH();
                            chuongTrinh.MaKhoa = cbxKhoaMonHoc.SelectedValue.ToString();
                            chuongTrinh.MaGiaoVien_GiamDocCT = dialog.cbxGiamDocChuongTrinh.SelectedValue.ToString();
                            chuongTrinh.MaChuongTrinh = dialog.txtMaChuongTrinh.Text;
                            chuongTrinh.TenChuongTrinh = dialog.txtTenChuongTrinh.Text;
                            chuongTrinh.MaBacHoc = dialog.txtBacHoc.Text;

                            db.CHUONGTRINHs.Add(chuongTrinh);
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Thêm chương trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadChuongTrinhListView(chuongTrinh.MaKhoa);
                            }
                            else
                            {
                                MessageBox.Show("Thêm chương trình không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        private void lsvChuongTrinh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TaoChuongTrinhDialog dialog = new TaoChuongTrinhDialog(cbxKhoaMonHoc.Text);
            dialog.txtMaChuongTrinh.ReadOnly = true;
            dialog.txtTenKhoa.Enabled = true;
            dialog.txtMaChuongTrinh.Text = lsvChuongTrinh.SelectedItems[0].SubItems[0].Text;
            dialog.txtTenChuongTrinh.Text = lsvChuongTrinh.SelectedItems[0].SubItems[1].Text;
            dialog.cbxGiamDocChuongTrinh.Text = lsvChuongTrinh.SelectedItems[0].SubItems[4].Text;
            dialog.txtBacHoc.Text = lsvChuongTrinh.SelectedItems[0].SubItems[2].Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using(var db = new QuanLyHocVuEntities())
                {
                    try
                    {
                        CHUONGTRINH chuongTrinh = db.CHUONGTRINHs.Find(dialog.txtMaChuongTrinh.Text);

                        chuongTrinh.MaKhoa = dialog.txtTenKhoa.SelectedValue.ToString();
                        chuongTrinh.TenChuongTrinh = dialog.txtTenChuongTrinh.Text;
                        chuongTrinh.MaBacHoc = dialog.txtBacHoc.Text;
                        chuongTrinh.MaGiaoVien_GiamDocCT = dialog.cbxGiamDocChuongTrinh.SelectedValue.ToString();

                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Sửa chương trình thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChuongTrinhListView(cbxKhoaMonHoc.SelectedValue.ToString());
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
        }

        private void btnThemCTMonHoc_Click(object sender, EventArgs e)
        {
                string maCT = cbxTenChuongTrinh.SelectedValue.ToString();
                var chuongTrinh = entities.CHUONGTRINHs.Find(maCT);

                TaoChuongTrinhMonHocDialog dialog = new TaoChuongTrinhMonHocDialog(chuongTrinh.MaChuongTrinh,
                     cbxHocKy.SelectedValue.ToString());
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    CHUONGTRINHMONHOC CTMH = new CHUONGTRINHMONHOC();
                    CTMH.MaMonHoc = dialog.GetMaMonHoc();
                    CTMH.MaChuongTrinh = dialog.GetMaChuongTrinh();
                    CTMH.HocKy = int.Parse(cbxHocKy.SelectedValue.ToString());


                    using (var db = new QuanLyHocVuEntities())
                    {
                        db.CHUONGTRINHMONHOCs.Add(CTMH);
                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm chương trình - môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChuongTrinhMonHocListView(maCT, CTMH.HocKy.Value);

                        }
                        else
                        {
                            MessageBox.Show("Thêm chương trình - môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
          
        }

        private void lsvChuongTrinhMonHoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string maCT = lsvChuongTrinhMonHoc.SelectedItems[0].SubItems[0].Text;
            string maMH = lsvChuongTrinhMonHoc.SelectedItems[0].SubItems[2].Text;
            using(var db = new QuanLyHocVuEntities())
            {
                CHUONGTRINHMONHOC chuongTrinh = db.CHUONGTRINHMONHOCs.Where(x =>
               x.MaChuongTrinh == maCT &&
                x.MaMonHoc == maMH).FirstOrDefault();

                TaoChuongTrinhMonHocDialog dialog = new TaoChuongTrinhMonHocDialog(chuongTrinh.CHUONGTRINH.TenChuongTrinh,
                   chuongTrinh.MONHOC.TenMonHoc, chuongTrinh.HocKy.Value.ToString());

                //dialog.SetChuongTrinhEnable(false);
                //dialog.SetMonHocEnable(false);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        chuongTrinh.HocKy = int.Parse(dialog.txtHocKi.Text);

                        int result = db.SaveChanges();
                        if (result > 0)
                        {
                            MessageBox.Show("Sửa chương trình - môn học thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadChuongTrinhMonHocListView(cbxTenChuongTrinh.SelectedValue.ToString(), int.Parse(cbxHocKy.SelectedValue.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("Sửa chương trình - môn học không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            
        }

        private void btnXoaChuongTrinh_Click(object sender, EventArgs e)
        {
            if (lsvChuongTrinh.SelectedItems.Count > 0) // kiểm tra xem có dòng được chọn hay không
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    using(var db = new QuanLyHocVuEntities())
                    {
                        string maCT = lsvChuongTrinh.SelectedItems[0].SubItems[0].Text;
                        var chuongTrinh = db.CHUONGTRINHs.Find(maCT);

                        db.CHUONGTRINHs.Remove(chuongTrinh);
                        try
                        {
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadChuongTrinhListView(cbxKhoaMonHoc.SelectedValue.ToString());

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

        private void btnXoaChuongTrinhMonHoc_Click(object sender, EventArgs e)
        {
            if (lsvChuongTrinhMonHoc.SelectedItems.Count > 0) // kiểm tra xem có dòng được chọn hay không
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                {
                    using(var db = new QuanLyHocVuEntities())
                    {
                        string maCT = lsvChuongTrinhMonHoc.SelectedItems[0].SubItems[0].Text;
                        string maMH = lsvChuongTrinhMonHoc.SelectedItems[0].SubItems[2].Text;

                        var chuongTrinh = db.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == maCT && x.MaMonHoc == maMH).FirstOrDefault();

                        if (chuongTrinh != null)
                            db.CHUONGTRINHMONHOCs.Remove(chuongTrinh);
                        try
                        {
                            int result = db.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadChuongTrinhMonHocListView(cbxTenChuongTrinh.SelectedValue.ToString(), int.Parse(cbxHocKy.SelectedValue.ToString()));

                            }
                            else
                            {
                                MessageBox.Show("Dữ liệu không đang được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Dữ liệu đang được sử dụng. Error:" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn dòng dữ liệu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lsvChuongTrinhMonHoc_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ListViewStyle.HeaderStyle(e);
        }

        private void lsvChuongTrinhMonHoc_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            ListViewStyle.ItemStyle(e);
        }
    }
}
