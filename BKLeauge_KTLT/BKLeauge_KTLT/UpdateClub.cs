using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BKLeauge_KTLT
{
    public partial class UpdateClub : Form
    {
        String connectionString = @"Data Source=T-PC\SQLEXPRESS;Initial Catalog=QLBongda;Integrated Security=True";
        public UpdateClub()
        {
            InitializeComponent();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String sql = "insert into CAULACBO values('" + idClub.Text + "','" +nameClub.Text + "')";
                con.Close();
            }
        }
        //Kết nối SQL và thực hiện viết câu truy vấn xóa thông tin đội bóng từ các từ khóa trong textbox
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                String sql = "delete from CAULACBO where TENCLB like '%" +nameClub.Text +"%'";
                con.Close();
            }
        }
    }
}
