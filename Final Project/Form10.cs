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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            dbconnect();
            displaydata();
        }
        
        void displaydata()
        {
            //string sql = "select * from work";
            //MySqlDataAdapter da = new MySqlDataAdapter(sql, con);


            //DataTable dt = new DataTable();

            //da.Fill(dt);

            //dataGridView1.DataSource = dt;

        } 

        MySqlConnection con;

        void dbconnect()
        {
            try
            {

                con = new MySqlConnection("server=localhost;user=root;pwd=;database=alldetails");


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        void clearall()
        {

            //txtID.Clear();
            //txtStName.Clear();
            //txtAddress.Clear();
            //txtSex.Clear();
            //txtCourse.Clear();
            //txtContact.Clear();

            //txtID.Focus();




        }

        private void Form10_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            this.Hide();
            x.Show();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

           
        }


        
        private void timer1_Tick()
        {

            //int startpoint = 0;

            //startpoint += 1;

            //progressBar1.Value = startpoint;
            //if (progressBar1.Value == 100)
            //{
            //    progressBar1.Value = 0;
            //    timer1.Stop();

            //    Form1 x = new Form1();
            //    this.Hide();
            //    x.Show();


            }


        int startpoint = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
           

            startpoint += 1;

            progressBar1.Value = startpoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer2.Stop();

                Form1 x = new Form1();
                this.Hide();
                x.Show();

        }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
