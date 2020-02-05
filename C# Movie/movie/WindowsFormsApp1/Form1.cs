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
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form4 form4 = new Form4();
        public Form1()
        {
            InitializeComponent();
        }
        public string strSql = "Data Source=localhost;Port=3307;Database=movie;User Id=root;Password=root";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();

            if (textid.Text != "" && textpw.Text != "")
            {
                string sql = "select id, password from movie_tb where id= '" + textid.Text + "'";
                var Comm = new MySqlCommand(sql, MConn);
                var myRead = Comm.ExecuteReader();
                if (myRead.HasRows)
                {
                    if (myRead.Read())
                    {
                        if (myRead["password"].ToString() == textpw.Text)
                        {
                            MessageBox.Show("로그인 되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form2.Show();                          
                            this.Hide();
                        }
                        else
                            MessageBox.Show("암호가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("일치하는 계정이 없습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myRead.Close();
                MConn.Close();
            }
            else
            {
                MessageBox.Show("아이디와 암호를 입력해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Textpw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textpw.Text != "" && e.KeyChar == (Char)13)
            {
                e.Handled = true;
                var MConn = new MySqlConnection(strSql);
                MConn.Open();

                if (textid.Text != "" && textpw.Text != "")
                {
                    string sql = "select id, password from movie_tb where id= '" + textid.Text + "'";
                    var Comm = new MySqlCommand(sql, MConn);
                    var myRead = Comm.ExecuteReader();
                    if (myRead.HasRows)
                    {
                        if (myRead.Read())
                        {
                            if (myRead["password"].ToString() == textpw.Text)
                            {
                                MessageBox.Show("로그인 되었습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form3 frm3 = new Form3();
                                frm3.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("암호가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("일치하는 계정이 없습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    myRead.Close();
                    MConn.Close();
                }
                else
                {
                    MessageBox.Show("아이디와 암호를 입력해주세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
            }
        }
    }
}
