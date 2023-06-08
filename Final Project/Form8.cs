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
    public partial class Form8 : Form
    {
        public Form8()
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
            try 
            {

               

                con.Open();
                {



                    String sql = "Select * from familymembers where ID like '%" + textBox1.Text + "%'  or FamilyID like '%" + textBox1.Text + "%' or Name like '%" + textBox1.Text + "%' or JobType like '%" + textBox1.Text + "%'  or NIC like '%" + textBox1.Text + "%'";

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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.DataSource = null;
           
        }
    }
}
