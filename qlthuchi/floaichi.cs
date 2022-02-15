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
    public partial class floaichi : Form
    {
        BindingSource loaichi = new BindingSource();
        public SqlCommand cmd;
        public floaichi()
        {
            InitializeComponent();
            load();

        }
        void load()
        {
            dtgvloaichi.DataSource = loaichi;
            loadloaichi();
            bindingloaichi();
        }
        void loadloaichi()
        {
            string query = "select id_loaichi as [mã loại chi], tenloaichi as [tên loại chi] from loaichi";
            DAO.DataProvider provider = new DAO.DataProvider();
            loaichi.DataSource = provider.ExecuteQuery(query);
        }
        void bindingloaichi()
        {
            txtmaloaichi.DataBindings.Add(new Binding("text", dtgvloaichi.DataSource, "mã loại chi", true, DataSourceUpdateMode.Never));
            txttenlaoichi.DataBindings.Add(new Binding("text", dtgvloaichi.DataSource, "tên loại chi", true, DataSourceUpdateMode.Never));
        }
        void insertloaichi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"insert into loaichi values(@tenloaichi)";
            //cmd.Parameters.AddWithValue("@id_loaichi", txtmaloaichi.Text.Trim());
            cmd.Parameters.AddWithValue("@tenloaichi", txttenlaoichi.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("thêm loại chi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadloaichi();
            }
            else
            {
                MessageBox.Show("thêm loại thu thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //{
                //if (row > 0)
                   // MessageBox.Show("thêm loại chi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //loadloaichi();
            //}
            //else
            //{
               // MessageBox.Show("thêm loại chi thất bại","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int nhaploaichi;
            try
            {
                nhaploaichi = int.Parse(txtmaloaichi.Text);
                
            }
            catch
            {
                MessageBox.Show("nhập sai kiểu dữ liệu", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
            insertloaichi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fExpensemanagement fe = new fExpensemanagement();
            this.Hide();
            fe.ShowDialog();
            this.Close();

        }
        void updateloaichi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"update loaichi set tenloaichi = @tenloaichi where id_loaichi = @id_loaichi";
            cmd.Parameters.AddWithValue("@id_loaichi", txtmaloaichi.Text.Trim());
            cmd.Parameters.AddWithValue("@tenloaichi", txttenlaoichi.Text.Trim());
            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("cập nhật loại chi thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                loadloaichi();
            }
            else
            {
                MessageBox.Show("cập nhật loại chi thất bại","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateloaichi();
        }
        
    }
}
