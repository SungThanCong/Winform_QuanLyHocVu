using Nhom1_QuanLyHocVu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom1_QuanLyHocVu.Common
{
    public static class RangBuocDuLieu
    {
        public static bool RangBuocMonHoc(string MaMon)
        {
            using(var db = new QuanLyHocVuEntities())
            {
                var damNhiemMons = db.DAMNHIEMMONs.Where(x => x.MaMonHoc == MaMon).ToList();
                if(damNhiemMons.Count < 2) return false;

                var checkDamNhiemChinh = damNhiemMons.Where(x => x.CoLaDamNhiemChinh == 1).ToList();
                if (checkDamNhiemChinh.Count < 1) return false;
            }
            return true;
        }

        public static bool RangBuocDamBaoGioDay(string MaGiaoVien, string MaThu)
        {
            using (var db = new QuanLyHocVuEntities())
            {
                var check = db.KHOAHOCMONs.Where(x => x.MaThu == MaThu && x.MaGiaoVien_day == MaGiaoVien).FirstOrDefault();
                if (check != null) return false;
            }
            return true;
        }
    }
}
