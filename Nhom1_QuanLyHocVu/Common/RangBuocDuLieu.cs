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

        public static int RangBuocDamBaoGioDay(string MaGiaoVien, string MaThu, string MaKhoaHoc, string MaMonHoc, string MaPhong)
        {
            using (var db = new QuanLyHocVuEntities())
            {
                //var khoaHoc = db.MONHOCs.Find(MaMonHoc);
                //var hocKi = MaMonHoc.W
                var khoaHoc = db.KHOAHOCs.Find(MaKhoaHoc);
                var maChuongTrinh = khoaHoc.CHUONGTRINH.MaChuongTrinh;

                var ctmh = db.CHUONGTRINHMONHOCs.Where(x => x.MaChuongTrinh == maChuongTrinh && x.MaMonHoc == MaMonHoc).FirstOrDefault();
                var hocki = (double)(ctmh.HocKy/2) +  khoaHoc.NamBatDau;
                
                var khmDaCoGV = db.KHOAHOCMONs.Where(x => x.MaThu == MaThu && x.MaGiaoVien_day == MaGiaoVien).ToList();
                var khmDaCoPhong = db.KHOAHOCMONs.Where(x => x.MaThu == MaThu && x.MaPhong == MaPhong).ToList();

                foreach ( var khm in khmDaCoGV)
                {
                    string maMon = khm.MaMonHoc;
                    var ctmhDaCo = khm.KHOAHOC.CHUONGTRINH.CHUONGTRINHMONHOCs.Where(x => x.MaMonHoc == maMon).FirstOrDefault();
                    if(ctmhDaCo != null)
                    {
                        var hocKiDaCo = (double)(ctmhDaCo.HocKy /2) + khm.KHOAHOC.NamBatDau;
                        if(hocki == hocKiDaCo)
                            return -1;
                    }
                  
                }

                foreach (var khm in khmDaCoPhong)
                {
                    string maMon = khm.MaMonHoc;
                    var ctmhDaCo = khm.KHOAHOC.CHUONGTRINH.CHUONGTRINHMONHOCs.Where(x => x.MaMonHoc == maMon).FirstOrDefault();
                    if (ctmhDaCo != null)
                    {
                        var hocKiDaCo = (double)(ctmhDaCo.HocKy / 2) + khm.KHOAHOC.NamBatDau;
                        if (hocki == hocKiDaCo)
                            return -2;
                    }

                }

            }
            return 1;
        }
    }
}
