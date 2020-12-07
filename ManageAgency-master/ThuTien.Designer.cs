
namespace QuanLyDaiLy
{
    partial class ThuTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuTien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSuaThuTien = new System.Windows.Forms.Button();
            this.btnXoaThuTien = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thuTienDgv = new System.Windows.Forms.DataGridView();
            this.btnTraCuuThuTien = new System.Windows.Forms.Button();
            this.btnThemThuTien = new System.Windows.Forms.Button();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtNgayThuTien = new System.Windows.Forms.TextBox();
            this.txtTienConLai = new System.Windows.Forms.TextBox();
            this.txtMaThuTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btnKhoiTao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thuTienDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.btnSuaThuTien);
            this.groupBox1.Controls.Add(this.btnXoaThuTien);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnTraCuuThuTien);
            this.groupBox1.Controls.Add(this.btnThemThuTien);
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.txtNgayThuTien);
            this.groupBox1.Controls.Add(this.txtTienConLai);
            this.groupBox1.Controls.Add(this.txtMaThuTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 455);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu thu tiền";
            // 
            // btnSuaThuTien
            // 
            this.btnSuaThuTien.BackColor = System.Drawing.Color.Khaki;
            this.btnSuaThuTien.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuTien.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaThuTien.Image")));
            this.btnSuaThuTien.Location = new System.Drawing.Point(733, 33);
            this.btnSuaThuTien.Name = "btnSuaThuTien";
            this.btnSuaThuTien.Size = new System.Drawing.Size(185, 58);
            this.btnSuaThuTien.TabIndex = 28;
            this.btnSuaThuTien.Text = "   Sửa";
            this.btnSuaThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaThuTien.UseVisualStyleBackColor = false;
            this.btnSuaThuTien.Click += new System.EventHandler(this.btnSuaThuTien_Click);
            // 
            // btnXoaThuTien
            // 
            this.btnXoaThuTien.BackColor = System.Drawing.Color.Salmon;
            this.btnXoaThuTien.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuTien.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaThuTien.Image")));
            this.btnXoaThuTien.Location = new System.Drawing.Point(546, 106);
            this.btnXoaThuTien.Name = "btnXoaThuTien";
            this.btnXoaThuTien.Size = new System.Drawing.Size(181, 57);
            this.btnXoaThuTien.TabIndex = 27;
            this.btnXoaThuTien.Text = "   Xoá";
            this.btnXoaThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaThuTien.UseVisualStyleBackColor = false;
            this.btnXoaThuTien.Click += new System.EventHandler(this.btnXoaThuTien_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.thuTienDgv);
            this.groupBox2.Location = new System.Drawing.Point(0, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 245);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu thu tiền";
            // 
            // thuTienDgv
            // 
            this.thuTienDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thuTienDgv.Location = new System.Drawing.Point(11, 22);
            this.thuTienDgv.Name = "thuTienDgv";
            this.thuTienDgv.RowTemplate.Height = 24;
            this.thuTienDgv.Size = new System.Drawing.Size(892, 217);
            this.thuTienDgv.TabIndex = 0;
            // 
            // btnTraCuuThuTien
            // 
            this.btnTraCuuThuTien.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuThuTien.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuThuTien.Image")));
            this.btnTraCuuThuTien.Location = new System.Drawing.Point(733, 107);
            this.btnTraCuuThuTien.Name = "btnTraCuuThuTien";
            this.btnTraCuuThuTien.Size = new System.Drawing.Size(181, 54);
            this.btnTraCuuThuTien.TabIndex = 25;
            this.btnTraCuuThuTien.Text = "Tra cứu";
            this.btnTraCuuThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuuThuTien.UseVisualStyleBackColor = true;
            this.btnTraCuuThuTien.Click += new System.EventHandler(this.btnTraCuuThuTien_Click);
            // 
            // btnThemThuTien
            // 
            this.btnThemThuTien.BackColor = System.Drawing.Color.LightGreen;
            this.btnThemThuTien.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuTien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemThuTien.Image")));
            this.btnThemThuTien.Location = new System.Drawing.Point(546, 33);
            this.btnThemThuTien.Name = "btnThemThuTien";
            this.btnThemThuTien.Size = new System.Drawing.Size(181, 58);
            this.btnThemThuTien.TabIndex = 16;
            this.btnThemThuTien.Text = "   Thêm";
            this.btnThemThuTien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemThuTien.UseVisualStyleBackColor = false;
            this.btnThemThuTien.Click += new System.EventHandler(this.btnThemThuTien_Click);
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(102, 80);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(159, 22);
            this.txtSoTienThu.TabIndex = 8;
            // 
            // txtNgayThuTien
            // 
            this.txtNgayThuTien.Location = new System.Drawing.Point(391, 33);
            this.txtNgayThuTien.Name = "txtNgayThuTien";
            this.txtNgayThuTien.Size = new System.Drawing.Size(142, 22);
            this.txtNgayThuTien.TabIndex = 7;
            // 
            // txtTienConLai
            // 
            this.txtTienConLai.Location = new System.Drawing.Point(391, 77);
            this.txtTienConLai.Name = "txtTienConLai";
            this.txtTienConLai.Size = new System.Drawing.Size(142, 22);
            this.txtTienConLai.TabIndex = 6;
            // 
            // txtMaThuTien
            // 
            this.txtMaThuTien.Location = new System.Drawing.Point(103, 33);
            this.txtMaThuTien.Name = "txtMaThuTien";
            this.txtMaThuTien.Size = new System.Drawing.Size(158, 22);
            this.txtMaThuTien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số tiền thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày thu tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiền còn lại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thu tiền";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(753, 474);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(184, 50);
            this.btn_Close.TabIndex = 29;
            this.btn_Close.Text = "  THOÁT";
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnKhoiTao
            // 
            this.btnKhoiTao.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiTao.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoiTao.Image")));
            this.btnKhoiTao.Location = new System.Drawing.Point(529, 476);
            this.btnKhoiTao.Name = "btnKhoiTao";
            this.btnKhoiTao.Size = new System.Drawing.Size(211, 48);
            this.btnKhoiTao.TabIndex = 29;
            this.btnKhoiTao.Text = "   KHỞI TẠO";
            this.btnKhoiTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoiTao.UseVisualStyleBackColor = true;
            this.btnKhoiTao.Click += new System.EventHandler(this.btnKhoiTao_Click);
            // 
            // ThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 532);
            this.Controls.Add(this.btnKhoiTao);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThuTien";
            this.Text = "ThuTien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thuTienDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.TextBox txtNgayThuTien;
        private System.Windows.Forms.TextBox txtTienConLai;
        private System.Windows.Forms.TextBox txtMaThuTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemThuTien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTraCuuThuTien;
        private System.Windows.Forms.Button btnXoaThuTien;
        private System.Windows.Forms.Button btnSuaThuTien;
        private System.Windows.Forms.DataGridView thuTienDgv;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btnKhoiTao;
    }
}