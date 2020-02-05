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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private Boolean idCheckd = false;
        private Boolean pwCheckd = false;
        private void pwCheck()
        {
            if (txtpw1.Text == txtpw2.Text)
                pwCheckd = true;
            else
                pwCheckd = false;
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            var MConn = new MySqlConnection(form1.strSql);
            MConn.Open();

            if (!idCheckd)   // 중복체크
            {
                string sql = "select id, password from movie_tb where id= '" + textBox2.Text + "'";
                var Comm = new MySqlCommand(sql, MConn);
                var myRead = Comm.ExecuteReader();
                if (myRead.HasRows)
                {
                    idCheckd = false;
                    MessageBox.Show("사용중인 아이디입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    idCheckd = true;
                    MessageBox.Show("사용가능한 아이디입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MConn.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            if (idCheckd)   // 중복체크
            {
                pwCheck();

                if (pwCheckd)   // pw 체크
                {
                    var MConn = new MySqlConnection(form1.strSql);
                    MConn.Open();

                    string sql = "insert into movie_tb(id, password , phone) values('" + textBox2.Text + "', '" + txtpw1.Text + "' ,'" + phone.Text +  "')";
                    var Comm = new MySqlCommand(sql, MConn);
                    int i = Comm.ExecuteNonQuery();
                    MConn.Close();

                    if (i == 1)
                    {
                        this.Close();
                        form1.Show();
                        MessageBox.Show("가입이 완료되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("데이터 저장 오류", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("패스워드가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID 중복체크를 해주시기 바랍니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
