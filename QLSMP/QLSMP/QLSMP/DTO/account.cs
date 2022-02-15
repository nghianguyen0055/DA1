using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
    public class account
    {
        public account(string username, string quyen, string password = null)
        {
            this.UserName = username;
            this.Quyen = quyen;
            this.Password = password;
        }
        public account(DataRow row)
        {
            this.UserName = row["username"].ToString();
            this.Quyen = row["quyen"].ToString();
            this.Password = row["password"].ToString();
        }

        private string quyen;
        private string password;
        private string userName;

        public string UserName {
            get { return userName; }
            set { userName = value; }
            }
        public string Password
        {
            get { return password; }
            set { password = value;}
        }
        public string Quyen
        {
            get {return quyen; }
            set { quyen = value; }
        }
    }
}
