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
    public partial class BaoCaoDS : Form
    {
        QLDaiLyEntities3 db = new QLDaiLyEntities3();
        public BaoCaoDS()
        {
            InitializeComponent();
            LoadDataDoanhSo();
        }


        private void ControlDoanhSo_DataSource(object data)
        {
            bcdsDgv.DataSource = data;
        }

        private void LoadDataDoanhSo()
        {
            var data = from p in db.CTBAOCAODOANHSOes
                       select new
                       {
                           maCTBCDS = p.MaCTBCDS,
                           maBCDS = p.MaBCDS,
                           maLoaiHang = p.MaLoaiHang,
                           triGia = p.TriGia,
                           tiLe = p.TiLe
                       };
            ControlDoanhSo_DataSource(data.ToList());
            BaoCaoDoanhSo_DataBinding();

        }

        private void BaoCaoDoanhSo_DataBinding()
        {
            txtCTBCDS.DataBindings.Clear();
            txtBCDS.DataBindings.Clear();
            cbMaHang.DataBindings.Clear();
            txtTrigia.DataBindings.Clear();
            txtTiLe.DataBindings.Clear();

            txtCTBCDS.DataBindings.Add(new Binding("Text", bcdsDgv.DataSource, "maCTBCDS"));
            txtBCDS.DataBindings.Add(new Binding("Text", bcdsDgv.DataSource, "maBCDS"));
            cbMaHang.DataBindings.Add(new Binding("Text", bcdsDgv.DataSource, "maLoaiHang"));
            txtTrigia.DataBindings.Add(new Binding("Text", bcdsDgv.DataSource, "triGia"));
            txtTiLe.DataBindings.Add(new Binding("Text", bcdsDgv.DataSource, "tiLe"));
        }

        private void ThemBaoCao_Click(object sender, EventArgs e)
        {
            string doanhsoID = txtCTBCDS.Text;
            CTBAOCAODOANHSO doanhso = db.CTBAOCAODOANHSOes.Where(p => p.MaCTBCDS == doanhsoID).SingleOrDefault();

            if (doanhso != null)
            {
                MessageBox.Show("Mã báo cáo đã tồn tại");
                return;
            }
  


            if (doanhso == null)

            {
                CTBAOCAODOANHSO p = new CTBAOCAODOANHSO()
                {
                    MaCTBCDS = doanhsoID,
                    MaBCDS = txtBCDS.Text,
                    MaLoaiHang = cbMaHang.Text,
                    TriGia = int.Parse(txtTrigia.Text),
                    TiLe = Double.Parse(txtTiLe.Text),


                };
                db.CTBAOCAODOANHSOes.Add(p);
                db.SaveChanges();
                LoadDataDoanhSo();
                MessageBox.Show("Thêm báo cáo thành công");
            }
        }

        private void XoaBaoCao_Click(object sender, EventArgs e)
        {
            string doanhsoID = txtCTBCDS.Text;
            CTBAOCAODOANHSO doanhso = db.CTBAOCAODOANHSOes.Where(p => p.MaCTBCDS == doanhsoID).SingleOrDefault();

            if (doanhso != null)
            {
                db.CTBAOCAODOANHSOes.Remove(doanhso);
                db.SaveChanges();
                LoadDataDoanhSo();
                MessageBox.Show("Xoá đại lý thành công");

            }
        }

        private void SuaBaoCao_Click(object sender, EventArgs e)
        {
            string doanhsoID = txtCTBCDS.Text;
            CTBAOCAODOANHSO doanhso = db.CTBAOCAODOANHSOes.Where(p => p.MaCTBCDS == doanhsoID).SingleOrDefault();
            if (doanhso == null)
            {
                MessageBox.Show("Mã báo cáo không tồn tại");
                return;
            }

            else
            {

                doanhso.MaCTBCDS = doanhsoID;
                doanhso.MaBCDS = txtBCDS.Text;
                doanhso.MaLoaiHang = cbMaHang.Text;
                doanhso.TriGia = int.Parse(txtTrigia.Text);
                doanhso.TiLe = double.Parse(txtTiLe.Text);
                db.SaveChanges();
                LoadDataDoanhSo();
                MessageBox.Show("Cập nhật báo cáo thành công");

            }
        }

        private void TraCuuBaoCao_Click(object sender, EventArgs e)
        {


            string doanhsoID = txtCTBCDS.Text;
            var res = from p in db.CTBAOCAODOANHSOes
                      where p.MaCTBCDS.Contains(doanhsoID)
                      select new
                      {
                          maCTBCDS = p.MaCTBCDS,
                          maBCDS = p.MaBCDS,
                          maLoaiHang = p.MaLoaiHang,
                          triGia = p.TriGia,
                          tiLe = p.TiLe
                      };
            ControlDoanhSo_DataSource(res.ToList());

        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            var data = from p in db.CTBAOCAODOANHSOes
                       select new
                       {
                           maCTBCDS = p.MaCTBCDS,
                           maBCDS = p.MaBCDS,
                           maLoaiHang = p.MaLoaiHang,
                           triGia = p.TriGia,
                           tiLe = p.TiLe
                       };
            ControlDoanhSo_DataSource(data.ToList());
            BaoCaoDoanhSo_DataBinding();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }
    }
}
