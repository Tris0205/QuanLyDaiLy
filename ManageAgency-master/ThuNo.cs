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
    public partial class ThuNo : Form
    {
        QLDaiLyEntities3 db = new QLDaiLyEntities3();
        public ThuNo()
        {
            InitializeComponent();
            LoadDataThuTienNo();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void ControlThuTien_DataSource(object data)
        {
            tienNoDgv.DataSource = data;
        }

        private void LoadDataThuTienNo()
        {
            var data = from p in db.PHIEUTHUTIENNOes
                       select new
                       {
                           maPhieu = p.MaPhieu,
                           maDaiLy = p.MaDaiLy,
                           maThuTien = p.MaThuTien,
                           soTienThu = p.SoTienThu,                 
                           tienConLai = p.TienConLai


                       };
            ControlThuTien_DataSource(data.ToList());
            DaiLy_DataBinding();

        }

        private void DaiLy_DataBinding()
        {
            txtMaThuTien.DataBindings.Clear();
            cbDaiLy.DataBindings.Clear();
            txtSoTienThu.DataBindings.Clear();
            txtTienConLai.DataBindings.Clear();
            txtMaPhieu.DataBindings.Clear();

            cbDaiLy.DataBindings.Add(new Binding("Text", tienNoDgv.DataSource, "maDaiLy"));
            txtMaThuTien.DataBindings.Add(new Binding("Text", tienNoDgv.DataSource, "maThuTien"));
            txtMaPhieu.DataBindings.Add(new Binding("Text", tienNoDgv.DataSource, "maPhieu"));
            txtSoTienThu.DataBindings.Add(new Binding("Text", tienNoDgv.DataSource, "soTienThu"));
            txtTienConLai.DataBindings.Add(new Binding("Text", tienNoDgv.DataSource, "tienConLai"));

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tiennoID = txtMaPhieu.Text;
            PHIEUTHUTIENNO tienno = db.PHIEUTHUTIENNOes.Where(p => p.MaPhieu == tiennoID).SingleOrDefault();
            if (tienno != null)
            {
                MessageBox.Show("Mã thu nợ đã tồn tại");
                return;
            }
            if (tienno == null)
            {
                PHIEUTHUTIENNO p = new PHIEUTHUTIENNO()
                {

                    MaPhieu = tiennoID,
                    MaDaiLy = cbDaiLy.Text,
                    MaThuTien = txtMaThuTien.Text,
                    SoTienThu = int.Parse(txtSoTienThu.Text),
                    TienConLai = int.Parse(txtTienConLai.Text),

                };
                db.PHIEUTHUTIENNOes.Add(p);
                db.SaveChanges();
                LoadDataThuTienNo();
                MessageBox.Show("Thêm phiếu thu tiền nợ thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tiennoID = txtMaPhieu.Text;
            PHIEUTHUTIENNO tienno = db.PHIEUTHUTIENNOes.Where(p => p.MaPhieu == tiennoID).SingleOrDefault();

            if (tienno != null)
            {
                db.PHIEUTHUTIENNOes.Remove(tienno);
                db.SaveChanges();
                LoadDataThuTienNo();
                MessageBox.Show("Xoá phiếu thu tiền thành công");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tiennoID = txtMaPhieu.Text;
            PHIEUTHUTIENNO tienno = db.PHIEUTHUTIENNOes.Where(p => p.MaPhieu == tiennoID).SingleOrDefault();
            if (tienno == null)
            {
                MessageBox.Show("Mã thu tiền nợ tồn tại");
                return;
            }
            if (tienno != null)
            {

                tienno.MaPhieu = tiennoID;
                tienno.MaDaiLy = cbDaiLy.Text;
                tienno.MaThuTien = txtMaThuTien.Text;
                tienno.SoTienThu = int.Parse(txtSoTienThu.Text);
                tienno.TienConLai = int.Parse(txtTienConLai.Text);
                db.SaveChanges();
                LoadDataThuTienNo();
                MessageBox.Show("Cập nhật phiếu thu tiền thành công");
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            string tiennoID = txtMaPhieu.Text;
            var res = from p in db.PHIEUTHUTIENNOes
                      where p.MaPhieu.Contains(tiennoID)
                      select new
                      {
                          maPhieu = p.MaPhieu,
                          maThuTien = p.MaThuTien,
                          soTienThu = p.SoTienThu,
                          maDaiLy = p.MaDaiLy,
                          tienConLai = p.TienConLai
                      };
            ControlThuTien_DataSource(res.ToList());
            MessageBox.Show("Found " + res.Count().ToString() + " result !");
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            var data = from p in db.PHIEUTHUTIENNOes
                       select new
                       {
                           maPhieu = p.MaPhieu,
                           maThuTien = p.MaThuTien,
                           soTienThu = p.SoTienThu,
                           maDaiLy = p.MaDaiLy,
                           tienConLai = p.TienConLai


                       };
            ControlThuTien_DataSource(data.ToList());
            DaiLy_DataBinding();
        }
    }
}
