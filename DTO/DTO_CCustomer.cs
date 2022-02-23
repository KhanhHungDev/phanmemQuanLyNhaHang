using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CCustomer
    {
        //----Để tạo get và set cho các biến:
        /*
            1.Để dấu nháy ngay 1 biến
            2.Nhấn giữ phím Ctrl, sau đó nhấn phím R, phím E
            3.Nhấn phím Enter 2 lần liên tiếp
         */
        private string _MsKH;

        public string MsKH
        {
            get { return _MsKH; }
            set { _MsKH = value; }
        }
        private string _TENKH;

        public string TENKH
        {
            get { return _TENKH; }
            set { _TENKH = value; }
        }
        private string _PHAI;

        public string PHAI
        {
            get { return _PHAI; }
            set { _PHAI = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private string _DIENTHOAI;

        public string DIENTHOAI
        {
            get { return _DIENTHOAI; }
            set { _DIENTHOAI = value; }
        }
        //---------Viết hàm khởi tạo: Constructors
        public DTO_CCustomer() { }
        public DTO_CCustomer(string MsKH, 
                             string TENKH, 
                             string PHAI, 
                             string DIACHI, 
                             string DIENTHOAI)  //Dùng thêm và sửa khách hàng
        {
            this.MsKH = MsKH;
            this.TENKH = TENKH;
            this.PHAI = PHAI;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
        }
        public DTO_CCustomer(string MsKH) //Dùng xóa khách hàng
        {
            this.MsKH = MsKH;
        }

        

               

        
    }
}
