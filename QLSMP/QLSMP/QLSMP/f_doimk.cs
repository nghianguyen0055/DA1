using QLSMP.DAO;
using QLSMP.DTO;
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
    public partial class f_doimk : Form
    {
        private account loginaccount;

        public account Loginaccount { get => loginaccount; set => loginaccount = value; }

        public f_doimk(account acc)
        {
            InitializeComponent();
            loginaccount = acc;
            changeaccount(loginaccount);
        }
        void changeaccount(account acc)
        {
            txt_tentk.Text = loginaccount.UserName;
        }
        void updateaccount()
        {
            string username = txt_tentk.Text;
            string pass = txt_mkc.Text;
            string newpass = txt_mkmoi.Text;
            string nhaplai = txt_nhaplai.Text;
            if (!newpass.Equals(nhaplai))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!!!","Thông Báo");
            }
            else
            {
                if(accountDAO.Instance.updateaccount(username, pass, newpass))
                {
                    MessageBox.Show("Đổi thành công!!!", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("vui lòng điền đúng mật khẩu");
                }
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void reset()
        {
            txt_mkc.Clear();
            txt_mkmoi.Clear();
            txt_nhaplai.Clear();
        }

        private void btn_doi_Click(object sender, EventArgs e)
        {
            if (txt_mkc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mkc.Focus();
                return;
            }
            if (txt_mkmoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu mới!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_mkmoi.Focus();
                return;
            }
            if (txt_nhaplai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lại mât khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nhaplai.Focus();
                return;
            }
            updateaccount();
            reset();
        }
    }
}
