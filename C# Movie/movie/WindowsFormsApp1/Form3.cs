using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public string strSql = "Data Source=localhost;Port=3307;Database=movie;User Id=root;Password=root";

        
        public Form3()
        {
            InitializeComponent();
          
         
         }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void seatpic_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("결제하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                MessageBox.Show("정상적으로 결제되었습니다.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("결제가 취소 되었습니다.");

            }

            
        }

        public void button23_Click(object sender, EventArgs e)
        { 
           
            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            string sql = "insert into seat_tb(A1) values('" + "1" +"')";
            var Comm = new MySqlCommand(sql, MConn);
            int i = Comm.ExecuteNonQuery();
           
             MConn.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            string sql = "insert into seat_tb(A2) values('" + "1" + "')";
            var Comm = new MySqlCommand(sql, MConn);
            int i = Comm.ExecuteNonQuery();

            MConn.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
           
        }
    }
}
