using qlthuchi.DAO;
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
    public partial class fExpensemanagement : Form
    {
        public SqlCommand cmdd;
        BindingSource thulist = new BindingSource();
        BindingSource tk = new BindingSource();
        //BindingSource listchi = new BindingSource();

        public fExpensemanagement()
        {
            InitializeComponent();
            load();
            //thongtinthu();
            //thongtinchi();
            thag();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        private void thongtinthu()
        {
            //string query = "execute USP_infothu";
            //DataProvider provider = new DataProvider();
            //thulist.DataSource = provider.ExecuteQuery(query);
            //thulist.DataSource = THU.Instance.getlistthu();
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"execute USP_infothu";
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //thongtinthu();
            //bindingthu();
        }
        void thongtinchi()
        {
            //string query8 = "exec USP_chiinfo";
            //DataProvider provider = new DataProvider();
            //dataGridView2.DataSource = provider.ExecuteQuery(query8);

            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"exec USP_chiinfo";
            //cmdd.Parameters.AddWithValue("@tenloaichi", tenloaichi);
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            //listchi.DataSource = dt;
            this.dataGridView2.DataSource = dt;
            dataGridView2.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            conn.Close();
            //listchi.DataSource = dataGridView2.DataSource;
            //listchi.DataSource = dt;

        }

        public void btnxem2_Click(object sender, EventArgs e)
        {
            //thongtinchi();
            //bindingchi();
        }
        /*private void thongtintk()
        {
            string query = "exec USP_thongtintk";
            DataProvider provider = new DataProvider();
            tk.DataSource = provider.ExecuteQuery(query);
        }*/

        /*private void btntttaikhoan_Click(object sender, EventArgs e)
        {
            thongtintk();
            bindingtk();
        }*

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            fLogin fl = new fLogin();
            this.Hide();
            fl.ShowDialog();
            this.Close();
        }

        /*void taicb3(ComboBox cb)
        {
            cb.DataSource = danhmucthuDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }*/
        void taicb(ComboBox cb)
        {
            cb.DataSource = loaithu.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void taicb2(ComboBox cb)
        {
            cb.DataSource = danhmucchidao.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"delete from chi where id_chi = @id_chi";
            cmdd.Parameters.AddWithValue("@id_chi", txtmachi.Text);
            //cmd.Parameters.AddWithValue("@tenloaithu", txttypethu.Text.Trim());
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("xóa khoản chi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinchi();
            }
            else
            {
                MessageBox.Show("xóa khoản chi thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindingchi2();
            /*int id = Convert.ToInt32(txtmachi.Text);
            if (CHI.Instance.Deletechi(id))
            {
                MessageBox.Show("xóa khoản chi thành công","thông báo");
                thongtinchi();
            }
            else
            {
                MessageBox.Show("xóa khoản chi thất bại","thông báo");
            }*/

        }
        private void txtmachi_TextChanged(object sender, EventArgs e)
        {

        }
        public void bindingchi()
        {
            txtmachi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mã chi", true, DataSourceUpdateMode.Never));
            txttienchi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "tiền chi", true, DataSourceUpdateMode.Never));
            cb2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "tên khoản chi", true, DataSourceUpdateMode.Never));
            dateTimePicker2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "ngày chi", true, DataSourceUpdateMode.Never));
            txtmotachi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mô tả chi", true, DataSourceUpdateMode.Never));
            txtiduser2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mã tài khoản", true, DataSourceUpdateMode.Never));
            txtmaloaichi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mã loại chi", true, DataSourceUpdateMode.Never));
        }
        /*public void bindingthu()
        {
            txtmathu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mã thu",true,DataSourceUpdateMode.Never));
            txttienthu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "tiền thu",true,DataSourceUpdateMode.Never));
            cb1.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "tên khoản thu",true,DataSourceUpdateMode.Never));
            dateTimePicker1.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "ngày thu",true,DataSourceUpdateMode.Never));
            txtmotathu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mô tả thu",true,DataSourceUpdateMode.Never));
            txtiduser.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mã tài khoản", true, DataSourceUpdateMode.Never));
            txtmaloaithu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mã loại thu", true, DataSourceUpdateMode.Never));
        }*/
        /*public void bindingtk()
        {
            textBox9.DataBindings.Add(new Binding("text", dataGridView3.DataSource, "mã User", true, DataSourceUpdateMode.Never));
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"delete from thu where id_thu = @id_thu";
            cmdd.Parameters.AddWithValue("@id_thu", txtmathu.Text);
            //cmd.Parameters.AddWithValue("@tenloaithu", txttypethu.Text.Trim());
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("xóa khoản thu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinthu();
            }
            else
            {
                MessageBox.Show("xóa khoản thu thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bindingthu2();
            /*int id = Convert.ToInt32(txtmathu.Text);
            if (THU.Instance.Deletethu(id))
            {
                MessageBox.Show("xóa khoản thu thành công", "thông báo");
            }
            else
            {
                MessageBox.Show("xóa khoản thu thất bại", "thông báo");
            }
            thongtinthu();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int nhapthu;
            try
            {
                nhapthu = int.Parse(txtmathu.Text);
               
                
            }
            catch
            {
                MessageBox.Show("nhập sai kiểu dữ liệu", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
            //int ns = int.Parse(txtngansach.Text);
            //if (ns < 1000000)
            //{
            //MessageBox.Show("số dư trong trài khoản đang ở mức báo động, không nên tiếp tục chi tiêu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
            //{
            // MessageBox.Show("thêm khoản chi thành công");
            //}
            insertthu();
            //updatecongthu();
            congtien();
            updatecongthu();
            thongtinthu();
            thongtinchi();
            bindingthu2();
            bindingchi2();
            //int ngansach = int.Parse(txtngansach.Text);
            //int tienthu = int.Parse(txttienthu.Text);
            //Int64 congtien;
            //congtien = ngansach + tienthu;
            //txtngansach.Text = congtien.ToString();
            //bindingthu2();
            /*int id = Convert.ToInt32(txtmathu.Text);
            DateTime ngaythu = dateTimePicker1.Value;
            float tien = Convert.ToInt32(txttienthu.Text);
            string mota = Convert.ToString(txtmotathu);
            //double aa = Convert.ToDouble(txtiduser.Text);
            int iduser = Convert.ToInt32(txtiduser.Text);
            int idmaloai = Convert.ToInt32(txtidloaithu.Text);
           // int idmaloai = (cb1.SelectedItem as qlthuchi.DTO.Category).ID;
            if (THU.Instance.Inserthu(id, ngaythu, tien, mota, iduser, idmaloai))
            {
                MessageBox.Show("them khoan thu thanh cong");
                thongtinthu();
            }
            else
            {
                MessageBox.Show("fail");
            }*/

        }
        void congtien()
        {
            int ngansach = int.Parse(txtngansach.Text);
            int tienthu = int.Parse(txttienthu.Text);
            Int64 congtien;
            congtien = (ngansach + tienthu);
            txtngansach.Text = congtien.ToString();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void insertthu()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();

            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"insert into thu values(@ngaythu,@tienthu,@motathu,@id_user,@id_loaithu)";
            //cmdd.Parameters.AddWithValue("@id_thu", txtmathu.Text.Trim());
            string ngaythu = dateTimePicker1.Value.ToString();
            cmdd.Parameters.AddWithValue("@ngaythu", ngaythu);
            cmdd.Parameters.AddWithValue("@tienthu", float.Parse(txttienthu.Text));
            cmdd.Parameters.AddWithValue("@motathu", txtmotathu.Text.Trim());
            cmdd.Parameters.AddWithValue("@id_user", txtiduser.Text.Trim());
            int id_loaithu = (cb1.SelectedItem as DTO.loaithu).ID;
            cmdd.Parameters.AddWithValue("@id_loaithu", id_loaithu);
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("thêm khoản thu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                //updatecongthu();
                thongtinthu();
            }
            else
            {
                MessageBox.Show("thêm khoản thu thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }
        public void load()
        {
            //dataGridView1.DataSource = thulist;
            //dataGridView3.DataSource = tk;
            //dataGridView2.DataSource = listchi;
            thongtinchi();
            thongtinthu();
            bindingchi2();
            bindingthu2();
            taicb(cb1);
            taicb2(cb2);
            taicb2(cbblocchi);
            taicb(cbbloc2);
            //taicb3(comboBox1);
        }
        void insertchi()
        {
            string connstr2 = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn2 = new SqlConnection(connstr2);
            cmdd = new SqlCommand();
            cmdd.Connection = conn2;
            conn2.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"insert into chi values(@ngaychi,@tienchi,@motachi,@id_user,@id_loaichi)";
            //cmdd.Parameters.AddWithValue("@id_chi", txtmachi.Text.Trim());
            string ngaychi = dateTimePicker2.Value.ToString();
            cmdd.Parameters.AddWithValue("@ngaychi", ngaychi);
            cmdd.Parameters.AddWithValue("@tienchi", float.Parse(txttienchi.Text));
            cmdd.Parameters.AddWithValue("@motachi", txtmotachi.Text.Trim());
            cmdd.Parameters.AddWithValue("@id_user", txtiduser2.Text.Trim());
            int id_loaichi = (cb2.SelectedItem as DTO.loaichi).ID;
            cmdd.Parameters.AddWithValue("@id_loaichi", id_loaichi);
            int row2 = cmdd.ExecuteNonQuery();
            if (row2 > 0)
            {
                MessageBox.Show("thêm khoản chi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //updatetruchi();
                thongtinchi();
            }
            else
            {
                MessageBox.Show("thêm khoản chi thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn2.Close();
        }
        public void updatechi()
        {
            string constr3 = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn3 = new SqlConnection(constr3);
            cmdd = new SqlCommand();
            cmdd.Connection = conn3;
            conn3.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"update chi set ngaychi = @ngaychi,tienchi = @tienchi,motachi = @motachi,id_user = @id_user,id_loaichi = @id_loaichi where id_chi = @id_chi";
            cmdd.Parameters.AddWithValue("@id_chi", txtmachi.Text.Trim());
            string ngaychi2 = dateTimePicker2.Value.ToString();
            cmdd.Parameters.AddWithValue("@ngaychi", ngaychi2);
            cmdd.Parameters.AddWithValue("@tienchi", float.Parse(txttienchi.Text));
            cmdd.Parameters.AddWithValue("@motachi", txtmotachi.Text.Trim());
            cmdd.Parameters.AddWithValue("@id_user", txtiduser2.Text.Trim());
            int id_loaichi = (cb2.SelectedItem as DTO.loaichi).ID;
            cmdd.Parameters.AddWithValue("@id_loaichi", id_loaichi);
            int row3 = cmdd.ExecuteNonQuery();
            if (row3 > 0)
            {
                MessageBox.Show("cập nhật khoản chi thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinchi();
            }
            else
            {
                MessageBox.Show("cập nhật khoản chi thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn3.Close();
        }
        public void updatethu()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"update thu set ngaythu = @ngaythu,tienthu = @tienthu,motathu = @motathu,id_user = @id_user,id_loaithu = @id_loaithu where id_thu = @id_thu";
            cmdd.Parameters.AddWithValue("@id_thu", txtmathu.Text);
            string ngaythu = dateTimePicker1.Value.ToString();
            cmdd.Parameters.AddWithValue("@ngaythu", ngaythu);
            cmdd.Parameters.AddWithValue("@tienthu", float.Parse(txttienthu.Text));
            cmdd.Parameters.AddWithValue("@motathu", txtmotathu.Text.Trim());
            cmdd.Parameters.AddWithValue("@id_user", txtiduser.Text.Trim());
            int id_loaithu = (cb1.SelectedItem as DTO.loaithu).ID;
            cmdd.Parameters.AddWithValue("@id_loaithu", id_loaithu);
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("cập nhật khoản thu thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinthu();

            }
            else
            {
                MessageBox.Show("cập nhật khoản thu thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*int id = Convert.ToInt32(txtmathu.Text);
            DateTime ngaythu = dateTimePicker1.Value;
            float tien = Convert.ToInt32(txttienthu.Text);
            string mota = Convert.ToString(txtmotathu);
            //double aa = Convert.ToDouble(txtiduser.Text);
            int iduser = Convert.ToInt32(txtiduser.Text);
            int idmaloai = (cb1.SelectedItem as qlthuchi.DTO.Category).ID;
            if (THU.Instance.UpdateFood(id, ngaythu, tien, mota, iduser, idmaloai))
            {
                MessageBox.Show("them khoan thu thanh cong");
                thongtinthu();
            }
            else
            {
                MessageBox.Show("fail");
            }*/
            updatethu();
            thongtinthu();
            bindingthu2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float ns = float.Parse(txtngansach.Text);
            if (ns < 1000000)
            {
                MessageBox.Show("số dư trong tài khoản đang ở mức báo động, không nên tiếp tục chi tiêu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
                insertchi();
                truchi();
                updatetruchi();
                thongtinchi();
                thongtinthu();
                bindingthu2();
                bindingchi2();
               
                //bindingchi2();
            }
            /*int nhapchi;
            try
            {
                    nhapchi = int.Parse(txtmachi.Text);
                    
            }
            catch(Exception)
            {
                MessageBox.Show("nhập sai kiểu dữ liệu", "thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/


            /*int id = Convert.ToInt32(txtmachi.Text);
            DateTime ngaychi = dateTimePicker2.Value;
            int tienchi = Convert.ToInt32(txttienchi.Text);
            string motachi = Convert.ToString(txtmotachi.Text);
            int id_user = Convert.ToInt32(txtiduser2.Text);
            int id_loaichi = (cb2.SelectedItem as DTO.loaichi).ID;
            if (CHI.Instance.themchi(id, ngaychi, tienchi, motachi, id_user, id_loaichi))
            {
                MessageBox.Show("");
                thongtinchi();
            }
            else
            {
                MessageBox.Show("failed");
            }*/


        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updatechi();
            bindingchi2();
        }
        void thag()
        {
            List<string> thang;
            thang = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12"
            };
            cbbthang.DataSource = thang;
            comboBox1.DataSource = thang;
            comboBox3.DataSource = thang;
            List<string> nam;
            nam = new List<string>()
            {
                "2018",
                "2019",
                "2020",
                "2021",
                "2022",
                "2023"
            };
            cbbnam.DataSource = nam;
            cbbnam2.DataSource = nam;
            comboBox2.DataSource = nam;
            comboBox4.DataSource = nam;
            //cbbnam3.DataSource = nam;
            List<string> quy;
            quy = new List<string>()
            {
                "1",
                "2",
                "3",
                "4"
            };
            //cbbquy.DataSource = quy;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            floaithu fl = new floaithu();
            this.Hide();
            fl.ShowDialog();
            this.Close();
        }
        void thongkethang()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select tenloaithu as [tên loại thu],COUNT(a.id_loaithu) as [số lần thu],sum(tienthu) as [tổng tiền thu],ngaythu as [ngày thu],id_user as [mã tai khoản],a.id_loaithu as [mã loại thu] from thu a, loaithu b where a.id_loaithu=b.id_loaithu and month(ngaythu)='" + cbbthang.Text.ToString() + "' and YEAR(ngaythu)='" + cbbnam.Text.ToString() + "' group by tenloaithu,ngaythu,id_user,a.id_loaithu";
            //cmdd.CommandText = "select a.id_thu as [mã thu],tenloaithu as [tên loại thu],a.tienthu as [tiền thu],a.ngaythu as [ngày thu],a.id_user as [mã tài khoản] from dbo.thu a,dbo.loaithu b where a.id_loaithu = b.id_loaithu and MONTH(ngaythu) = '" + cbbthang.Text.ToString() + "' and YEAR(ngaythu) = '" + cbbnam.Text.ToString() + "';";
            //int cbbchoice = Convert.ToInt32(cbbthang.SelectedValue.ToString());
            //cmdd.Parameters.AddWithValue("ngaythu", cbbchoice);
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView4.DataSource = dt;
            dataGridView4.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }
        void thongkethangchi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select tenloaichi as [tên loại chi],COUNT(a.id_loaichi) as [số lần chi],sum(tienchi) as [tổng tiền chi],ngaychi as [ngày chi],id_user as [mã tài khoản],a.id_loaichi as [mã loại chi] from chi a, loaichi b where a.id_loaichi=b.id_loaichi and month(ngaychi) = '" + cbbthang.Text.ToString() + "' and YEAR(ngaychi)='" + cbbnam.Text.ToString() + "' group by tenloaichi,ngaychi,id_user,a.id_loaichi";
            //cmdd.CommandText = "select a.id_chi as [mã chi],tenloaichi as [tên loại chi],a.tienchi as [tiền chi],a.ngaychi as [ngày chi],a.id_user as [mã tài khoản] from dbo.chi a,dbo.loaichi b where a.id_loaichi = b.id_loaichi and MONTH(ngaychi) = '" + cbbthang.Text.ToString() + "' and YEAR(ngaychi) = '" + cbbnam.Text.ToString() + "';";
            //int cbbchoice = Convert.ToInt32(cbbthang.SelectedValue.ToString());
            //cmdd.Parameters.AddWithValue("ngaythu", cbbchoice);
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView5.DataSource = dt;
            dataGridView5.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            thongkethang();
            thongkethangchi();
        }
        void thongkenam()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select tenloaithu as [tên loại thu],COUNT(a.id_loaithu) as [số lần thu],sum(tienthu) as [tổng tiền thu],ngaythu as [ngày thu],id_user as [mã tai khoản],a.id_loaithu as [mã loại thu] from thu a, loaithu b where a.id_loaithu=b.id_loaithu and YEAR(ngaythu)='" + cbbnam2.Text.ToString() + "' group by tenloaithu,ngaythu,id_user,a.id_loaithu";
            //cmdd.CommandText = "select a.id_thu as [mã thu],tenloaithu as [tên loại thu],a.tienthu as [tiền thu],a.ngaythu as [ngày thu],a.id_user as [mã tài khoản] from dbo.thu a,dbo.loaithu b where a.id_loaithu = b.id_loaithu and YEAR(ngaythu) = '" + cbbnam.Text.ToString() + "';";
            //int cbbchoice = Convert.ToInt32(cbbthang.SelectedValue.ToString());
            //cmdd.Parameters.AddWithValue("ngaythu", cbbchoice);
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView4.DataSource = dt;
            dataGridView4.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }
        void thongkenamchi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select tenloaichi as [tên loại chi],COUNT(a.id_loaichi) as [số lần chi],sum(tienchi) as [tổng tiền chi],ngaychi as [ngày chi],id_user as [mã tài khoản],a.id_loaichi as [mã loại chi] from chi a, loaichi b where a.id_loaichi=b.id_loaichi and YEAR(ngaychi)='" + cbbnam2.Text.ToString() + "' group by tenloaichi,ngaychi,id_user,a.id_loaichi";
            //cmdd.CommandText = "select a.id_chi as [mã chi],tenloaichi as [tên loại chi],a.tienchi as [tiền chi],a.ngaychi as [ngày chi],a.id_user as [mã tài khoản] from dbo.chi a,dbo.loaichi b where a.id_loaichi = b.id_loaichi and YEAR(ngaychi) = '" + cbbnam.Text.ToString() + "';";
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView5.DataSource = dt;
            dataGridView5.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }
        void thongkequi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select a.id_chi as [mã chi],tenloaichi as [tên khoản chi],a.tienchi as [tiền chi],a.ngaychi as [ngày chi],a.id_user as [mã tài khoản] from dbo.chi a,dbo.loaichi b where a.id_loaichi = b.id_loaichi and quarter(@qui) and YEAR(ngaychi) = '" + cbbnam.Text.ToString() + "';";
            // cmdd.Parameters.AddWithValue("@qui", cbbquy.SelectedItem.ToString());
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView5.DataSource = dt;
            dataGridView5.Columns[3].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            thongkenam();
            thongkenamchi();
        }
        void tongtienthu()
        {
            int unk = dataGridView4.Rows.Count;
            float tongtienthu = 0;
            for (int i = 0; i < unk - 1; i++)
                tongtienthu += float.Parse(dataGridView4.Rows[i].Cells["tổng tiền thu"].Value.ToString());
            txttongthu.Text = tongtienthu.ToString();
        }
        void tongtienchi()
        {
            int unk = dataGridView5.Rows.Count;
            float tongtienchi = 0;
            for (int i = 0; i < unk - 1; i++)
                tongtienchi += float.Parse(dataGridView5.Rows[i].Cells["tổng tiền chi"].Value.ToString());
            txttongchi.Text = tongtienchi.ToString();
        }
        void candoi()
        {
            float tongthu = float.Parse(txttongthu.Text);
            float tongchi = float.Parse(txttongchi.Text);
            float candoi;
            candoi = tongthu - tongchi;
            txtcandoi.Text = candoi.ToString();
        }
        private void btntongthuchi_Click(object sender, EventArgs e)
        {
            tongtienthu();
            tongtienchi();
            candoi();
            updatengansach();
        }

        private void btnaddloaichi_Click(object sender, EventArgs e)
        {
            floaichi fl = new floaichi();
            this.Hide();
            fl.ShowDialog();
            this.Close();
        }

        private void btnquy_Click(object sender, EventArgs e)
        {
            thongkequi();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            DialogResult h;
            h = MessageBox.Show("bạn có muốn thoát chương trình?", "thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult h;
            h = MessageBox.Show("bạn có muốn thoát chương trình?", "thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnclearallthu_Click(object sender, EventArgs e)
        {
            //txtmathu.Clear();
            //txtiduser.Clear();
            //txtmaloaithu.Clear();
            //txttienthu.Clear();
            //txtmotathu.Clear();
            thongtinthu();
            thongtinchi();
            bindingchi2();
            bindingthu2();
        }

        private void btnclearallchi_Click(object sender, EventArgs e)
        {
            thongtinchi();
            thongtinthu();
            bindingthu2();
            bindingchi2();
        }
        void locchi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"select a.id_chi as [mã chi],tenloaichi as [tên khoản chi],a.tienchi as [tiền chi],a.ngaychi as [ngày chi],b.id_loaichi as[mã loại chi],a.id_user as [mã tài khoản],motachi as [mô tả chi],ngansach as [ngân sách] from dbo.chi a,dbo.loaichi b, Userinfo c where a.id_loaichi = b.id_loaichi and a.id_user = c.id_user and tenloaichi=@tenloaichi and MONTH(ngaychi) = '" + comboBox1.Text.ToString() + "' and YEAR(ngaychi)  = '" + comboBox4.Text.ToString() + "'";
            string tenloaichi = (cbblocchi.SelectedItem as DTO.loaichi).Name;
            cmdd.Parameters.AddWithValue("@tenloaichi", tenloaichi);
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView2.DataSource = dt;
            conn.Close();
        }
        void locthu()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "select a.id_thu as [mã thu],tenloaithu as [tên khoản thu],a.tienthu as [tiền thu],a.ngaythu as [ngày thu],b.id_loaithu as[mã loại thu],a.id_user as [mã tài khoản],motathu as [mô tả thu],ngansach as [ngân sách] from dbo.thu a,dbo.loaithu b,Userinfo c where a.id_loaithu = b.id_loaithu and a.id_user = c.id_user and tenloaithu=@tenloaithu and MONTH(ngaythu) = '" + comboBox3.Text.ToString() + "' and YEAR(ngaythu) = '" + comboBox2.Text.ToString() + "'";
            string tenloaithu = (cbbloc2.SelectedItem as DTO.loaithu).Name;
            cmdd.Parameters.AddWithValue("@tenloaithu", tenloaithu);
            SqlDataReader rd = cmdd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            this.dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            locchi();
            bindingchi2();
        }
        void bindingchi2()
        {
            txtmachi.DataBindings.Clear();
            txtmachi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mã chi", true, DataSourceUpdateMode.Never));
            txttienchi.DataBindings.Clear();
            txttienchi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "tiền chi", true, DataSourceUpdateMode.Never));
            cb2.DataBindings.Clear();
            cb2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "tên khoản chi", true, DataSourceUpdateMode.Never));
            //dateTimePicker2.DataBindings.Clear();
            //dateTimePicker2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "ngày chi", true, DataSourceUpdateMode.Never));
            txtmotachi.DataBindings.Clear();
            txtmotachi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mô tả chi", true, DataSourceUpdateMode.Never));
            txtiduser2.DataBindings.Clear();
            txtiduser2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mã tài khoản", true, DataSourceUpdateMode.Never));
            txtmaloaichi.DataBindings.Clear();
            txtmaloaichi.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "mã loại chi", true, DataSourceUpdateMode.Never));
            txtngansach2.DataBindings.Clear();
            txtngansach2.DataBindings.Add(new Binding("text", dataGridView2.DataSource, "ngân sách", true, DataSourceUpdateMode.Never));
        }
        void bindingthu2()
        {
            txtmathu.DataBindings.Clear();
            txtmathu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mã thu", true, DataSourceUpdateMode.Never));
            txttienthu.DataBindings.Clear();
            txttienthu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "tiền thu", true, DataSourceUpdateMode.Never));
            cb1.DataBindings.Clear();
            cb1.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "tên khoản thu", true, DataSourceUpdateMode.Never));
            //dateTimePicker1.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "ngày thu", true, DataSourceUpdateMode.Never));
            txtmotathu.DataBindings.Clear();
            txtmotathu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mô tả thu", true, DataSourceUpdateMode.Never));
            txtiduser.DataBindings.Clear();
            txtiduser.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mã tài khoản", true, DataSourceUpdateMode.Never));
            txtmaloaithu.DataBindings.Clear();
            txtmaloaithu.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "mã loại thu", true, DataSourceUpdateMode.Never));
            txtngansach.DataBindings.Clear();
            txtngansach.DataBindings.Add(new Binding("text", dataGridView1.DataSource, "ngân sách", true, DataSourceUpdateMode.Never));
        }

        private void btnclearchi_Click(object sender, EventArgs e)
        {
            txtmachi.Clear();
            txtiduser2.Clear();
            //txtmaloaichi.Clear();
            txttienchi.Clear();
            txtmotachi.Clear();
        }

        private void fExpensemanagement_Load(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
            locthu();
            bindingthu2();
        }

        private void btnclearthu_Click(object sender, EventArgs e)
        {
            txtmathu.Clear();
            txtiduser.Clear();
            //txtmaloaithu.Clear();
            txttienthu.Clear();
            txtmotathu.Clear();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            freport fr = new freport();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void btnrpthu_Click(object sender, EventArgs e)
        {
            freport fr = new freport();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }

        private void btnrpchi_Click(object sender, EventArgs e)
        {
            frpchi fr = new frpchi();
            this.Hide();
            fr.ShowDialog();
            this.Close();
        }
        void updatengansach()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"update Userinfo set ngansach=@ngansach where id_user = @id_user";
            cmdd.Parameters.AddWithValue("@id_user", txtiduser.Text);
            cmdd.Parameters.AddWithValue("@ngansach", txtcandoi.Text);
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("đã cập nhật ngân sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinthu();
                thongtinchi();
                bindingchi2();
                bindingthu2();
                //congtien();
            }
            else
            {
                MessageBox.Show("thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void updatecongthu()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"update Userinfo set ngansach=@ngansach where id_user = @id_user";
            cmdd.Parameters.AddWithValue("@id_user", txtiduser.Text);
            cmdd.Parameters.AddWithValue("@ngansach", txtngansach.Text.ToString());
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("đã cập nhật ngân sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinthu();
                //thongtinchi();
               // bindingchi2();
                //bindingthu2();
                //congtien();
            }
            else
            {
                MessageBox.Show("thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void updatetruchi()
        {
            string constr = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=qlthuchi;Integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);
            cmdd = new SqlCommand();
            cmdd.Connection = conn;
            conn.Open();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = @"update Userinfo set ngansach=@ngansach where id_user = @id_user";
            cmdd.Parameters.AddWithValue("@id_user", txtiduser2.Text);
            cmdd.Parameters.AddWithValue("@ngansach", txtngansach2.Text.ToString());
            int row = cmdd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("đã cập nhật ngân sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                thongtinthu();
                thongtinchi();
                //bindingchi2();
                //bindingthu2();
                //congtien();
            }
            else
            {
                MessageBox.Show("thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //thongtinchi();
            //thongtinthu();
        }
        void truchi()
        {
            float ngansach = float.Parse(txtngansach2.Text);
            float tienchi = float.Parse(txttienchi.Text);
            float trutien;
            trutien = (ngansach - tienchi);
            txtngansach2.Text = trutien.ToString();
        }

    }
}

