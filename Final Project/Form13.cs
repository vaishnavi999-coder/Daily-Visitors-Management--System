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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        void clearall()
        {

            txtid.Clear();
            txtun.Clear();
            txtnew.Clear();
            txtcon.Clear();
           

            txtid.Focus();
            panel1.Visible = false;




        }


        private void btch_Click(object sender, EventArgs e)
        {

            if (txtid.Text != ""  && txtun.Text != "")
            {

                MySqlConnection con = new MySqlConnection("server=localhost;user=root;pwd=;database=alldetails");


                con.Open();
                MySqlCommand cmd = new MySqlCommand("Select * from users where Id = '" + txtid.Text + "' and UserName = '"+txtun.Text+"' ", con);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                   // MessageBox.Show("Successfully Verified.....");

                    
                    MessageBox.Show("Successfully Verified.........", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = true;
                    


                }
                else
                {
                    //MessageBox.Show("Not Matched.....");
                    MessageBox.Show("Not Matched......", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                dr.Close();
                con.Close();
            }

            else
            {
               // MessageBox.Show("Fill all the details.............");
                MessageBox.Show("Fill all the details.............", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning); 

            }
        }

        private void btre_Click(object sender, EventArgs e)
        {


            if(txtnew.Text != "" && txtcon.Text != "")
            {
            MySqlConnection con = new MySqlConnection("server=localhost;user=root;pwd=;database=alldetails");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Update users set Password = '" + txtnew.Text + "'  where UserName = '" + txtun.Text + "' and Id = '"+txtid.Text+"'", con);

            cmd.ExecuteNonQuery();
            con.Close();
            if (txtnew.Text == txtcon.Text)
            {

                        //MessageBox.Show("Password Successfully Reset.....");

                        MessageBox.Show("Password Successfully Reset......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearall();
                        
            }

            else
            {
                //MessageBox.Show("Your Confirmation Password is wrong.....");

                MessageBox.Show("Your Confirmation Password is wrong......", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            }
            else
            {
               // MessageBox.Show("Fill all the details.............");
                MessageBox.Show("Fill all the details.............", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void Form13_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            this.Hide();

            n.Show();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtun.Focus();
            }
        }

        private void txtun_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtnew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtcon.Focus();
            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
               // MessageBox.Show("Numbers Only Allowed.....", "Warning");

                MessageBox.Show("Numbers Only Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Numbers Only Allowed.....", "Warning");
                MessageBox.Show("Numbers Only Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.TextLength == 2)
            {
                txtid.ForeColor = Color.Black;
            }
            else
            {
                txtid.ForeColor = Color.Red;
            }
        }

        private void txtnew_TextChanged(object sender, EventArgs e)
        {
            if (txtnew.TextLength == 4)
            {
                txtnew.ForeColor = Color.Black;
            }
            else
            {
                txtnew.ForeColor = Color.Red;
            }
        }

        private void txtcon_TextChanged(object sender, EventArgs e)
        {
            if (txtcon.TextLength == 4)
            {
                txtcon.ForeColor = Color.Black;
            }
            else
            {
                txtcon.ForeColor = Color.Red;
            }
        }
    }
}
