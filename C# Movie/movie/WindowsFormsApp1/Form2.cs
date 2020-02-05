using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WindowsFormsApp1
{
    
    public partial class Form2 : Form
    {
        Form3 form3 = new Form3();
        bool num = false;
        bool num2 = false;
        bool num3 = false;
        string time1;
        [DllImport("user32.dll")]
        public static extern bool ShowScrollBar(System.IntPtr hWnd, int wBar, bool bShow);
        private const uint SB_HORZ = 0;
        private const uint SB_VERT = 1;
        private const uint ESB_ENABLE_BOTH = 0x3;




        public Form2()
        {
            InitializeComponent();
            this.listView1.Scrollable = false;
            ShowScrollBar(this.listView1.Handle, (int)SB_VERT, true);
            this.listView2.Scrollable = false;
            ShowScrollBar(this.listView2.Handle, (int)SB_VERT, true);
            this.listView3.Scrollable = false;
            ShowScrollBar(this.listView3.Handle, (int)SB_VERT, true);
            this.listView4.Scrollable = false;
            ShowScrollBar(this.listView4.Handle, (int)SB_VERT, true);
            listView1.BringToFront();
            panel17.BringToFront();
            panel19.SendToBack();

           


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        public void button8_Click(object sender, EventArgs e)
        {
            num = true;
            this.pictureBox2.Image = Properties.Resources.poster2;
            form3.seatpic.Image = Properties.Resources.poster2;
            label12.Text = "알라딘";
            form3.label12.Text = "알라딘";
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.poster3;
            form3.seatpic.Image = Properties.Resources.poster3;
            label12.Text = "토이스토리4";
            form3.label12.Text = "토이스토리4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.poster4;
            form3.seatpic.Image = Properties.Resources.poster4;
            label12.Text = "기생충";
            form3.label12.Text = "기생충";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.poster5;
            form3.seatpic.Image = Properties.Resources.poster5;
            label12.Text = "맨인블랙";
            form3.label12.Text = "맨인블랙";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.poster6;
            form3.seatpic.Image = Properties.Resources.poster6;
            label12.Text = "업사이드";
            form3.label12.Text = "업사이드";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pictureBox2.Image = Properties.Resources.poster1;
            form3.seatpic.Image = Properties.Resources.poster1;
            label12.Text = "엑스맨";
            form3.label12.Text = "엑스맨";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label9.Text = "CGV 강남";
        }

       public void button3_Click_2(object sender, EventArgs e)
        {
            num3 = true;
            label10.Text = "2019.06.24(월)";
            form3.label10.Text = "2019.06.24(월)";
            time1 = "2019.06.24(월)";
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }

        }
       
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            listView1.BringToFront();

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            listView1.SendToBack();
            listView2.BringToFront();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            listView3.BringToFront();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            listView4.BringToFront();
        }

        public void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String no = listView1.FocusedItem.SubItems[0].Text;
            label9.Text = "CGV" + " " +  no;
            form3.label6.Text = "CGV" + " " + no;
            form3.label13.Text = "CGV" + " " + no;
            form3.label7.Text = no;
            num2 = true;
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }

        }

        private void ListView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String no = listView2.FocusedItem.SubItems[0].Text;
            label9.Text = "CGV" + " " + no;
            
        }

        private void ListView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String no = listView3.FocusedItem.SubItems[0].Text;
            label9.Text = "CGV" + " " + no;
        }

        private void ListView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String no = listView4.FocusedItem.SubItems[0].Text;
            label9.Text = "CGV" + " " + no;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            num3 = true;
            label10.Text = "2019.06.25(화)";
            form3.label10.Text = "2019.06.25(화)";
            time1 = "2019.06.25(화)";
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            num3 = true;
            label10.Text = "2019.06.26(수)";
            form3.label10.Text = "2019.06.26(수)";
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            num3 = true;
            label10.Text = "2019.06.27(목)";
            form3.label10.Text = "2019.06.27(목)";
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            num3 = true;
            label10.Text = "2019.06.28(금)";
            form3.label10.Text = "2019.06.28(금)";
            if (num == true && num2 == true && num3 == true)
            {

                panel19.BringToFront();
                panel17.SendToBack();
            }
        }

        public void Seat1_Click(object sender, EventArgs e)
        {
            label11.Text = "3관";
            form3.label9.Text = time1 +  " "+ "12:30 ~ 14:30";


        }

        private void ListView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Seat2_Click(object sender, EventArgs e)
        {
            
            label11.Text = "5관";
            form3.label9.Text = time1 + " " + "12:30 ~ 14:30";

        }
    }
}
