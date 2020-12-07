using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using QuanLyDaiLy.DAL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class ThuTien : Form
    {
        QLDaiLyEntities3 db = new QLDaiLyEntities3();
        public ThuTien()
        {
            InitializeComponent();
            LoadDataThuTien();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void ControlThuTien_DataSource(object data)
        {
            thuTienDgv.DataSource = data;
        }

        private void LoadDataThuTien()
        {
            var data = from p in db.PHIEUTHUTIENs
                       select new
                       {
                           maThuTien = p.MaThuTien,
                           soTienThu = p.SoTienThu,
                           ngayThuTien = p.NgayThuTien,
                           tienConLai = p.TienConLai
                           

                       };
            ControlThuTien_DataSource(data.ToList());
            ThuTien_DataBinding();

        }

        private void ThuTien_DataBinding()
        {
            txtMaThuTien.DataBindings.Clear();
            txtNgayThuTien.DataBindings.Clear();
            txtSoTienThu.DataBindings.Clear();
            txtTienConLai.DataBindings.Clear();


            txtMaThuTien.DataBindings.Add(new Binding("Text", thuTienDgv.DataSource, "maThuTien"));
            txtNgayThuTien.DataBindings.Add(new Binding("Text", thuTienDgv.DataSource, "ngayThuTien"));
            txtSoTienThu.DataBindings.Add(new Binding("Text", thuTienDgv.DataSource, "soTienThu"));
            txtTienConLai.DataBindings.Add(new Binding("Text", thuTienDgv.DataSource, "tienConLai"));

        }

        private void btnThemThuTien_Click(object sender, EventArgs e)
        {
            string thutienID = txtMaThuTien.Text;
            PHIEUTHUTIEN thutien = db.PHIEUTHUTIENs.Where(p => p.MaThuTien == thutienID).SingleOrDefault();
            if (thutien != null)
            {
                MessageBox.Show("Mã thu tiền đã tồn tại");
                return;
            }
            if (thutien == null)
            {
                PHIEUTHUTIEN p = new PHIEUTHUTIEN()
                {
                    MaThuTien = thutienID,
                    NgayThuTien = DateTime.Parse(txtNgayThuTien.Text),
                    SoTienThu = int.Parse(txtSoTienThu.Text),
                    TienConLai = int.Parse(txtTienConLai.Text),

                };
                db.PHIEUTHUTIENs.Add(p);
                db.SaveChanges();
                LoadDataThuTien();
                MessageBox.Show("Thêm phiếu thu tiền thành công");
            }
        }

        private void btnXoaThuTien_Click(object sender, EventArgs e)
        {
            string thutienID = txtMaThuTien.Text;
            PHIEUTHUTIEN thutien = db.PHIEUTHUTIENs.Where(p => p.MaThuTien == thutienID).SingleOrDefault();

            if (thutien != null)
            {
                db.PHIEUTHUTIENs.Remove(thutien);
                db.SaveChanges();
                LoadDataThuTien();
                MessageBox.Show("Xoá phiếu thu tiền thành công");
            }
        }

        private void btnSuaThuTien_Click(object sender, EventArgs e)
        {
            string thutienID = txtMaThuTien.Text;
            PHIEUTHUTIEN thutien = db.PHIEUTHUTIENs.Where(p => p.MaThuTien == thutienID).SingleOrDefault();
            if (thutien == null)
            {
                MessageBox.Show("Mã thu tiền không tồn tại");
                return;
            }
            if (thutien != null)
            {

                thutien.MaThuTien = thutienID;
                thutien.NgayThuTien = DateTime.Parse(txtNgayThuTien.Text);
                thutien.SoTienThu = int.Parse(txtSoTienThu.Text);
                thutien.TienConLai =int.Parse(txtTienConLai.Text);
                db.SaveChanges();
                LoadDataThuTien();
                MessageBox.Show("Cập nhật phiếu thu tiền thành công");

            }
        }

        private void btnTraCuuThuTien_Click(object sender, EventArgs e)
        {
            string thutienID = txtMaThuTien.Text;
            var res = from p in db.PHIEUTHUTIENs
                      where p.MaThuTien.Contains(thutienID)
                      select new
                      {
                          maThuTien = p.MaThuTien,
                          soTienThu = p.SoTienThu,
                          ngayThuTien = p.NgayThuTien,
                          tienConLai = p.TienConLai
                      };
            ControlThuTien_DataSource(res.ToList());
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            var data = from p in db.PHIEUTHUTIENs
                       select new
                       {
                           maThuTien = p.MaThuTien,
                           soTienThu = p.SoTienThu,
                           ngayThuTien = p.NgayThuTien,
                           tienConLai = p.TienConLai
                       };
            ControlThuTien_DataSource(data.ToList());
            ThuTien_DataBinding();
        }
    }
}
