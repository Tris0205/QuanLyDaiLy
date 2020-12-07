using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaiLy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btn_Agency_Click(object sender, EventArgs e)
        {
            DaiLy d = new DaiLy();
            d.Show();
            this.Hide();
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            MatHang m = new MatHang();
            m.Show();
            this.Hide();
        }

        private void btn_Release_Click(object sender, EventArgs e)
        {
            XuatHang x = new XuatHang();
            x.Show();
            this.Hide();
        }

        private void btn_Money_Click(object sender, EventArgs e)
        {
            ThuTien t = new ThuTien();
            t.Show();
            this.Hide();
        }

        private void btn_Debt_Click(object sender, EventArgs e)
        {
            ThuNo tn = new ThuNo();
            tn.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Hide();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100012907031919");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "THÔNG BÁO"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaoCao i = new BaoCao();
            i.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuyDinh g = new QuyDinh();
            g.Show();
            this.Hide();
        }
    }
}
