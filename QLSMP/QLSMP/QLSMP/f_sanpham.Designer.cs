
namespace QLSMP
{
    partial class f_sanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbmaloai = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btn_dongsp = new System.Windows.Forms.Button();
            this.btn_xoasp = new System.Windows.Forms.Button();
            this.btn_suasp = new System.Windows.Forms.Button();
            this.btn_themsp = new System.Windows.Forms.Button();
            this.dgv_sanpham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.cbbmaloai);
            this.panel1.Controls.Add(this.cbbNCC);
            this.panel1.Controls.Add(this.txt_gia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_tensp);
            this.panel1.Controls.Add(this.txt_soluong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_masp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 211);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(477, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 37);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm:";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btntimkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Location = new System.Drawing.Point(194, 11);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(70, 26);
            this.btntimkiem.TabIndex = 25;
            this.btntimkiem.Text = "Tìm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(59, 13);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(108, 20);
            this.txttimkiem.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "MASP:";
            // 
            // cbbmaloai
            // 
            this.cbbmaloai.FormattingEnabled = true;
            this.cbbmaloai.Location = new System.Drawing.Point(490, 142);
            this.cbbmaloai.Name = "cbbmaloai";
            this.cbbmaloai.Size = new System.Drawing.Size(189, 21);
            this.cbbmaloai.TabIndex = 12;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(147, 142);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(202, 21);
            this.cbbNCC.TabIndex = 11;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(490, 103);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(189, 20);
            this.txt_gia.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Loại:";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(147, 105);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_tensp.Size = new System.Drawing.Size(202, 20);
            this.txt_tensp.TabIndex = 2;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(490, 59);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(189, 20);
            this.txt_soluong.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Gía:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nhà Cung Cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Sản Phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số Lượng:";
            // 
            // txt_masp
            // 
            this.txt_masp.Location = new System.Drawing.Point(147, 59);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.ReadOnly = true;
            this.txt_masp.Size = new System.Drawing.Size(202, 20);
            this.txt_masp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục sản Phẩm";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.btnlammoi);
            this.panel3.Controls.Add(this.btn_dongsp);
            this.panel3.Controls.Add(this.btn_xoasp);
            this.panel3.Controls.Add(this.btn_suasp);
            this.panel3.Controls.Add(this.btn_themsp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 444);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(810, 63);
            this.panel3.TabIndex = 13;
            // 
            // btnlammoi
            // 
            this.btnlammoi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnlammoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlammoi.Location = new System.Drawing.Point(519, 15);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(117, 36);
            this.btnlammoi.TabIndex = 12;
            this.btnlammoi.Text = "làm mới";
            this.btnlammoi.UseVisualStyleBackColor = false;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btn_dongsp
            // 
            this.btn_dongsp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_dongsp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongsp.Location = new System.Drawing.Point(671, 15);
            this.btn_dongsp.Name = "btn_dongsp";
            this.btn_dongsp.Size = new System.Drawing.Size(117, 36);
            this.btn_dongsp.TabIndex = 11;
            this.btn_dongsp.Text = "Đóng";
            this.btn_dongsp.UseVisualStyleBackColor = false;
            this.btn_dongsp.Click += new System.EventHandler(this.btn_dongsp_Click);
            // 
            // btn_xoasp
            // 
            this.btn_xoasp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_xoasp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoasp.Location = new System.Drawing.Point(363, 15);
            this.btn_xoasp.Name = "btn_xoasp";
            this.btn_xoasp.Size = new System.Drawing.Size(117, 36);
            this.btn_xoasp.TabIndex = 9;
            this.btn_xoasp.Text = "Xóa";
            this.btn_xoasp.UseVisualStyleBackColor = false;
            this.btn_xoasp.Click += new System.EventHandler(this.btn_xoasp_Click);
            // 
            // btn_suasp
            // 
            this.btn_suasp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_suasp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suasp.Location = new System.Drawing.Point(188, 15);
            this.btn_suasp.Name = "btn_suasp";
            this.btn_suasp.Size = new System.Drawing.Size(117, 36);
            this.btn_suasp.TabIndex = 8;
            this.btn_suasp.Text = "Sửa";
            this.btn_suasp.UseVisualStyleBackColor = false;
            this.btn_suasp.Click += new System.EventHandler(this.btn_suasp_Click);
            // 
            // btn_themsp
            // 
            this.btn_themsp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_themsp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themsp.Location = new System.Drawing.Point(12, 15);
            this.btn_themsp.Name = "btn_themsp";
            this.btn_themsp.Size = new System.Drawing.Size(117, 36);
            this.btn_themsp.TabIndex = 7;
            this.btn_themsp.Text = "Thêm";
            this.btn_themsp.UseVisualStyleBackColor = false;
            this.btn_themsp.Click += new System.EventHandler(this.btn_themsp_Click);
            // 
            // dgv_sanpham
            // 
            this.dgv_sanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sanpham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.mancc,
            this.soluong,
            this.gia,
            this.maloai});
            this.dgv_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sanpham.Location = new System.Drawing.Point(0, 211);
            this.dgv_sanpham.Name = "dgv_sanpham";
            this.dgv_sanpham.Size = new System.Drawing.Size(810, 233);
            this.dgv_sanpham.TabIndex = 14;
            this.dgv_sanpham.Click += new System.EventHandler(this.dgv_sanpham_Click);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TENSP";
            this.tensp.HeaderText = "Tên Sản Phẩm";
            this.tensp.Name = "tensp";
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "MANCC";
            this.mancc.HeaderText = "Mã Nhà Cung Cấp";
            this.mancc.Name = "mancc";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SOLUONG";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // gia
            // 
            this.gia.DataPropertyName = "GIA";
            this.gia.HeaderText = "Gía";
            this.gia.Name = "gia";
            // 
            // maloai
            // 
            this.maloai.DataPropertyName = "MALOAI";
            this.maloai.HeaderText = "Mã Loại";
            this.maloai.Name = "maloai";
            // 
            // f_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 507);
            this.Controls.Add(this.dgv_sanpham);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "f_sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Sản Phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sanpham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_dongsp;
        private System.Windows.Forms.Button btn_xoasp;
        private System.Windows.Forms.Button btn_suasp;
        private System.Windows.Forms.Button btn_themsp;
        private System.Windows.Forms.DataGridView dgv_sanpham;
        private System.Windows.Forms.ComboBox cbbmaloai;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label15;
    }
}