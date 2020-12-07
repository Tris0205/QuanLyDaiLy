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
    public partial class DaiLy : Form
    {
        QLDaiLyEntities3 db = new QLDaiLyEntities3();

        public string MaDaiLy { get; private set; }

        public DaiLy()
        {
            InitializeComponent();
            LoadDataDaiLy();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            MainForm m = new MainForm();
            m.Show();
            this.Hide();
        }

        private void ControlDaiLy_DataSource(object data)
        {
            DaiLyDatagridview.DataSource = data;
        }

        private void LoadDataDaiLy()
        {
            var data = from p in db.DAILies
                       select new
                       {
                           maDaiLy = p.MaDaiLy,
                           tenDaiLy = p.TenDaiLy,
                           maLoaiDaiLy = p.MaLoaiDaiLy,
                           sdt = p.SDT,
                           diaChi = p.DiaChi,
                           quan = p.Quan,
                           ngayTiepNhan = p.NgayTiepNhan

                       };
            ControlDaiLy_DataSource(data.ToList());
            DaiLy_DataBinding();
           
        }
        
        private void DaiLy_DataBinding()
        {
            txtMaDaiLy.DataBindings.Clear();
            txtTenDaiLy.DataBindings.Clear();
            cbLoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            cbQuan.DataBindings.Clear();
            txtNgayTiepNhan.DataBindings.Clear();

            txtMaDaiLy.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "maDaiLy"));
            txtTenDaiLy.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "tenDaiLy"));
            cbLoai.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "maLoaiDaiLy"));
            txtSoDienThoai.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "sdt"));
            txtDiaChi.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "diaChi"));
            cbQuan.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "quan"));
            txtNgayTiepNhan.DataBindings.Add(new Binding("Text", DaiLyDatagridview.DataSource, "ngayTiepNhan"));
        }

        private void ThemDaiLy_Click(object sender, EventArgs e)
        {
            //string dailyID = txtMaDaiLy.Text;
            //DAILY daily = db.DAILies.Where(p => p.MaDaiLy == dailyID).SingleOrDefault();
            //if (daily != null)
            //{
            //    MessageBox.Show("Mã đại lý đã tồn tại");
            //    return;
            //}
            //else if (String.IsNullOrEmpty(MaDaiLy))
            //{
            //    MessageBox.Show("Mã đại lý không được để trống");
            //    return;
            //}
            //else
            //{
            //    daily = new DAILY();
            //    daily.MaDaiLy = txtMaDaiLy.Text;
            //    daily.MaLoaiDaiLy = int.Parse(cbLoai.Text);
            //    daily.DiaChi = txtDiaChi.Text;
            //    daily.Quan = cbQuan.Text;
            //    daily.SDT = txtSoDienThoai.Text;
            //    daily.NgayTiepNhan = DateTime.Parse(txtNgayTiepNhan.Text);
            //    db.DAILies.Add(daily);
            //    db.SaveChanges();
            //    LoadDataDaiLy();
            //    MessageBox.Show("Thêm đại lý thành công");
            //}
            string dailyID = txtMaDaiLy.Text;
            DAILY daily = db.DAILies.Where(p => p.MaDaiLy == dailyID).SingleOrDefault();
            if(daily != null)
            {
                MessageBox.Show("Mã đại lý đã tồn tại");
                return;
            }

           
            if (daily == null)

            {
                DAILY p = new DAILY()
                {
                    MaDaiLy = dailyID,
                    TenDaiLy = txtTenDaiLy.Text,
                    MaLoaiDaiLy = int.Parse(cbLoai.Text),
                    SDT = txtSoDienThoai.Text,
                    DiaChi = txtDiaChi.Text,
                    Quan = cbQuan.Text,
                    NgayTiepNhan = DateTime.Parse(txtNgayTiepNhan.Text)

                };
                db.DAILies.Add(p);
                db.SaveChanges();
                LoadDataDaiLy();
                MessageBox.Show("Thêm đại lý thành công");
            }
        }
        

        private void XoaDaiLy_Click(object sender, EventArgs e)
        {
            string dailyID = txtMaDaiLy.Text;
            DAILY daily = db.DAILies.Where(p => p.MaDaiLy == dailyID).SingleOrDefault();

            if (daily != null)
            {
                db.DAILies.Remove(daily);
                db.SaveChanges();
                LoadDataDaiLy();
                MessageBox.Show("Xoá đại lý thành công");

            }
        }

        private void SuaDaiLy_Click(object sender, EventArgs e)
        {
            string dailyID = txtMaDaiLy.Text;
            DAILY daily = db.DAILies.Where(p => p.MaDaiLy == dailyID).SingleOrDefault();
            if (daily == null)
            {
                MessageBox.Show("Mã đại lý không tồn tại");
                return;
            }

            else
            {

                daily.MaDaiLy = dailyID;
                daily.TenDaiLy = txtTenDaiLy.Text;
                daily.MaLoaiDaiLy = int.Parse(cbLoai.Text);
                daily.SDT = txtSoDienThoai.Text;
                daily.DiaChi = txtDiaChi.Text;
                daily.Quan = cbQuan.Text;
                daily.NgayTiepNhan = DateTime.Parse(txtNgayTiepNhan.Text);

                db.SaveChanges();
                LoadDataDaiLy();
                MessageBox.Show("Cập nhật đại lý thành công");

            }
        }

        private void TraCuuDaiLy_Click(object sender, EventArgs e)
        {
            

                string dailyID = txtMaDaiLy.Text;
                var res = from p in db.DAILies
                          where p.MaDaiLy.Contains(dailyID)
                          select new
                          {
                              maDaiLy = p.MaDaiLy,
                              tenDaiLy = p.TenDaiLy,
                              maLoaiDaiLy = p.MaLoaiDaiLy,
                              sdt = p.SDT,
                              diaChi = p.DiaChi,
                              quan = p.Quan,
                              ngayTiepNhan = p.NgayTiepNhan
                          };
                ControlDaiLy_DataSource(res.ToList());

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var data = from p in db.DAILies
                       select new
                       {
                           maDaiLy = p.MaDaiLy,
                           tenDaiLy = p.TenDaiLy,

                           maLoaiDaiLy = p.MaLoaiDaiLy,
                           sdt = p.SDT,
                           diaChi = p.DiaChi,
                           quan = p.Quan,
                           ngayTiepNhan = p.NgayTiepNhan
                       };
            ControlDaiLy_DataSource(data.ToList());
            DaiLy_DataBinding();
        }
    }
}
