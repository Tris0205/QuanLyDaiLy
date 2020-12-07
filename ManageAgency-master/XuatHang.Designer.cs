
namespace QuanLyDaiLy
{
    partial class XuatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuatHang));
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDonViTinh = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phieuXuatHangDgv = new System.Windows.Forms.DataGridView();
            this.btnTraCuuPhieuXuatHang = new System.Windows.Forms.Button();
            this.btnXoaPhieuXuatHang = new System.Windows.Forms.Button();
            this.btnSuaPhieuXuatHang = new System.Windows.Forms.Button();
            this.btnThemPhieuXuatHang = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtSoTienTra = new System.Windows.Forms.TextBox();
            this.txtMaDaiLy = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtNgayLapPhieu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.txtMaXuatHang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(929, 515);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(163, 48);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "THOÁT";
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.cbDonViTinh);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTraCuuPhieuXuatHang);
            this.groupBox1.Controls.Add(this.btnXoaPhieuXuatHang);
            this.groupBox1.Controls.Add(this.btnSuaPhieuXuatHang);
            this.groupBox1.Controls.Add(this.btnThemPhieuXuatHang);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtSoTienTra);
            this.groupBox1.Controls.Add(this.txtMaDaiLy);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.txtNgayLapPhieu);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenMatHang);
            this.groupBox1.Controls.Add(this.txtMaXuatHang);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1079, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất hàng";
            // 
            // cbDonViTinh
            // 
            this.cbDonViTinh.FormattingEnabled = true;
            this.cbDonViTinh.Items.AddRange(new object[] {
            "Hộp",
            "Cây",
            "Hộp thiếc",
            "Hộp giấy",
            "Bịch"});
            this.cbDonViTinh.Location = new System.Drawing.Point(120, 171);
            this.cbDonViTinh.Name = "cbDonViTinh";
            this.cbDonViTinh.Size = new System.Drawing.Size(173, 24);
            this.cbDonViTinh.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.phieuXuatHangDgv);
            this.groupBox2.Location = new System.Drawing.Point(9, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1064, 231);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết phiếu xuất hàng";
            // 
            // phieuXuatHangDgv
            // 
            this.phieuXuatHangDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuXuatHangDgv.Location = new System.Drawing.Point(7, 22);
            this.phieuXuatHangDgv.Name = "phieuXuatHangDgv";
            this.phieuXuatHangDgv.RowTemplate.Height = 24;
            this.phieuXuatHangDgv.Size = new System.Drawing.Size(1051, 203);
            this.phieuXuatHangDgv.TabIndex = 0;
            // 
            // btnTraCuuPhieuXuatHang
            // 
            this.btnTraCuuPhieuXuatHang.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuPhieuXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuPhieuXuatHang.Image")));
            this.btnTraCuuPhieuXuatHang.Location = new System.Drawing.Point(864, 105);
            this.btnTraCuuPhieuXuatHang.Name = "btnTraCuuPhieuXuatHang";
            this.btnTraCuuPhieuXuatHang.Size = new System.Drawing.Size(185, 53);
            this.btnTraCuuPhieuXuatHang.TabIndex = 24;
            this.btnTraCuuPhieuXuatHang.Text = "Tra cứu";
            this.btnTraCuuPhieuXuatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuuPhieuXuatHang.UseVisualStyleBackColor = true;
            this.btnTraCuuPhieuXuatHang.Click += new System.EventHandler(this.btnTraCuuPhieuXuatHang_Click);
            // 
            // btnXoaPhieuXuatHang
            // 
            this.btnXoaPhieuXuatHang.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaPhieuXuatHang.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuXuatHang.Image")));
            this.btnXoaPhieuXuatHang.Location = new System.Drawing.Point(641, 101);
            this.btnXoaPhieuXuatHang.Name = "btnXoaPhieuXuatHang";
            this.btnXoaPhieuXuatHang.Size = new System.Drawing.Size(181, 57);
            this.btnXoaPhieuXuatHang.TabIndex = 23;
            this.btnXoaPhieuXuatHang.Text = "   Xoá";
            this.btnXoaPhieuXuatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaPhieuXuatHang.UseVisualStyleBackColor = false;
            this.btnXoaPhieuXuatHang.Click += new System.EventHandler(this.btnXoaPhieuXuatHang_Click);
            // 
            // btnSuaPhieuXuatHang
            // 
            this.btnSuaPhieuXuatHang.BackColor = System.Drawing.Color.Khaki;
            this.btnSuaPhieuXuatHang.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaPhieuXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhieuXuatHang.Image")));
            this.btnSuaPhieuXuatHang.Location = new System.Drawing.Point(864, 28);
            this.btnSuaPhieuXuatHang.Name = "btnSuaPhieuXuatHang";
            this.btnSuaPhieuXuatHang.Size = new System.Drawing.Size(185, 58);
            this.btnSuaPhieuXuatHang.TabIndex = 16;
            this.btnSuaPhieuXuatHang.Text = "   Sửa";
            this.btnSuaPhieuXuatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaPhieuXuatHang.UseVisualStyleBackColor = false;
            this.btnSuaPhieuXuatHang.Click += new System.EventHandler(this.btnSuaPhieuXuatHang_Click);
            // 
            // btnThemPhieuXuatHang
            // 
            this.btnThemPhieuXuatHang.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemPhieuXuatHang.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuXuatHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuXuatHang.Image")));
            this.btnThemPhieuXuatHang.Location = new System.Drawing.Point(641, 28);
            this.btnThemPhieuXuatHang.Name = "btnThemPhieuXuatHang";
            this.btnThemPhieuXuatHang.Size = new System.Drawing.Size(181, 58);
            this.btnThemPhieuXuatHang.TabIndex = 15;
            this.btnThemPhieuXuatHang.Text = "   Thêm";
            this.btnThemPhieuXuatHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemPhieuXuatHang.UseVisualStyleBackColor = false;
            this.btnThemPhieuXuatHang.Click += new System.EventHandler(this.btnThemPhieuXuatHang_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(441, 135);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(167, 22);
            this.txtTongTien.TabIndex = 22;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.Location = new System.Drawing.Point(441, 171);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Size = new System.Drawing.Size(167, 22);
            this.txtSoTienTra.TabIndex = 20;
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Location = new System.Drawing.Point(120, 63);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(173, 22);
            this.txtMaDaiLy.TabIndex = 19;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(120, 96);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(173, 22);
            this.txtMaHang.TabIndex = 18;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(441, 63);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(167, 22);
            this.txtThanhTien.TabIndex = 17;
            // 
            // txtNgayLapPhieu
            // 
            this.txtNgayLapPhieu.Location = new System.Drawing.Point(441, 101);
            this.txtNgayLapPhieu.Name = "txtNgayLapPhieu";
            this.txtNgayLapPhieu.Size = new System.Drawing.Size(167, 22);
            this.txtNgayLapPhieu.TabIndex = 16;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(441, 28);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(167, 22);
            this.txtDonGia.TabIndex = 15;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(120, 210);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(173, 22);
            this.txtSoLuong.TabIndex = 14;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(120, 132);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(173, 22);
            this.txtTenMatHang.TabIndex = 13;
            // 
            // txtMaXuatHang
            // 
            this.txtMaXuatHang.Location = new System.Drawing.Point(120, 27);
            this.txtMaXuatHang.Name = "txtMaXuatHang";
            this.txtMaXuatHang.Size = new System.Drawing.Size(173, 22);
            this.txtMaXuatHang.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(345, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số tiền trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(305, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày lập phiếu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(337, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn vị tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xuất hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đại lý";
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiTao.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoiTao.Image")));
            this.btnKhoiTao.Location = new System.Drawing.Point(701, 515);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(211, 48);
            this.btnKhoiTao.TabIndex = 27;
            this.btnKhoiTao.Text = "   KHỞI TẠO";
            this.btnKhoiTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // XuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 575);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Close);
            this.Name = "XuatHang";
            this.Text = "XuatHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatHangDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtSoTienTra;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtNgayLapPhieu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.TextBox txtMaXuatHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhieuXuatHang;
        private System.Windows.Forms.Button btnSuaPhieuXuatHang;
        private System.Windows.Forms.Button btnXoaPhieuXuatHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView phieuXuatHangDgv;
        private System.Windows.Forms.Button btnTraCuuPhieuXuatHang;
        private System.Windows.Forms.ComboBox cbDonViTinh;
        private System.Windows.Forms.Button btnKhoiTao;
    }
}