namespace POSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Experience_Layer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Experience_Layer.svc or Experience_Layer.svc.cs at the Solution Explorer and start debugging.
    public class Experience_Layer : IExperience_Layer
    {
        Task_Layer Task_Layer;
        System_Layer System_Layer;
        public Experience_Layer()
        {
            Task_Layer = new Task_Layer();
            System_Layer = new System_Layer();
        }

        public void DoWork()
        {
        }

        public HoaDon ThanhToanHoaDon(int idhoadon, byte phuongthucthanhtoan, bool guimail)
        {
            HoaDon hoaDonMoi;
            bool thanhtoanthanhcong;
            if (phuongthucthanhtoan == 0)
            {
                thanhtoanthanhcong = Task_Layer.ThanhToanTienMat(idhoadon);
            }
            if (phuongthucthanhtoan == 1)
            {
                thanhtoanthanhcong = Task_Layer.ThanhToanBangThe(idhoadon);
            }
            if (guimail == true)
            {
                Task_Layer.GuiMail(idhoadon);
            }
            else
            {
                System_Layer.UpdateMailToHoaDon(idhoadon, false);
            }
            hoaDonMoi = System_Layer.TaoHoaDonMoi();
            return hoaDonMoi;
        }

        public HoaDon ThemSanPhamVaoHoaDon(int idhoadon, int idsanpham, int soluong)
        {
            HoaDon hoaDon;
            Task_Layer.AddHoaDonItem(idhoadon, idsanpham, soluong);
            Task_Layer.UpdateTongTienHoaDon(idhoadon);
            hoaDon = System_Layer.GetHoaDonInfor(idhoadon);
            return hoaDon;
        }

        public HoaDon XoaSanPhamKhoiHoaDon(int idhoadon, int idsanpham)
        {
            int soluong;
            HoaDon hoaDons;
            soluong = System_Layer.CountHoaDonOfSingleItem(idhoadon, idsanpham);
            if (soluong > 1)
            {
                System_Layer.UpdateHoaDonItem(idhoadon, idsanpham);
            }
            else
            {
                System_Layer.RemoveHoaDonItem(idhoadon, idsanpham);
            }
            
            Task_Layer.UpdateTongTienHoaDon(idhoadon);
            hoaDons = System_Layer.GetHoaDonInfor(idhoadon);
            return hoaDons;
        }
    }
}
