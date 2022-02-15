using QLSMP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSMP
{
    public partial class f_kho : Form
    {
        public f_kho()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            string query = "select tensp, soluong from SANPHAM ";
            dgv_kho.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "select tensp, soluong from sanpham where tensp like '%" + txttimkiem.Text.Trim() + "%'";
            dgv_kho.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
