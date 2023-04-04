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
    public partial class TaoDamNhiemMon : Form
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public TaoDamNhiemMon()
        {
            InitializeComponent();

            RenderData();
        }

        public TaoDamNhiemMon(string TenMonHoc, string TenChuongTrinh, string TenGiaoVien, string CoLaDamNhiemChinh)
        {
            InitializeComponent();

            RenderData();

            txtGiaoVien.Text = TenGiaoVien;
            txtMonHoc.Text = TenMonHoc;
            txtChuongTrinh.Text = TenChuongTrinh;
            ckbDamNhiemChinh.Checked =  CoLaDamNhiemChinh == "1" ?  true : false;
        }

        private void RenderData()
        {
            txtGiaoVien.DisplayMember = "HoTen";
            txtGiaoVien.ValueMember = "MaGiaoVien";
            txtGiaoVien.DataSource = entities.GIAOVIENs.Select(x => new {x.HoTen, x.MaGiaoVien}).ToList();
            txtGiaoVien.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtGiaoVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txtChuongTrinh.DisplayMember = "TenChuongTrinh";
            txtChuongTrinh.ValueMember = "MaChuongTrinh";
            txtChuongTrinh.DataSource = entities.CHUONGTRINHs.Select(x=>new { x.MaChuongTrinh, x.TenChuongTrinh}).ToList();
            txtChuongTrinh.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtChuongTrinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            txtMonHoc.DisplayMember = "TenMonHoc";
            txtMonHoc.ValueMember = "MaMonHoc";
            txtMonHoc.DataSource = entities.MONHOCs.Select(x=>new {x.TenMonHoc, x.MaMonHoc}).ToList();
            txtMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetMonHocEnable(bool value)
        {
            txtMonHoc.Enabled = value;

        }
        public void SetGiaoVienEnable(bool value)
        {
            txtGiaoVien.Enabled = value;

        }
        public void SetChuongTrinhEnable(bool value)
        {
            txtChuongTrinh.Enabled = value;

        }

        private void txtGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
