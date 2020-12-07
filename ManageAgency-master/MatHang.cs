using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDaiLy.DAL;

namespace QuanLyDaiLy
{
    public partial class MatHang : Form
    {
        private QLDaiLyEntities3 db = new QLDaiLyEntities3();
        public MatHang()
        {
            InitializeComponent();
            LoadDataMatHang();
        }
        private void ControlMatHang_DataSource(object data)
        {
            matHangDgv.DataSource = data;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void LoadDataMatHang()
        {
            var data = from p in db.MATHANGs
                       select new
                       {
                           maHang = p.MaHang,
                           maLoaiHang = p.MaLoaiHang,
                           tenMatHang = p.TenMatHang,
                           loaiHang = p.LoaiHang,
                           donViTinh = p.DonViTinh,
                           donGia = p.DonGia,
                         
                       };
            ControlMatHang_DataSource(data.ToList());
            matHang_DataBinding();
        }

        private void matHang_DataBinding()
        {
            txtMatHang.DataBindings.Clear();
            txtTenHang.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            cbDonViTinh.DataBindings.Clear();
            cbLoaiHang.DataBindings.Clear();
            cbMaLoaiHang.DataBindings.Clear();
         

            txtMatHang.DataBindings.Add(new Binding("Text", matHangDgv.DataSource, "maHang"));
            txtTenHang.DataBindings.Add(new Binding("Text", matHangDgv.DataSource, "tenMatHang"));
            cbMaLoaiHang.DataBindings.Add(new Binding("Text", matHangDgv.DataSource, "maLoaiHang"));
            txtDonGia.DataBindings.Add(new Binding("Text", matHangDgv.DataSource, "donGia"));
            cbLoaiHang.DataBindings.Add(new Binding("Text", matHangDgv.DataSource, "loaiHang"));
            cbDonViTinh.DataBindings.Add(new Binding("Text", matHangDgv.DataSource, "donViTinh"));
            
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            string mathangID = txtMatHang.Text;
            MATHANG mathang = db.MATHANGs.Where(p => p.MaHang == mathangID).SingleOrDefault();
            if (mathang == null)
            {
                MATHANG p = new MATHANG()
                {
                    MaHang = mathangID,
                    TenMatHang = txtTenHang.Text,
                    MaLoaiHang = cbMaLoaiHang.Text,
                    DonViTinh = cbDonViTinh.Text,
                    DonGia = double.Parse(txtDonGia.Text),
                    LoaiHang = cbLoaiHang.Text,

                };
                db.MATHANGs.Add(p);
                db.SaveChanges();
                LoadDataMatHang();
                MessageBox.Show("Thêm đại lý thành công");
            }
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            string mathangID = txtMatHang.Text;
            MATHANG mathang = db.MATHANGs.Where(p => p.MaHang == mathangID).SingleOrDefault();

            if (mathang != null)
            {
                db.MATHANGs.Remove(mathang);
                db.SaveChanges();
                LoadDataMatHang();
                MessageBox.Show("Delete product successully");

            }
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            string mathangID = txtMatHang.Text;
            MATHANG mathang = db.MATHANGs.Where(p => p.MaHang == mathangID).SingleOrDefault();
            if (mathang != null)
            {

                mathang.MaHang = mathangID;
                mathang.TenMatHang = txtTenHang.Text;
                mathang.MaLoaiHang = cbMaLoaiHang.Text;
                mathang.LoaiHang = cbLoaiHang.Text;
                mathang.DonGia = double.Parse(txtDonGia.Text);
                mathang.DonViTinh = cbDonViTinh.Text;

                //product.Product_CategoryID = categoryID;
                //product.Product_Name = cbProductName.SelectedValue.ToString();
                //product.Product_Price = int.Parse(txtPrice.Text);
                //product.Product_Status = cxActiveProduct.Checked;


                db.SaveChanges();
                LoadDataMatHang();
                MessageBox.Show("Update product successully");

            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {

            string mathangID = txtMatHang.Text;
            var res = from p in db.MATHANGs
                      where p.MaHang.Contains(mathangID)
                      select new
                      {
                          maHang = p.MaHang,
                          maLoaiHang = p.MaLoaiHang,
                          tenMatHang = p.TenMatHang,
                          loaiHang = p.LoaiHang,
                          donViTinh = p.DonViTinh,
                          donGia = p.DonGia,
                      };
            ControlMatHang_DataSource(res.ToList());
            MessageBox.Show("Found " + res.Count().ToString() + " result !");
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            var data = from p in db.MATHANGs
                       select new
                       {
                           maHang = p.MaHang,
                           maLoaiHang = p.MaLoaiHang,
                           tenMatHang = p.TenMatHang,
                           loaiHang = p.LoaiHang,
                           donViTinh = p.DonViTinh,
                           donGia = p.DonGia,
                       };
            ControlMatHang_DataSource(data.ToList());
            matHang_DataBinding();
        }
    }
}
