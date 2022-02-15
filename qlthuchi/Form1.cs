using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlthuchi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!= System.Windows.Forms.DialogResult.OK)
            {
            e.Cancel = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Userinfo where id_user ='" + this.txtUserid.Text.Trim() + "'"
                + "and matkhau = '" + this.txtMatkhau.Text.Trim() + "'";
            cmd.Connection = conn;

            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (string.IsNullOrEmpty(txtUserid.Text))
            {
                MessageBox.Show("vui lòng nhập mã người dùng ","thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("vui lòng nhập mật khẩu","thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else if(rd.HasRows)
            {
                MessageBox.Show("đăng nhập thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                fExpensemanagement fe = new fExpensemanagement();
                this.Hide();
                fe.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("mã người dùng hoặc mật khẩu không đúng", "thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
