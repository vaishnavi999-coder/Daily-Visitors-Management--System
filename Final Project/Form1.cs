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
    public partial class Form1 : Form
    {


       // MySqlConnection con;

        MySqlConnection con = new MySqlConnection("server=localhost;user=root;pwd=;database=alldetails");
        MySqlDataReader reader;
        MySqlCommand command;
        //MySqlDataAdapter da;
        int x = 3;

        public Form1( )
        {
            InitializeComponent();
            dbconnect();


            //.Text = log;
            

        }

        

        void dbconnect()
        {
            try
            {

               // con = new MySqlConnection("server=localhost;user=root;pwd=;database=NVTI");
               
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //butfo.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

            //Form7 For = new Form7();

            //this.Hide();
            //For.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form13 For = new Form13();
            this.Hide();
            For.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtpass.Clear();
            com1.SelectedIndex = -1;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }


        String log;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (txtUsername.Text != ""    ||  txtpass.Text != ""  )
                {
                    con.Close();
                    con.Open();


                    //String sql = "Select * from Users where UserName = '"+txtUsername.Text+"' and Password = '"+txtpass.Text+"'";

                    command = new MySqlCommand("Select * from Users where UserName = '" + txtUsername.Text + "' and Password = '" + txtpass.Text + "' and UserType = '" + com1.SelectedItem + "'", con);
                    //MySqlCommand cmd = new MySqlCommand(sql, con);

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {


                        reader.Read();
                        if (reader[3].ToString() == "Administrator")
                        {

                            ulog.type = "A";
                        }
                        else if (reader[3].ToString() == "User")
                        {
                            ulog.type = "U";

                        }







                        //MessageBox.Show("LogIn Successfully...............");

                        MessageBox.Show("LogIn Successfully...................", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        log = "WELCOME: " + txtUsername.Text;

                        Form7 f = new Form7(log);
                        this.Hide();
                        f.Show();

                        //if (com1.SelectedIndex == 0)
                        //{

                        //    MessageBox.Show("LogIn Successfully as a Admin...............");
                        //    Form7 f = new Form7();
                        //    //Form8 ff = new Form8();

                        //   // ff.Enabled = false;

                        //    this.Hide();
                        //    f.Show();


                        //}
                        //else
                        //{
                        //    MessageBox.Show("LogIn Successfully as a User...............");
                        //    //Form8 ff = new Form8();
                        //    Form7 f = new Form7();
                        //    f.Show();
                        //    this.Hide();
                        //    //ff.Show();
                        //}


                        con.Close();

                    }
                    else
                    {

                       // MessageBox.Show("Invalid userName or Password............");
                        MessageBox.Show("Invalid userName or Password...........", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        con.Close();

                        x = x - 1;
                        if (x == 0)
                        {

                          //  MessageBox.Show("You have exceeded the limit , Please Try Again..........");
                            MessageBox.Show("You have exceeded the limit , Please Try Again...........", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
            }
                else
                {

                    //MessageBox.Show("Please Enter Your Username or Password.......");
                    MessageBox.Show("Please Enter Your Username or Password........", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                txtpass.Focus();
            }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                com1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //if (txtUsername.Text == "Vaishu")
            //{
            //    butfo.Enabled = true;

            //}
            //con.Open();
            //MySqlCommand cmd = new MySqlCommand("Select * from users where UserName = '" + txtUsername.Text + "' ", con);
            //MySqlDataReader dr = cmd.ExecuteReader();

            //if (dr.Read())
            //{
            //   // MessageBox.Show("Successfully Verified.....");
            //    //panel1.Visible = true;
            //    butfo.Enabled = true;


            //}
            //else
            //{
            //    //MessageBox.Show("Not Matched.....");
            //    butfo.Enabled = false;
            //}
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Numbers Only Allowed.....","Warning");
                MessageBox.Show("Numbers Only Allowed.....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Space Not Allowed.....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //    //MessageBox.Show("Numbers Not Allowed.....","Warning");
            //     MessageBox.Show("Numbers Not Allowed.....","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}

            //if (char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Space Not Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }

        private void com1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {if (txtpass.PasswordChar == '\0')
            {

                button4.BringToFront();
                txtpass.PasswordChar = '*';
        }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
                if (txtpass.PasswordChar == '*')
                {

                    button2.BringToFront();
                    txtpass.PasswordChar = '\0';
                }
            
        }
    }
}
