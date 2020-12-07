using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using QuanLyDaiLy.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class XuatHang : Form
    {
        QLDaiLyEntities3 db = new QLDaiLyEntities3();
        public XuatHang()
        {
            InitializeComponent();
            LoadDataPhieuXuatHang();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
        private void ControlPhieuXuatHang_DataSource(object data)
        {
            phieuXuatHangDgv.DataSource = data;
        }

        private void LoadDataPhieuXuatHang()
        {
            var data = from p in db.PHIEUXUATHANGs
                       select new
                       {
                           maXuatHang = p.MaXuatHang,
                           maDaiLy = p.MaDaiLy,
                           maHang = p.MaHang,
                           tenMatHang = p.TenMatHang,
                           donViTinh = p.DonViTinh,
                           soLuong = p.SoLuong,
                           donGia = p.DonGia,
                           thanhTien = p.ThanhTien,
                           ngayLapPhieu = p.NgayLapPhieu,
                           tongTien = p.TongTien,
                           soTienTra = p.SoTienTra

                       };
            ControlPhieuXuatHang_DataSource(data.ToList());
            PhieuXuatHang_DataBinding();

        }

        private void PhieuXuatHang_DataBinding()
        {
            txtMaXuatHang.DataBindings.Clear();
            txtMaDaiLy.DataBindings.Clear();
            txtMaHang.DataBindings.Clear();
            txtTenMatHang.DataBindings.Clear();
            cbDonViTinh.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtThanhTien.DataBindings.Clear();
            txtNgayLapPhieu.DataBindings.Clear();
            txtTongTien.DataBindings.Clear();
            txtSoTienTra.DataBindings.Clear();

            txtMaXuatHang.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "maXuatHang"));
            txtMaDaiLy.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "maDaiLy"));
            txtMaHang.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "maHang"));
            txtTenMatHang.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "tenMatHang"));
            cbDonViTinh.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "donViTinh"));
            txtSoLuong.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "soLuong"));
            txtDonGia.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "donGia"));
            txtThanhTien.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "thanhTien"));
            txtNgayLapPhieu.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "ngayLapPhieu"));
            txtTongTien.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "tongTien"));
            txtSoTienTra.DataBindings.Add(new Binding("Text", phieuXuatHangDgv.DataSource, "soTienTra"));
        }

        private void btnThemPhieuXuatHang_Click(object sender, EventArgs e)
        {
            string xuathangID = txtMaXuatHang.Text;
            PHIEUXUATHANG xuathang  = db.PHIEUXUATHANGs.Where(p => p.MaXuatHang == xuathangID).SingleOrDefault();

            if (xuathang != null)
            {
                MessageBox.Show("Mã phiếu xuất hàng đã tồn tại");
                return;
            }
            if (xuathang == null)
            {
                PHIEUXUATHANG p = new PHIEUXUATHANG()
                {
                    MaXuatHang = xuathangID,
                    MaDaiLy = txtMaDaiLy.Text,
                    MaHang = txtMaHang.Text,
                    TenMatHang = txtTenMatHang.Text,
                    DonViTinh = cbDonViTinh.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = int.Parse(txtDonGia.Text),
                    ThanhTien = int.Parse(txtThanhTien.Text),
                    NgayLapPhieu = DateTime.Parse(txtNgayLapPhieu.Text),
                    TongTien = int.Parse(txtTongTien.Text),
                    SoTienTra = int.Parse(txtSoTienTra.Text),

                };
                db.PHIEUXUATHANGs.Add(p);
                db.SaveChanges();
                LoadDataPhieuXuatHang();
                MessageBox.Show("Thêm phiếu xuất hàng thành công");
            }
        }

        private void btnXoaPhieuXuatHang_Click(object sender, EventArgs e)
        {
            string xuathangID = txtMaXuatHang.Text;
            PHIEUXUATHANG xuathang = db.PHIEUXUATHANGs.Where(p => p.MaXuatHang == xuathangID).SingleOrDefault();

            if (xuathang != null)
            {
                db.PHIEUXUATHANGs.Remove(xuathang);
                db.SaveChanges();
                LoadDataPhieuXuatHang();
                MessageBox.Show("Xoá phiếu xuất hàng thành công");

            }
        }

        private void btnSuaPhieuXuatHang_Click(object sender, EventArgs e)
        {
            string xuathangID = txtMaXuatHang.Text;
            PHIEUXUATHANG xuathang = db.PHIEUXUATHANGs.Where(p => p.MaXuatHang == xuathangID).SingleOrDefault();
            if (xuathang == null)
            {
                MessageBox.Show("Mã phiếu xuất hàng không tồn tại");
                return;
            }
            if (xuathang != null)
            {

                xuathang.MaXuatHang = xuathangID;
                xuathang.MaDaiLy = txtMaDaiLy.Text;
                xuathang.MaHang = txtMaHang.Text;
                xuathang.TenMatHang = txtTenMatHang.Text;
                xuathang.DonViTinh = cbDonViTinh.Text;
                xuathang.SoLuong = int.Parse(txtSoLuong.Text);
                xuathang.DonGia = int.Parse(txtDonGia.Text);
                xuathang.ThanhTien = int.Parse(txtThanhTien.Text);
                xuathang.NgayLapPhieu = DateTime.Parse(txtNgayLapPhieu.Text);
                xuathang.TongTien = int.Parse(txtTongTien.Text);
                xuathang.SoTienTra = int.Parse(txtSoTienTra.Text);


                db.SaveChanges();
                LoadDataPhieuXuatHang();
                MessageBox.Show("Cập nhật phiếu xuất hàng thành công");

            }
        }

        private void btnTraCuuPhieuXuatHang_Click(object sender, EventArgs e)
        {
            string xuathangID = txtMaXuatHang.Text;
            var res = from p in db.PHIEUXUATHANGs
                      where p.MaXuatHang.Contains(xuathangID)
                      select new
                      {
                          maXuatHang = p.MaXuatHang,
                          maDaiLy = p.MaDaiLy,
                          maHang = p.MaHang,
                          tenMatHang = p.TenMatHang,
                          donViTinh = p.DonViTinh,
                          soLuong = p.SoLuong,
                          donGia = p.DonGia,
                          thanhTien = p.ThanhTien,
                          ngayLapPhieu = p.NgayLapPhieu,
                          tongTien = p.TongTien,
                          soTienTra = p.SoTienTra
                      };
            ControlPhieuXuatHang_DataSource(res.ToList());
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            var data = from p in db.PHIEUXUATHANGs
                       select new
                       {

                           maXuatHang = p.MaXuatHang,
                           maDaiLy = p.MaDaiLy,
                           maHang = p.MaHang,
                           tenMatHang = p.TenMatHang,
                           donViTinh = p.DonViTinh,
                           soLuong = p.SoLuong,
                           donGia = p.DonGia,
                           thanhTien = p.ThanhTien,
                           ngayLapPhieu = p.NgayLapPhieu,
                           tongTien = p.TongTien,
                           soTienTra = p.SoTienTra
                       };
            ControlPhieuXuatHang_DataSource(data.ToList());
            PhieuXuatHang_DataBinding();
        }
    }
}
