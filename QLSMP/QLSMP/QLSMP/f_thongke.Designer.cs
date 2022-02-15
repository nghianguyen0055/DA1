
namespace QLSMP
{
    partial class f_thongke
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
            this.btn_thongke = new System.Windows.Forms.Button();
            this.dtpk_todate = new System.Windows.Forms.DateTimePicker();
            this.dtpk_fromdate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_doanhthu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txttongcong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.dtpk_todate);
            this.panel1.Controls.Add(this.dtpk_fromdate);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 46);
            this.panel1.TabIndex = 0;
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_thongke.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.Black;
            this.btn_thongke.Location = new System.Drawing.Point(341, 9);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(122, 31);
            this.btn_thongke.TabIndex = 2;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // dtpk_todate
            // 
            this.dtpk_todate.Location = new System.Drawing.Point(555, 12);
            this.dtpk_todate.Name = "dtpk_todate";
            this.dtpk_todate.Size = new System.Drawing.Size(200, 20);
            this.dtpk_todate.TabIndex = 1;
            // 
            // dtpk_fromdate
            // 
            this.dtpk_fromdate.Location = new System.Drawing.Point(40, 12);
            this.dtpk_fromdate.Name = "dtpk_fromdate";
            this.dtpk_fromdate.Size = new System.Drawing.Size(200, 20);
            this.dtpk_fromdate.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_doanhthu);
            this.panel2.Location = new System.Drawing.Point(0, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 325);
            this.panel2.TabIndex = 1;
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doanhthu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_doanhthu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_doanhthu.Location = new System.Drawing.Point(0, 0);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.Size = new System.Drawing.Size(798, 325);
            this.dgv_doanhthu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(323, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doanh Thu";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_thoat.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_thoat.Location = new System.Drawing.Point(655, 453);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(122, 38);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Đóng";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(498, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "TỔNG CỘNG:";
            // 
            // txttongcong
            // 
            this.txttongcong.Location = new System.Drawing.Point(129, 466);
            this.txttongcong.Name = "txttongcong";
            this.txttongcong.Size = new System.Drawing.Size(202, 20);
            this.txttongcong.TabIndex = 6;
            // 
            // f_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.txttongcong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "f_thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_doanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpk_fromdate;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.DateTimePicker dtpk_todate;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttongcong;
    }
}