
namespace QuanLyDaiLy
{
    partial class DaiLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaiLy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbQuan = new System.Windows.Forms.ComboBox();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DaiLyDatagridview = new System.Windows.Forms.DataGridView();
            this.TraCuuDaiLy = new System.Windows.Forms.Button();
            this.XoaDaiLy = new System.Windows.Forms.Button();
            this.SuaDaiLy = new System.Windows.Forms.Button();
            this.ThemDaiLy = new System.Windows.Forms.Button();
            this.txtTenDaiLy = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNgayTiepNhan = new System.Windows.Forms.TextBox();
            this.txtMaDaiLy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaiLyDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.cbQuan);
            this.groupBox1.Controls.Add(this.cbLoai);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TraCuuDaiLy);
            this.groupBox1.Controls.Add(this.XoaDaiLy);
            this.groupBox1.Controls.Add(this.SuaDaiLy);
            this.groupBox1.Controls.Add(this.ThemDaiLy);
            this.groupBox1.Controls.Add(this.txtTenDaiLy);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtNgayTiepNhan);
            this.groupBox1.Controls.Add(this.txtMaDaiLy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 519);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đại lý";
            // 
            // cbQuan
            // 
            this.cbQuan.FormattingEnabled = true;
            this.cbQuan.Items.AddRange(new object[] {
            "Q1",
            "Q2",
            "Q3",
            "Q4",
            "Q5",
            "Q6",
            "Q7",
            "Q8",
            "Q9",
            "Q10",
            "Q11",
            "Q12",
            "Tan Binh",
            "Tan Phu",
            "Binh Tan",
            "Binh Thanh",
            "Phu Nhuan",
            "Thu Duc",
            "Hoc Mon",
            "Cu Chi"});
            this.cbQuan.Location = new System.Drawing.Point(472, 53);
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.Size = new System.Drawing.Size(121, 24);
            this.cbQuan.TabIndex = 21;
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbLoai.Location = new System.Drawing.Point(115, 91);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(121, 24);
            this.cbLoai.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.DaiLyDatagridview);
            this.groupBox2.Location = new System.Drawing.Point(10, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1050, 300);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết đại lý";
            // 
            // DaiLyDatagridview
            // 
            this.DaiLyDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaiLyDatagridview.Location = new System.Drawing.Point(7, 22);
            this.DaiLyDatagridview.Name = "DaiLyDatagridview";
            this.DaiLyDatagridview.RowTemplate.Height = 24;
            this.DaiLyDatagridview.Size = new System.Drawing.Size(1037, 272);
            this.DaiLyDatagridview.TabIndex = 0;
            // 
            // TraCuuDaiLy
            // 
            this.TraCuuDaiLy.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraCuuDaiLy.Image = ((System.Drawing.Image)(resources.GetObject("TraCuuDaiLy.Image")));
            this.TraCuuDaiLy.Location = new System.Drawing.Point(875, 95);
            this.TraCuuDaiLy.Name = "TraCuuDaiLy";
            this.TraCuuDaiLy.Size = new System.Drawing.Size(185, 53);
            this.TraCuuDaiLy.TabIndex = 17;
            this.TraCuuDaiLy.Text = "Tra cứu";
            this.TraCuuDaiLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TraCuuDaiLy.UseVisualStyleBackColor = true;
            this.TraCuuDaiLy.Click += new System.EventHandler(this.TraCuuDaiLy_Click);
            // 
            // XoaDaiLy
            // 
            this.XoaDaiLy.BackColor = System.Drawing.Color.Salmon;
            this.XoaDaiLy.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaDaiLy.Image = ((System.Drawing.Image)(resources.GetObject("XoaDaiLy.Image")));
            this.XoaDaiLy.Location = new System.Drawing.Point(659, 91);
            this.XoaDaiLy.Name = "XoaDaiLy";
            this.XoaDaiLy.Size = new System.Drawing.Size(181, 57);
            this.XoaDaiLy.TabIndex = 16;
            this.XoaDaiLy.Text = "   Xoá";
            this.XoaDaiLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XoaDaiLy.UseVisualStyleBackColor = false;
            this.XoaDaiLy.Click += new System.EventHandler(this.XoaDaiLy_Click);
            // 
            // SuaDaiLy
            // 
            this.SuaDaiLy.BackColor = System.Drawing.Color.Khaki;
            this.SuaDaiLy.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuaDaiLy.Image = ((System.Drawing.Image)(resources.GetObject("SuaDaiLy.Image")));
            this.SuaDaiLy.Location = new System.Drawing.Point(875, 21);
            this.SuaDaiLy.Name = "SuaDaiLy";
            this.SuaDaiLy.Size = new System.Drawing.Size(185, 58);
            this.SuaDaiLy.TabIndex = 15;
            this.SuaDaiLy.Text = "   Sửa";
            this.SuaDaiLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SuaDaiLy.UseVisualStyleBackColor = false;
            this.SuaDaiLy.Click += new System.EventHandler(this.SuaDaiLy_Click);
            // 
            // ThemDaiLy
            // 
            this.ThemDaiLy.BackColor = System.Drawing.Color.LightGreen;
            this.ThemDaiLy.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemDaiLy.Image = ((System.Drawing.Image)(resources.GetObject("ThemDaiLy.Image")));
            this.ThemDaiLy.Location = new System.Drawing.Point(659, 21);
            this.ThemDaiLy.Name = "ThemDaiLy";
            this.ThemDaiLy.Size = new System.Drawing.Size(181, 58);
            this.ThemDaiLy.TabIndex = 14;
            this.ThemDaiLy.Text = "   Thêm";
            this.ThemDaiLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThemDaiLy.UseVisualStyleBackColor = false;
            this.ThemDaiLy.Click += new System.EventHandler(this.ThemDaiLy_Click);
            // 
            // txtTenDaiLy
            // 
            this.txtTenDaiLy.Location = new System.Drawing.Point(115, 57);
            this.txtTenDaiLy.Name = "txtTenDaiLy";
            this.txtTenDaiLy.Size = new System.Drawing.Size(167, 22);
            this.txtTenDaiLy.TabIndex = 13;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(115, 132);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(167, 22);
            this.txtSoDienThoai.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(472, 22);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(121, 22);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtNgayTiepNhan
            // 
            this.txtNgayTiepNhan.Location = new System.Drawing.Point(472, 91);
            this.txtNgayTiepNhan.Name = "txtNgayTiepNhan";
            this.txtNgayTiepNhan.Size = new System.Drawing.Size(121, 22);
            this.txtNgayTiepNhan.TabIndex = 8;
            // 
            // txtMaDaiLy
            // 
            this.txtMaDaiLy.Location = new System.Drawing.Point(115, 22);
            this.txtMaDaiLy.Name = "txtMaDaiLy";
            this.txtMaDaiLy.Size = new System.Drawing.Size(167, 22);
            this.txtMaDaiLy.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày tiếp nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đại lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại đại lý";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đại lý";
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(913, 546);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(184, 50);
            this.btn_Close.TabIndex = 19;
            this.btn_Close.Text = "  THOÁT";
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(671, 546);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(211, 50);
            this.button5.TabIndex = 20;
            this.button5.Text = "   KHỞI TẠO";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 608);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Name = "DaiLy";
            this.Text = "DaiLy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DaiLyDatagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TraCuuDaiLy;
        private System.Windows.Forms.Button XoaDaiLy;
        private System.Windows.Forms.Button SuaDaiLy;
        private System.Windows.Forms.Button ThemDaiLy;
        private System.Windows.Forms.TextBox txtTenDaiLy;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtNgayTiepNhan;
        private System.Windows.Forms.TextBox txtMaDaiLy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DaiLyDatagridview;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cbQuan;
        private System.Windows.Forms.ComboBox cbLoai;
    }
}