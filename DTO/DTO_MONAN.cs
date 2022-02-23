using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_MONAN
    {
        private string _MAMON;

        public string MAMON
        {
            get { return _MAMON; }
            set { _MAMON = value; }
        }
        private string _TENMON;

        public string TENMON
        {
            get { return _TENMON; }
            set { _TENMON = value; }
        }
        private string _SL;

        public string SL
        {
            get { return _SL; }
            set { _SL = value; }
        }
        private string _DONGIA;

        public string DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }
        private string _DONVITINH;

        public string DONVITINH
        {
            get { return _DONVITINH; }
            set { _DONVITINH = value; }
        }
        public DTO_MONAN() { }
        public DTO_MONAN(string MAMON, 
                             string TENMON, 
                             string SL, 
                             string DONGIA, 
                             string DONVITINH)  //Dùng thêm và sửa khách hàng
        {
            this.MAMON = MAMON;
            this.TENMON = TENMON;
            this.SL = SL;
            this.DONGIA = DONGIA;
            this.DONVITINH = DONVITINH;
        }
    }
}
