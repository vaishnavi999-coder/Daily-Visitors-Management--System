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



namespace Final_Project
{
    public partial class Form7 : Form
    {
        public Form7( String log)
        {
            InitializeComponent();
            lblog.Text = log;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Form1 x = new Form1();
            this.Hide();
            x.Show();

        }

        private void Form7_Load(object sender, EventArgs e)
        {

            if (ulog.type == "A")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                button11.Visible = true;


            }
            else if (ulog.type == "U")
            {
                button1.Visible = true;
                button2.Enabled = false;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button10.Enabled = false;
                button11.Visible = true;

            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form2 x = new Form2();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 x = new Form6();
            this.Hide();
            x.Show();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            Form3 n = new Form3();
            n.Show();
            this.Hide();

        }

        private void lblog_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 n = new Form4();
            this.Hide();
            n.Show();
        }
    }
}
