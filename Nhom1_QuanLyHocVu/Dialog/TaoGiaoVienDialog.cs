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
    public partial class TaoGiaoVienDialog : Form
    {
        QuanLyHocVuEntities QuanLyHocVuEntities = new QuanLyHocVuEntities();

        public TaoGiaoVienDialog()
        {
            InitializeComponent();

            RenderData();
        }

        private void RenderData()
        {
            var dsMaKhoa = QuanLyHocVuEntities.KHOAs.Select(x => x.MaKhoa).ToList();
            cboMaKhoaTaoGV.DataSource = dsMaKhoa;
            cboMaKhoaTaoGV.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboMaKhoaTaoGV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnXacNhanTaoGV_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
       
        }

        private void btnHuyTaoGV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
