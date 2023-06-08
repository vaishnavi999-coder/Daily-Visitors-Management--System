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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            dbconnect();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 n = new Form6();
            this.Hide();
            n.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //trys
            //{

            //if (rb1.Checked)

                con.Open();
                {



                   // String sql = "Select * from visits where Date = '" + date1.Text + "'  or   FinishDate = '" + date1.Text + "' ";

                    String sql = "Select * from visits where Date like '%" + textBox1.Text + "%'  or   FinishDate like '%" + textBox1.Text + "%' ";


                    MySqlCommand cmd = new MySqlCommand(sql, con);


                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);


                    dataGridView1.DataSource = dt;
                }

                  con.Close();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);


            //}



            //if(rb2.Checked)

            //    con.Open();
            //{



            //    String sql = "Select * from visits where Department like '%" + textBox1.Text + "%'  ";

            //    MySqlCommand cmd = new MySqlCommand(sql, con);


            //    MySqlDataReader reader = cmd.ExecuteReader();

            //    DataTable dt = new DataTable();

            //    dt.Load(reader);


            //    dataGridView1.DataSource = dt;
            //}

            //con.Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.DataSource = null;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
           
           
            //if (rb3.Checked)
            //{
            //    textBox1.Visible = false;
            //    textBox2.Visible = false;
            //    textBox4.Visible = false;

            //}
            //if (rb4.Checked)
            //{
            //    textBox1.Visible = false;
            //    textBox3.Visible = false;
            //    textBox2.Visible = false;

            //}




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {



                con.Open();
                {



                    String sql = "Select * from visits where Department like '%" + textBox2.Text + "%'  ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);


                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);


                    dataGridView1.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {



                con.Open();
                {



                    String sql = "Select * from visits where WorkCondition like '%" + textBox3.Text + "%'  ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);


                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);


                    dataGridView1.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {



                con.Open();
                {



                    String sql = "Select * from visits where VisitID like '%" + textBox4.Text + "%' or ID like '%" + textBox4.Text + "%'  or FamilyID like '%" + textBox4.Text + "%'  ";

                    MySqlCommand cmd = new MySqlCommand(sql, con);


                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);


                    dataGridView1.DataSource = dt;
                }

                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                //date1.Visible = true;

            }
            else
            {
                textBox1.Clear();
                
                dataGridView1.DataSource = null;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;

               

            }
            else
            {
                textBox2.Clear();
                dataGridView1.DataSource = null;
            }
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                textBox2.Visible = false;
                textBox1.Visible = false;
                textBox3.Visible = true;
                textBox4.Visible = false;

            }
            else
            {
                textBox3.Clear();
                dataGridView1.DataSource = null;
            }
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked)
            {
                textBox1.Visible = false;
                textBox3.Visible = false;
                textBox2.Visible = false;
                textBox4.Visible = true;

            }
            else
            {
                textBox4.Clear();
                dataGridView1.DataSource = null;
            }
        }
    }
}
