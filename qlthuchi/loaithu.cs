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
    public partial class floaithu : Form
    {
        BindingSource loaithu = new BindingSource();
        public SqlCommand cmd;
        public floaithu()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            dtgvloaithu.DataSource = loaithu;
            loadloaithu();
            bindingloaithu();
        }
        void loadloaithu()
        {
            string query = "select id_loaithu as [mã loại thu], tenloaithu as [tên loại thu] from loaithu";
            DAO.DataProvider provider = new DAO.DataProvider();
            loaithu.DataSource = provider.ExecuteQuery(query);
        }
        void bindingloaithu()
        {
            txtidloaithu.DataBindings.Add(new Binding("text", dtgvloaithu.DataSource, "mã loại thu", true, DataSourceUpdateMode.Never));
            txttypethu.DataBindings.Add(new Binding("text", dtgvloaithu.DataSource, "tên loại thu", true, DataSourceUpdateMode.Never));
        }
        void insertloaithu()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into loaithu values(@tenloaithu)";
            //cmd.Parameters.AddWithValue("@id_loaithu", txtidloaithu.Text.Trim());
            cmd.Parameters.AddWithValue("@tenloaithu", txttypethu.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("thêm loại thu thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadloaithu();
            }
            else
            {
                MessageBox.Show("thêm loại thu thất bại","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            /*int nhaploaithu;
            try
            {
                nhaploaithu = int.Parse(txtidloaithu.Text);
                
            }
            catch
            {
                MessageBox.Show("nhập sai kiểu dữ liệu", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
            insertloaithu();
        }
        void updateloaithu()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = @"update thu set id_thu = @id_thu,ngaythu = @ngaythu,tienthu = @tienthu,motathu = @motathu,id_user = @id_user, id_loaithu = @id_loaithu where id_loaithu=@id_loaithu";
            cmd.CommandText = @"update loaithu set tenloaithu = @tenloaithu where id_loaithu = @id_loaithu";
            //cmd.CommandText = @"update thu set id_loaithu = @id_loaithu where id_loaithu=@id_loaithu";
            cmd.Parameters.AddWithValue("@id_loaithu", txtidloaithu.Text.Trim());
            cmd.Parameters.AddWithValue("@tenloaithu", txttypethu.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("cập nhật loại thu thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadloaithu();
            }
            else
            {
                MessageBox.Show("cập nhật loại thu thất bại","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            updateloaithu();
        }
     
        private void btnback_Click(object sender, EventArgs e)
        {
            fExpensemanagement fe = new fExpensemanagement();
            this.Hide();
            fe.ShowDialog();
            this.Close();
        }
    }
}
