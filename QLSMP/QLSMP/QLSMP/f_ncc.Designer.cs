
namespace QLSMP
{
    partial class f_ncc
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_moi = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_sdtncc = new System.Windows.Forms.TextBox();
            this.txt_tenncc = new System.Windows.Forms.TextBox();
            this.txt_diachincc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ncc = new System.Windows.Forms.DataGridView();
            this.mancc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenncc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dchi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btn_dong);
            this.panel2.Controls.Add(this.btn_moi);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 63);
            this.panel2.TabIndex = 13;
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_dong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Location = new System.Drawing.Point(671, 15);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(117, 36);
            this.btn_dong.TabIndex = 9;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_moi
            // 
            this.btn_moi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_moi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moi.Location = new System.Drawing.Point(509, 15);
            this.btn_moi.Name = "btn_moi";
            this.btn_moi.Size = new System.Drawing.Size(117, 36);
            this.btn_moi.TabIndex = 8;
            this.btn_moi.Text = "Làm Mới";
            this.btn_moi.UseVisualStyleBackColor = false;
            this.btn_moi.Click += new System.EventHandler(this.btn_moi_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(341, 15);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(117, 36);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_sua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(173, 15);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(117, 36);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(12, 15);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(117, 36);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.txt_sdtncc);
            this.panel1.Controls.Add(this.txt_tenncc);
            this.panel1.Controls.Add(this.txt_diachincc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_mancc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 149);
            this.panel1.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btntimkiem);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(476, 6);
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
            this.label15.Size = new System.Drawing.Size(51, 14);
            this.label15.TabIndex = 0;
            this.label15.Text = "MANCC:";
            // 
            // txt_sdtncc
            // 
            this.txt_sdtncc.Location = new System.Drawing.Point(477, 100);
            this.txt_sdtncc.Name = "txt_sdtncc";
            this.txt_sdtncc.Size = new System.Drawing.Size(311, 20);
            this.txt_sdtncc.TabIndex = 4;
            this.txt_sdtncc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sdtncc_KeyPress);
            // 
            // txt_tenncc
            // 
            this.txt_tenncc.Location = new System.Drawing.Point(147, 100);
            this.txt_tenncc.Name = "txt_tenncc";
            this.txt_tenncc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_tenncc.Size = new System.Drawing.Size(202, 20);
            this.txt_tenncc.TabIndex = 2;
            // 
            // txt_diachincc
            // 
            this.txt_diachincc.Location = new System.Drawing.Point(477, 59);
            this.txt_diachincc.Name = "txt_diachincc";
            this.txt_diachincc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_diachincc.Size = new System.Drawing.Size(311, 20);
            this.txt_diachincc.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(369, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Nhà Cung Cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(369, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ:";
            // 
            // txt_mancc
            // 
            this.txt_mancc.BackColor = System.Drawing.Color.White;
            this.txt_mancc.Location = new System.Drawing.Point(147, 59);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.ReadOnly = true;
            this.txt_mancc.Size = new System.Drawing.Size(202, 20);
            this.txt_mancc.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhà Cung Cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Nhà Cung Cấp";
            // 
            // dgv_ncc
            // 
            this.dgv_ncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ncc.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mancc,
            this.tenncc,
            this.dchi,
            this.sdt});
            this.dgv_ncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ncc.Location = new System.Drawing.Point(0, 149);
            this.dgv_ncc.Name = "dgv_ncc";
            this.dgv_ncc.Size = new System.Drawing.Size(800, 265);
            this.dgv_ncc.TabIndex = 15;
            this.dgv_ncc.Click += new System.EventHandler(this.dgv_ncc_Click);
            // 
            // mancc
            // 
            this.mancc.DataPropertyName = "MANCC";
            this.mancc.HeaderText = "Mã Nhà Cung Cấp";
            this.mancc.Name = "mancc";
            // 
            // tenncc
            // 
            this.tenncc.DataPropertyName = "TENNCC";
            this.tenncc.HeaderText = "Tên Nhà Cung Cấp";
            this.tenncc.Name = "tenncc";
            // 
            // dchi
            // 
            this.dchi.DataPropertyName = "DIACHI";
            this.dchi.HeaderText = "Địa Chỉ";
            this.dchi.Name = "dchi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "Số Điện Thoại";
            this.sdt.Name = "sdt";
            // 
            // f_ncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.dgv_ncc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f_ncc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Nhà Cung Cấp";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ncc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_moi;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sdtncc;
        private System.Windows.Forms.TextBox txt_tenncc;
        private System.Windows.Forms.TextBox txt_diachincc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mancc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dchi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label15;
    }
}