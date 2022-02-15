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
    public partial class f_login : Form
    {
        public f_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pass = txtPassWord.Text;
            if (login(username, pass))
            {
                account loginAccount = accountDAO.Instance.GetAccountByUserName(username);
                MessageBox.Show("Đăng Nhập Thành Công!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f_main main = new f_main(loginAccount);
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool login(string username, string pass)
        {
            txtUserName.Clear();
            txtPassWord.Clear();
            return accountDAO.Instance.login(username, pass);

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void f_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn Có Muốn Thoát?","Thông Báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)//thay phím tab bằng phím enter
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
