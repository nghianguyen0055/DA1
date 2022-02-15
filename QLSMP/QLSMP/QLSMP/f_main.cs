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
    public partial class f_main : Form
    {
        private account loginAccount;

        public account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value;}
        }
        public f_main(account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            phanquyen(loginAccount.Quyen);
        }

        void phanquyen(string quyen)
        {
            thongkeToolStripMenuItem.Enabled = quyen == "ADMIN"?true : false;
            themtaikhoanToolStripMenuItem.Enabled = quyen == "ADMIN" ? true : false;
            taikhoanToolStripMenuItem.Text += " (" + loginAccount.UserName + ")";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_nhanvien fnv = new f_nhanvien();
            this.Hide();
            fnv.ShowDialog();
            this.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_sanpham spp = new f_sanpham();
            this.Hide();
            spp.ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_khachhang fkh = new f_khachhang();
            this.Hide();
            fkh.ShowDialog();
            this.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_loai floai = new f_loai();
            this.Hide();
            floai.ShowDialog();
            this.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_ncc fncc = new f_ncc();
            this.Hide();
            fncc.ShowDialog();
            this.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_hoadon fhd = new f_hoadon();
            this.Hide();
            fhd.ShowDialog();
            this.Show();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_hdn fhdn = new f_hdn();
            this.Hide();
            fhdn.ShowDialog();
            this.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_thongke ftk = new f_thongke();
            this.Hide();
            ftk.ShowDialog();
            this.Show();
        }
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_doimk fdmk = new f_doimk(loginAccount);
            this.Hide();
            fdmk.ShowDialog();
            this.Show();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_tk ftk = new f_tk();
            this.Hide();
            ftk.ShowDialog();
            this.Show();
        }

        private void taikhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_kho fk = new f_kho();
            this.Hide();
            fk.ShowDialog();
            this.Show();
        }
        int x = 12, y = 60, a = 1;
        private void tmrchaychu_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lblchaychu.Location = new Point(x, y);
                if (x >= 320)
                {
                    a = -2;
                }
                if (x <= 12)
                {
                    a = 2;
                }
            }catch(Exception ex) { }
        }
    }
}
