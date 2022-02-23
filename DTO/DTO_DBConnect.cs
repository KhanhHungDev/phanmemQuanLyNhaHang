using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DBConnect
    {
        private string _Servername;

        public string Servername
        {
            get { return _Servername; }
            set { _Servername = value; }
        }
        private string _Database;

        public string Database
        {
            get { return _Database; }
            set { _Database = value; }
        }
        private string _UserID;

        public string UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }


        //--------------Các thuộc tính Get/Set là của phiên bản Visual Studio 2019
        //public string Servername 
        //{
        //    get => _Servername; 
        //    set => _Servername = value; 
        //}
        //public string Database 
        //{ 
        //    get => _Database; 
        //    set => _Database = value; 
        //}
        //public string UserID 
        //{ 
        //    get => _UserID; 
        //    set => _UserID = value; 
        //}
        //public string Password 
        //{ 
        //    get => _Password; 
        //    set => _Password = value; 
        //}
       

        //----------Hàm khởi tạo: Constructor
        public DTO_DBConnect()
        { 
        }
        public DTO_DBConnect(string servername, 
                             string database, 
                             string userid, 
                             string password)
        {
            this.Servername = servername;
            this.Database = database;
            this.UserID = userid;
            this.Password = password;
        }
    }
}
