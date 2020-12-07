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
    public partial class br : Form
    {
        public br()
        {
            InitializeComponent();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoDS z = new BaoCaoDS();
            z.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaoCao v = new BaoCao();
            v.Show();
            this.Hide();
        }
    }
}
