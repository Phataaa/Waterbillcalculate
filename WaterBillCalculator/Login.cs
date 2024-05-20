using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBillCalculator
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private bool Authenticate(string username, string password)
        {
            // Kiểm tra xác thực tại đây
            // Đây chỉ là một ví dụ đơn giản, bạn nên thay thế bằng phương thức kiểm tra thực tế
            return (username == "admin" && password == "123456");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra xác thực
            if (Authenticate(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                TrangChu trang = new TrangChu();
                trang.ShowDialog();
                this.Dispose();
                // Thực hiện các hành động sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác!");
            }
        }
    }
}
