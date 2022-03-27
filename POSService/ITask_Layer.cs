using System.ServiceModel;

namespace POSService
{
    #region ServiceContract
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITask_Layer" in both code and config file together.
    [ServiceContract]
    public interface ITask_Layer
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        bool AddHoaDonItem(int idhoadon, int idsanpham, int soluong);
        [OperationContract]
        bool UpdateTongTienHoaDon(int idhoadon);
        [OperationContract]
        bool ThanhToanTienMat(int idhoadon);
        [OperationContract]
        bool ThanhToanBangThe(int idhoadon);
        [OperationContract]
        bool GuiMail(int idhoadon);
    }
    #endregion


}
