//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSService
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_chitiethoadon
    {
        public int idchitiethoadon { get; set; }
        public Nullable<int> soluong { get; set; }
        public Nullable<double> tongcong { get; set; }
        public Nullable<double> dongia { get; set; }
        public Nullable<double> phantramgiam { get; set; }
        public Nullable<int> idhoadon { get; set; }
        public Nullable<int> idhanghoa { get; set; }
    
        public virtual tbl_hanghoa tbl_hanghoa { get; set; }
        public virtual tbl_hoadon tbl_hoadon { get; set; }
    }
}
