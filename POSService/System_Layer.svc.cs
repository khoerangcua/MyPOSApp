
using System;
using System.Collections.Generic;
using System.Linq;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "System_Layer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select System_Layer.svc or System_Layer.svc.cs at the Solution Explorer and start debugging.
    public class System_Layer : ISystem_Layer
    {
        public bool AddNewKhachHang(KhachHang khachhang)
        {
            bool themthanhcong = false;
            using (POSEntities db = new POSEntities())
            {
                db.tbl_khachhang.Add(new tbl_khachhang
                {
                    idkhachhang = khachhang.IdKhachHang,
                    tenkhachhang = khachhang.TenKhachHang,
                    diachi = khachhang.DiaChi,
                    emai = khachhang.Email,
                    sodienthoai = khachhang.SoDienThoai,
                    diachianh = khachhang.DiaChiAnh
                });
                themthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            return themthanhcong;
        }

        public int CountHoaDonOfSingleItem(int idhoadon, int idsanpham)
        {
            int soluong = 0;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_chitiethoadon.FirstOrDefault(ct => ct.idhoadon == idhoadon && ct.idhanghoa == idsanpham);
                soluong = r.soluong.GetValueOrDefault();
            }
            return soluong;
        }

        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public List<DanhMucSanPham> GetDanhMucSanPham()
        {
            List<DanhMucSanPham> danhMucSanPhams = new List<DanhMucSanPham>();
            using (POSEntities db = new POSEntities())
            {
                var danhmucs_r = db.tbl_danhmuchanghoa.Select(p => p);
                foreach (var item in danhmucs_r)
                {
                    danhMucSanPhams.Add(new DanhMucSanPham(item.iddanhmuc, item.tendanhmuc));
                }
            }
            return danhMucSanPhams;
        }

        public GiamGia GetDiscount(int idsanpham)
        {
            GiamGia giamGia;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_giamgia.FirstOrDefault(gg => gg.idhanghoa == idsanpham && gg.ngaybatdau <= DateTime.Now && gg.ngayketthuc >= DateTime.Now);
                if (r == default)
                {
                    giamGia = new GiamGia(0, DateTime.Now, DateTime.Now, 0, idsanpham);
                }
                else
                {
                    giamGia = new GiamGia(r.idgiamgia, r.ngaybatdau, r.ngayketthuc, 1 - r.phantramgiam, r.idhanghoa);
                }

            }
            return giamGia;
        }

        public HoaDon GetHoaDonInfor(int idhoadon)
        {
            HoaDon hoaDon;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                hoaDon = new HoaDon(r.idhoadon, r.ngaylap, r.tongtien, r.idkhachhang, r.phuongthucthanhtoan, r.trangthaithanhtoan, r.mail);
            }
            return hoaDon;
        }

        public List<ChiTietHoaDon> GetHoaDonItems(int idhoadon)
        {
            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_chitiethoadon.Where(cthd => cthd.idhoadon == idhoadon);
                foreach (var item in r)
                {
                    chiTietHoaDons.Add(new ChiTietHoaDon(item.idchitiethoadon, item.soluong, item.tongcong, item.dongia, item.phantramgiam, item.idhoadon, item.idhanghoa));
                }
            }
            return chiTietHoaDons;
        }

        public KhachHang GetKhachHangById(int idkhachang)
        {
            KhachHang khachHang;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_khachhang.FirstOrDefault(kh => kh.idkhachhang == idkhachang);
                khachHang = new KhachHang(r.idkhachhang, r.tenkhachhang, r.emai, r.sodienthoai, r.diachi, r.diachianh);
            }
            return khachHang;
        }

        public KhachHang GetKhachHangByNumPhone(string numphone)
        {
            KhachHang khachHang;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_khachhang.FirstOrDefault(kh => String.Compare(kh.sodienthoai, numphone) == 0);
                if (r == default)
                {
                    khachHang = new KhachHang(0, "", "", "", "", "https://media.defense.gov/2020/Feb/19/2002251686/700/465/0/200219-A-QY194-002.JPG");
                }
                else
                {
                    khachHang = new KhachHang(r.idkhachhang, r.tenkhachhang, r.emai, r.sodienthoai, r.diachi, r.diachianh);
                }

            }
            return khachHang;
        }

        public SanPham GetSanPham(int idsanpham)
        {
            SanPham sanPham;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hanghoa.FirstOrDefault(hh => hh.idhanghoa == idsanpham);
                sanPham = new SanPham(r.idhanghoa, r.tenhanghoa, r.dongia, r.diachianh, r.iddanhmuc);
            }
            return sanPham;
        }

        public List<SanPham> GetSanPhams(int iddanhmucsanpham)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hanghoa.Where(hh => hh.iddanhmuc == iddanhmucsanpham);
                foreach (var item in r)
                {
                    sanPhams.Add(new SanPham(item.idhanghoa, item.tenhanghoa, item.dongia, item.diachianh, item.iddanhmuc));
                }
            }
            return sanPhams;
        }

        public bool QuetTheAPI()
        {
            return true;
        }

        public bool RemoveHoaDonItem(int idhoadon, int idsanpham)
        {
            bool xoathanhcong = false;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_chitiethoadon.FirstOrDefault(ct => ct.idhoadon == idhoadon && ct.idhanghoa == idsanpham);
                db.tbl_chitiethoadon.Remove(r);
                xoathanhcong = db.SaveChanges() >= 1 ? true : false;
            }

            return xoathanhcong;

        }

        public bool SendMailAPI(HoaDon hoadon, KhachHang khachhang, List<ChiTietHoaDon> hoadonitems)
        {
            return true;
        }

        public HoaDon TaoHoaDonMoi()
        {
            HoaDon hoadonmoi;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.Add(new tbl_hoadon() { ngaylap = DateTime.Now });
                db.SaveChanges();
                hoadonmoi = new HoaDon(r.idhoadon, r.ngaylap, r.tongtien, r.idkhachhang, r.phuongthucthanhtoan, r.trangthaithanhtoan, r.mail);
            }
            return hoadonmoi;
        }

        public bool UpdateHoaDonItem(int idhoadon, int idsanpham)
        {
            bool capnhatthanhcong = false;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_chitiethoadon.FirstOrDefault(ct => ct.idhoadon == idhoadon && ct.idhanghoa == idsanpham);
                r.soluong = r.soluong - 1;
                r.tongcong = r.dongia * r.phantramgiam * r.soluong;
                capnhatthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            return capnhatthanhcong;
        }

        public bool UpdateKhachHangToHoaDon(int idhoadon, int idkhachhang)
        {
            bool capnhatthanhcong = false;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                r.idkhachhang = idkhachhang;
                capnhatthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            return capnhatthanhcong;
        }

        public bool UpdateMailToHoaDon(int idhoadon, bool trangthai)
        {
            bool capnhatthanhcong = false;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                r.mail = trangthai;
                capnhatthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            return capnhatthanhcong;
        }

        public bool UpdateStateToHoaDon(int idhoadon, bool trangthai)
        {
            bool thanhtoanthanhcong = false;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                r.trangthaithanhtoan = trangthai;
                thanhtoanthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            return thanhtoanthanhcong;
        }
    }
}
