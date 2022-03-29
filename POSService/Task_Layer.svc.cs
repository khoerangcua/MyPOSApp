
using System.Collections.Generic;
using System.Linq;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Task_Layer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Task_Layer.svc or Task_Layer.svc.cs at the Solution Explorer and start debugging.
    public class Task_Layer : ITask_Layer
    {
        System_Layer System_Layer;
        public Task_Layer()
        {
            this.System_Layer = new System_Layer();
        }

        public bool AddHoaDonItem(int idhoadon, int idsanpham, int soluong)
        {
            bool themthanhcong = false;
            SanPham sanPham;
            GiamGia giamGia;
            sanPham = System_Layer.GetSanPham(idsanpham);
            giamGia = System_Layer.GetDiscount(idsanpham);
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_chitiethoadon.FirstOrDefault(cthd => cthd.idhoadon == idhoadon && cthd.idhanghoa == idsanpham);
                if (r!=default)
                {
                    r.soluong++;
                    r.tongcong = r.dongia * (1 - r.phantramgiam) * r.soluong;
                }
                else
                {
                    db.tbl_chitiethoadon.Add(new tbl_chitiethoadon
                    {
                        idchitiethoadon = 0,
                        dongia = sanPham.Dongia,
                        tongcong = sanPham.Dongia * soluong * (1 - giamGia.Phantramgiam),
                        idhanghoa = sanPham.IdHangHoa,
                        soluong = soluong,
                        idhoadon = idhoadon,
                        phantramgiam = giamGia.Phantramgiam,
                    });
                }
               
                themthanhcong = db.SaveChanges() >= 1 ? true : false;
            }

            return themthanhcong;
        }

        public void DoWork()
        {
        }

        public bool GuiMail(int idhoadon)
        {
            bool guimailthanhcong, updatemailtohoadonthanhcong = false;
            HoaDon hoaDon;
            List<ChiTietHoaDon> chiTietHoaDons;
            KhachHang khachHang;

            hoaDon = System_Layer.GetHoaDonInfor(idhoadon);
            khachHang = System_Layer.GetKhachHangById(hoaDon.Idkhachhang.GetValueOrDefault());
            chiTietHoaDons = System_Layer.GetHoaDonItems(idhoadon);
            guimailthanhcong = System_Layer.SendMailAPI(hoaDon, khachHang, chiTietHoaDons);
            updatemailtohoadonthanhcong = System_Layer.UpdateMailToHoaDon(idhoadon, true);
            return guimailthanhcong;
        }

        public bool ThanhToanBangThe(int idhoadon)
        {
            bool thanhtoanthanhcong, thanhtoanbangthethanhcong, capnhatphuongthucthanhtoanthanhcong = false;

            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                r.phuongthucthanhtoan = 1;
                capnhatphuongthucthanhtoanthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            thanhtoanbangthethanhcong = System_Layer.QuetTheAPI();
            thanhtoanthanhcong = System_Layer.UpdateStateToHoaDon(idhoadon, true);
            return thanhtoanthanhcong && thanhtoanbangthethanhcong && capnhatphuongthucthanhtoanthanhcong;
        }

        public bool ThanhToanTienMat(int idhoadon)
        {
            bool thanhtoanthanhcong;
            bool capnhatphuongthucthanhtoanthanhcong;
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                r.phuongthucthanhtoan = 0;
                capnhatphuongthucthanhtoanthanhcong = db.SaveChanges() >= 1 ? true : false;
            }

            thanhtoanthanhcong = System_Layer.UpdateStateToHoaDon(idhoadon, true);
            return thanhtoanthanhcong && capnhatphuongthucthanhtoanthanhcong;
        }

        public bool UpdateTongTienHoaDon(int idhoadon)
        {
            List<ChiTietHoaDon> chiTietHoaDons;

            double total;
            bool capnhatthanhcong;

            chiTietHoaDons = System_Layer.GetHoaDonItems(idhoadon);
            total = chiTietHoaDons.Sum(ct => ct.Tongcong).GetValueOrDefault();
            using (POSEntities db = new POSEntities())
            {
                var r = db.tbl_hoadon.FirstOrDefault(hd => hd.idhoadon == idhoadon);
                r.tongtien = total;
                capnhatthanhcong = db.SaveChanges() >= 1 ? true : false;
            }
            return capnhatthanhcong;
        }
    }
}

