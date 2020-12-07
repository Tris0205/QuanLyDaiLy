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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Authentication()
        {
            string u = txt_User.Text;
            string p = txt_Pass.Text;
            if (u == "admin" && p == "admin")
            {
                MainForm f = new MainForm();
                f.Show();
                MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG","THÔNG BÁO");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "THÔNG BÁO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Authentication();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?", "THÔNG BÁO"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                Application.Exit();
            else { }
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            this.txt_Pass.PasswordChar = '*';
        }

 
    }
}
