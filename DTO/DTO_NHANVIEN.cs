using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_NHANVIEN
    {
        private string _MANV;

        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }


        private string _TENNV;

        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
        }

        private string _TENDANGNHAP;

        public string TENDANGNHAP
        {
            get { return _TENDANGNHAP; }
            set { _TENDANGNHAP = value; }
        }
        private string _NGAYSINH;

        public string NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
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
        private string SO_HD_THUCHIEN;

        public string SO_HD_THUCHIEN1
        {
            get { return SO_HD_THUCHIEN; }
            set { SO_HD_THUCHIEN = value; }
        }

        
        
        private string NGAYDANGNHAP;

        public string NGAYDANGNHAP1
        {
            get { return NGAYDANGNHAP; }
            set { NGAYDANGNHAP = value; }
        }
        private string SOLANDN;

        public string SOLANDN1
        {
            get { return SOLANDN; }
            set { SOLANDN = value; }
        }
        private string QUYENHAN;

        public string QUYENHAN1
        {
            get { return QUYENHAN; }
            set { QUYENHAN = value; }
        }

        public DTO_NHANVIEN(string MANV, string TENNV,string TENDANGNHAP, string NGAYSINH,
            string PHAI, string DIACHI, string DIENTHOAI, string SO_HD_THUCHIEN, string NGAYDANGNHAP, string SOLANDN, string QUYENHAN
                             )  //Dùng thêm và sửa khách hàng
        {
            
            this.PHAI = PHAI;
            this.DIACHI = DIACHI;
            this.DIENTHOAI = DIENTHOAI;
            this.MANV=MANV;
            this.TENNV= TENNV ;
            this.TENDANGNHAP=TENDANGNHAP;
            this.NGAYSINH=NGAYSINH;
            this.PHAI=PHAI;
            this.DIACHI=DIACHI;
            this.DIENTHOAI=DIENTHOAI;
            this.SO_HD_THUCHIEN=SO_HD_THUCHIEN;
            this.NGAYDANGNHAP=NGAYDANGNHAP;
            this.SOLANDN=SOLANDN;
            this.QUYENHAN = QUYENHAN;
        }
        public DTO_NHANVIEN(string MsKH) //Dùng xóa khách hàng
        {
            this.MANV = MANV;
        }
    }
}
