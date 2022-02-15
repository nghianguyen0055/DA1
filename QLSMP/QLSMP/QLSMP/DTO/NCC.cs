using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DTO
{
    public class NCC
    {
        public NCC(string mancc, string tenncc, string diachi, string sdt)
        {
            this.Mancc = mancc;
            this.Tenncc = tenncc;
            this.Diachi = diachi;
            this.Sdt = sdt;
        }
        public NCC(DataRow row)
        {
            this.Mancc = row["mancc"].ToString();
            this.Tenncc = row["tenncc"].ToString();
            this.Diachi = row["diachi"].ToString();
            this.Sdt = row["sdt"].ToString();
        }


        private string mancc;
        private string tenncc;
        private string diachi;
        private string sdt;

        public string Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
