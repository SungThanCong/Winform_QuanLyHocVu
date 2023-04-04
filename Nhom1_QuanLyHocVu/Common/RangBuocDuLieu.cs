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
        enum Ki
        {

        }
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

        public static bool RangBuocDamBaoGioDay(string MaGiaoVien, string MaThu, string MaKhoaHoc, string MaMonHoc, string MaPhong)
        {
            using (var db = new QuanLyHocVuEntities())
            {
                //var khoaHoc = db.MONHOCs.Find(MaMonHoc);
                //var hocKi = MaMonHoc.W
                var maChuongTrinh = db.KHOAHOCs.Find(MaKhoaHoc).CHUONGTRINH.MaChuongTrinh;

                var ctmh = db.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == maChuongTrinh && x.MaMonHoc == MaMonHoc).FirstOrDefault();
                var hocki = ctmh.HocKy;

                
                var khmDaCoGV = db.KHOAHOCMONs.Where(x => x.MaThu == MaThu && x.MaGiaoVien_day == MaGiaoVien).ToList();
                var khmDaCoPhong = db.KHOAHOCMONs.Where(x => x.MaThu == MaThu && x.MaPhong == MaPhong).ToList();


                foreach ( var khm in khmDaCoGV)
                {
                    string maMon = khm.MaMonHoc;
                    var ctmhDaCo = khm.KHOAHOC.CHUONGTRINH.CHUONGTRINHMONHOCs.Where(x => x.MaMonHoc == maMon).FirstOrDefault();
                    if(ctmhDaCo != null)
                    {
                        var hocKiDaCo = ctmhDaCo.HocKy;
                        if ((hocKiDaCo % 2) == (hocki % 2))
                            return false;
                    }
                  
                }

                foreach (var khm in khmDaCoPhong)
                {
                    string maMon = khm.MaMonHoc;
                    var ctmhDaCo = khm.KHOAHOC.CHUONGTRINH.CHUONGTRINHMONHOCs.Where(x => x.MaMonHoc == maMon).FirstOrDefault();
                    if (ctmhDaCo != null)
                    {
                        var hocKiDaCo = ctmhDaCo.HocKy;
                        if ((hocKiDaCo % 2) == (hocki % 2))
                            return false;
                    }

                }

            }
            return true;
        }
    }
}
