using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom1_QuanLyHocVu.Common
{
    public static class ListViewStyle
    {
        public static void HeaderStyle(DrawListViewColumnHeaderEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Center;

            e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.White, e.Bounds, stringFormat);
        }

        public static void ItemStyle(DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
