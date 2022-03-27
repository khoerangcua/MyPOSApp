using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISystem_Layer" in both code and config file together.
    [ServiceContract]
    public interface ISystem_Layer
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool QuetTheAPI();

        [OperationContract]
        List<DanhMucSanPham> GetDanhMucSanPham();

        [OperationContract]
        List<SanPham> GetSanPhams(int iddanhmucsanpham);

        [OperationContract]
        SanPham GetSanPham(int idsanpham);

        [OperationContract]
        GiamGia GetDiscount(int idsanpham);

        [OperationContract]
        List<ChiTietHoaDon> GetHoaDonItems(int idhoadon);

        [OperationContract]
        HoaDon GetHoaDonInfor(int idhoadon);

        [OperationContract]
        int CountHoaDonOfSingleItem(int idhoadon, int idsanpham);

        [OperationContract]
        bool RemoveHoaDonItem(int idhoadon, int idsanpham);

        [OperationContract]
        bool UpdateHoaDonItem(int idhoadon, int idsanpham);

        [OperationContract]
        KhachHang GetKhachHangByNumPhone(string numphone);

        [OperationContract]
        bool AddNewKhachHang(KhachHang khachhang);

        [OperationContract]
        bool UpdateKhachHangToHoaDon(int idhoadon, int idkhachhang);

        [OperationContract]
        bool UpdateStateToHoaDon(int idhoadon, bool trangthai);

        [OperationContract]
        bool UpdateMailToHoaDon(int idhoadon, bool trangthai);

        [OperationContract]
        KhachHang GetKhachHangById(int idkhachang);

        [OperationContract]
        bool SendMailAPI(HoaDon hoadon, KhachHang khachhang, List<ChiTietHoaDon> hoadonitems);

        [OperationContract]
        HoaDon TaoHoaDonMoi();
    }
    #region DataContract
    [DataContract]
    public class DanhMucSanPham
    {
        int idDanhMuc;
        string tenDanhMuc;

        public DanhMucSanPham(int idDanhMuc, string tenDanhMuc)
        {
            this.IdDanhMuc = idDanhMuc;
            this.TenDanhMuc = tenDanhMuc;
        }

        public int IdDanhMuc { get => idDanhMuc; set => idDanhMuc = value; }
        public string TenDanhMuc { get => tenDanhMuc; set => tenDanhMuc = value; }
    }

    [DataContract]
    public class SanPham
    {

        int idHangHoa;
        string tenHangHoa;
        double donGia;
        string diaChiAnh;
        int idDanhMuc;

        public SanPham(int idHangHoa, string tenHangHoa, double donGia, string diaChiAnh, int idDanhMuc)
        {
            this.IdHangHoa = idHangHoa;
            this.TenHangHoa = tenHangHoa;
            this.DonGia = donGia;
            this.DiaChiAnh = diaChiAnh;
            this.IdDanhMuc = idDanhMuc;
        }

        public SanPham(int idhanghoa, string tenhanghoa, double? dongia, string diachianh, int? iddanhmuc)
        {
            idHangHoa = idhanghoa;
            tenHangHoa = tenhanghoa;
            Dongia = dongia;
            diaChiAnh = diachianh;
            Iddanhmuc = iddanhmuc;
        }

        public int IdHangHoa { get => idHangHoa; set => idHangHoa = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double? Dongia { get; }
        public string DiaChiAnh { get => diaChiAnh; set => diaChiAnh = value; }
        public int IdDanhMuc { get => idDanhMuc; set => idDanhMuc = value; }
        public int? Iddanhmuc { get; }
    }

    [DataContract]
    public class GiamGia
    {
        int idGiamGia;

        private DateTime? ngaybatdau;

        private DateTime? ngayketthuc;


        private int? idhanghoa;
        private double? phantramgiam;


        public GiamGia(int idgiamgia, DateTime? ngaybatdau, DateTime? ngayketthuc, double? phantramgiam, int? idhanghoa)
        {
            idGiamGia = idgiamgia;
            this.Ngaybatdau = ngaybatdau;
            this.Ngayketthuc = ngayketthuc;
            this.Phantramgiam = phantramgiam;
            this.Idhanghoa = idhanghoa;
        }

        public int IdGiamGia { get => idGiamGia; set => idGiamGia = value; }
        public DateTime? Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime? Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public int? Idhanghoa { get => idhanghoa; set => idhanghoa = value; }
        public double? Phantramgiam { get => phantramgiam; set => phantramgiam = value; }
    }

    [DataContract]
    public class ChiTietHoaDon
    {
        int idChiTietHoaDon;

        private int? soluong;

        private double? tongcong;

        private double? dongia;

        private double? phantramgiam;

        private int? idhoadon;

        private int? idhanghoa;



        public ChiTietHoaDon(int idchitiethoadon, int? soluong, double? tongcong, double? dongia, double? phantramgiam, int? idhoadon, int? idhanghoa)
        {
            idChiTietHoaDon = idchitiethoadon;
            this.Soluong = soluong;
            this.Tongcong = tongcong;
            this.Dongia = dongia;
            this.Phantramgiam = phantramgiam;
            this.Idhoadon = idhoadon;
            this.Idhanghoa = idhanghoa;

        }

        public int IdChiTietHoaDon { get => idChiTietHoaDon; set => idChiTietHoaDon = value; }
        public int? Soluong { get => soluong; set => soluong = value; }
        public double? Tongcong { get => tongcong; set => tongcong = value; }
        public double? Dongia { get => dongia; set => dongia = value; }
        public double? Phantramgiam { get => phantramgiam; set => phantramgiam = value; }
        public int? Idhoadon { get => idhoadon; set => idhoadon = value; }
        public int? Idhanghoa { get => idhanghoa; set => idhanghoa = value; }
    }

    [DataContract]
    public class HoaDon
    {
        int idHoaDon;

        private DateTime? ngaylap;

        private double? tongtien;

        private int? idkhachhang;

        private byte? phuongthucthanhtoan;

        private bool? trangthaithanhtoan;

        private bool? mail1;



        public HoaDon(int idhoadon, DateTime? ngaylap, double? tongtien, int? idkhachhang, byte? phuongthucthanhtoan, bool? trangthaithanhtoan, bool? mail1)
        {
            idHoaDon = idhoadon;
            this.Ngaylap = ngaylap;
            this.Tongtien = tongtien;
            this.Idkhachhang = idkhachhang;
            this.Phuongthucthanhtoan = phuongthucthanhtoan;
            this.Trangthaithanhtoan = trangthaithanhtoan;
            this.mail1 = mail1;
        }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public DateTime? Ngaylap { get => ngaylap; set => ngaylap = value; }
        public bool? Mail { get => mail1; set => mail1 = value; }
        public double? Tongtien { get => tongtien; set => tongtien = value; }
        public int? Idkhachhang { get => idkhachhang; set => idkhachhang = value; }
        public byte? Phuongthucthanhtoan { get => phuongthucthanhtoan; set => phuongthucthanhtoan = value; }
        public bool? Trangthaithanhtoan { get => trangthaithanhtoan; set => trangthaithanhtoan = value; }
    }

    [DataContract]
    public class KhachHang
    {
        int idKhachHang;
        string tenKhachHang;
        string email;
        string soDienThoai;
        string diaChi;
        string diaChiAnh;

        public KhachHang(int idKhachHang, string tenKhachHang, string email, string soDienThoai, string diaChi, string diaChiAnh)
        {
            this.IdKhachHang = idKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.Email = email;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
            this.DiaChiAnh = diaChiAnh;
        }

        public int IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string Email { get => email; set => email = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DiaChiAnh { get => diaChiAnh; set => diaChiAnh = value; }
    }
    #endregion
}
