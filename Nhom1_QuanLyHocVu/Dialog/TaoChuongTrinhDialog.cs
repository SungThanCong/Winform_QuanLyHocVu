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
    public partial class TaoChuongTrinhDialog : Form
    {
        private string tenKhoa;
        QuanLyHocVuEntities entities = new QuanLyHocVuEntities();

        public TaoChuongTrinhDialog(string tenKhoa)
        {
            InitializeComponent();
            this.tenKhoa = tenKhoa;

            cbxGiamDocChuongTrinh.ValueMember = "MaGiaoVien";
            cbxGiamDocChuongTrinh.DisplayMember = "HoTen";
            cbxGiamDocChuongTrinh.DataSource = entities.GIAOVIENs.Select(x=> new {x.MaGiaoVien, x.HoTen}).ToList();

            txtTenKhoa.ValueMember = "MaKhoa";
            txtTenKhoa.DisplayMember = "TenKhoa";
            txtTenKhoa.DataSource = entities.KHOAs.Select(x => new { x.TenKhoa, x.MaKhoa }).ToList();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TaoChuongTrinhDialog_Load(object sender, EventArgs e)
        {
            txtTenKhoa.Text = tenKhoa;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
