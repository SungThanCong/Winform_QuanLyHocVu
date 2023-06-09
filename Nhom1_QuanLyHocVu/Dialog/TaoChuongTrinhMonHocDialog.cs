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
    public partial class TaoChuongTrinhMonHocDialog : Form
    {
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();
        public TaoChuongTrinhMonHocDialog()
        {
            InitializeComponent();
            RenderMaMonHoc();
        }

        public TaoChuongTrinhMonHocDialog(string MaChuongTrinh, string HocKi)
        {
            InitializeComponent();
            RenderMaMonHoc();

            cbxMaChuongTrinh.Text = MaChuongTrinh;
            txtHocKi.Text = HocKi;

        }
        public TaoChuongTrinhMonHocDialog(string MaChuongTrinh,string MaMonHoc, string HocKi)
        {
            InitializeComponent();

            RenderMaMonHoc();

            cbxMaChuongTrinh.Text = MaChuongTrinh;
            cbxMaMonHoc.Text = MaMonHoc;
            txtHocKi.Text = HocKi;

        }

     

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbxMaChuongTrinh.Text.Length > 0 && cbxMaMonHoc.Text.Length >0 && txtHocKi.Text.Length>0)
                DialogResult = DialogResult.OK;
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetMaMonHoc()
        {
            return cbxMaMonHoc.SelectedValue.ToString();
        }

        public string GetMaChuongTrinh()
        {
            return cbxMaChuongTrinh.SelectedValue.ToString();
        }

        private void RenderMaMonHoc()
        {
            cbxMaMonHoc.ValueMember = "MaMonHoc";
            cbxMaMonHoc.DisplayMember = "TenMonHoc";
            cbxMaMonHoc.DataSource = entities.MONHOCs.Select(x => new {x.MaMonHoc, x.TenMonHoc}).ToList()
                 .Where(x => RangBuocDuLieu.RangBuocMonHoc(x.MaMonHoc) == true).ToList();
            cbxMaMonHoc.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMaMonHoc.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbxMaChuongTrinh.DataSource = entities.CHUONGTRINHs.Select(x => x.MaChuongTrinh).ToList();
            cbxMaChuongTrinh.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxMaChuongTrinh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }

        private void cbxMaChuongTrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenChuongTrinh.Text = entities.CHUONGTRINHs.Find(cbxMaChuongTrinh.SelectedValue.ToString()).TenChuongTrinh;
        }

        public void SetChuongTrinhEnable(bool value)
        {
            cbxMaChuongTrinh.Enabled = value;
        }

        public void SetMonHocEnable(bool value)
        {
            cbxMaMonHoc.Enabled = value;
        }

   
    }
}
