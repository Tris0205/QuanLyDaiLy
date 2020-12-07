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
    
    public partial class BaoCao : Form
    {
        QLDaiLyEntities3 db = new QLDaiLyEntities3();

        public string MaBaoCaoCongNo { get; private set; }

        public BaoCao()
        {
            InitializeComponent();
            LoadDataBaoCao();
        }

        private void ControlBaoCao_DataSource(object data)
        {
            baoCaoDgv.DataSource = data;
        }

        private void LoadDataBaoCao()
        {
            var data = from p in db.CTBAOCAOCONGNODAILies
                       select new
                       {
                           maBaoCaoCongNo = p.MaBaoCaoCongNo,
                           maBaoCao = p.MaBaoCao,
                           noDau = p.NoDau,
                           noCuoi = p.NoCuoi,
                           phatSinh = p.PhatSinh,
                           maCTPXH = p.MaCTPXH
                       };
            ControlBaoCao_DataSource(data.ToList());
            ThuTien_DataBinding();

        }


        private void ThuTien_DataBinding()
        {
            txtBaoCaoCongNo.DataBindings.Clear();
            txtMaBaoCao.DataBindings.Clear();
            txtNoDau.DataBindings.Clear();
            txtNoCuoi.DataBindings.Clear();
            txtPhiPhatSinh.DataBindings.Clear();
            txtMaXuatHangChiTiet.DataBindings.Clear();

            txtBaoCaoCongNo.DataBindings.Add(new Binding("Text", baoCaoDgv.DataSource, "maBaoCaoCongNo"));
            txtMaBaoCao.DataBindings.Add(new Binding("Text", baoCaoDgv.DataSource, "maBaoCao"));
            txtNoDau.DataBindings.Add(new Binding("Text", baoCaoDgv.DataSource, "noDau"));
            txtNoCuoi.DataBindings.Add(new Binding("Text", baoCaoDgv.DataSource, "noCuoi"));
            txtPhiPhatSinh.DataBindings.Add(new Binding("Text", baoCaoDgv.DataSource, "phatSinh"));
            txtMaXuatHangChiTiet.DataBindings.Add(new Binding("Text", baoCaoDgv.DataSource, "maCTPXH"));
        }

        private void btnThemBaoCao_Click(object sender, EventArgs e)
        {
            string baocaoID = txtBaoCaoCongNo.Text;
            CTBAOCAOCONGNODAILY baocao = db.CTBAOCAOCONGNODAILies.Where(p => p.MaBaoCaoCongNo == baocaoID).SingleOrDefault();
         
            if (baocao != null)
            {
                MessageBox.Show("Mã báo cáo đã tồn tại");
                return;
              
            }

            else
            {
                CTBAOCAOCONGNODAILY p = new CTBAOCAOCONGNODAILY()
                {
                    MaBaoCaoCongNo = baocaoID,
                    MaBaoCao = txtMaBaoCao.Text,
                    NoDau = int.Parse(txtNoDau.Text),
                    NoCuoi = int.Parse(txtNoCuoi.Text),
                    PhatSinh = int.Parse(txtPhiPhatSinh.Text),
                    MaCTPXH = txtMaXuatHangChiTiet.Text

                };
                db.CTBAOCAOCONGNODAILies.Add(p);
                db.SaveChanges();
                LoadDataBaoCao();
                MessageBox.Show("Thêm báo cáo thành công");
            }
        }

        private void btnXoaBaoCao_Click(object sender, EventArgs e)
        {
            string baocaoID = txtBaoCaoCongNo.Text;
            CTBAOCAOCONGNODAILY baocao = db.CTBAOCAOCONGNODAILies.Where(p => p.MaBaoCaoCongNo == baocaoID).SingleOrDefault();
            if (baocao != null)
            {
                db.CTBAOCAOCONGNODAILies.Remove(baocao);
                db.SaveChanges();
                LoadDataBaoCao();
                MessageBox.Show("Xoá báo cáo thành công");
            }
        }

        private void btnSuaBaoCao_Click(object sender, EventArgs e)
        {
            string baocaoID = txtBaoCaoCongNo.Text;
            CTBAOCAOCONGNODAILY baocao = db.CTBAOCAOCONGNODAILies.Where(p => p.MaBaoCaoCongNo == baocaoID).SingleOrDefault();

            if (baocao == null)
            {
                MessageBox.Show("Mã báo cáo không tồn tại");
                return;
            }
            if (baocao != null)
            {

                baocao.MaBaoCaoCongNo = baocaoID;
                baocao.MaBaoCao = txtMaBaoCao.Text;
                baocao.NoDau = int.Parse(txtNoDau.Text);
                baocao.NoCuoi = int.Parse(txtNoCuoi.Text);
                baocao.PhatSinh = int.Parse(txtPhiPhatSinh.Text);
                baocao.MaCTPXH = txtMaXuatHangChiTiet.Text;
                db.SaveChanges();
                LoadDataBaoCao();
                MessageBox.Show("Cập nhật báo cáo thành công");

            }
        }

        private void btnTraCuuBaoCao_Click(object sender, EventArgs e)
        {

            string baocaoID = txtBaoCaoCongNo.Text;
            var res = from p in db.CTBAOCAOCONGNODAILies
                      where p.MaBaoCaoCongNo.Contains(baocaoID)
                      select new
                      {
                          maBaoCaoCongNo = p.MaBaoCaoCongNo,
                          maBaoCao = p.MaBaoCao,
                          noDau = p.NoDau,
                          noCuoi = p.NoCuoi,
                          phatSinh = p.PhatSinh,
                          maCTPXH = p.MaCTPXH
                      };
            ControlBaoCao_DataSource(res.ToList());
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            var data = from p in db.CTBAOCAOCONGNODAILies
                       select new
                       {
                           maBaoCaoCongNo = p.MaBaoCaoCongNo,
                           maBaoCao = p.MaBaoCao,
                           noDau = p.NoDau,
                           noCuoi = p.NoCuoi,
                           phatSinh = p.PhatSinh,
                           maCTPXH = p.MaCTPXH
                       };
            ControlBaoCao_DataSource(data.ToList());
            ThuTien_DataBinding();
        }
    }
}
