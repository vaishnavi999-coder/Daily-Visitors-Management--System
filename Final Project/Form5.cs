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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            dbconnect();
            displaydata();
            
        }

        void displaydata()
        {
            string sql = "select * from Users";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);


            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;

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

        private void Form5_Load(object sender, EventArgs e)
        {
            //if (txtid.TextLength == 2 && txtuser.Text != "" && txtpass.TextLength == 4 && com1.SelectedIndex != -1)
            //{
            //    butsave.Enabled = true;

            //}
            //else
            //{
            //    //butsave.Enabled = false;


            //}
            //butsave.Enabled = false;




        }

        private void butsave_Click(object sender, EventArgs e)
        {


            if(txtid.TextLength == 2 && txtuser.Text != "" && txtpass.TextLength == 4 && com1.SelectedIndex != -1)

            {

            
            try
            {
                //butsave.Enabled = true;
                con.Open();
                string sql = "insert into Users (Id,UserName,Password,UserType) values('" + txtid.Text + "','" + txtuser.Text + "','" + txtpass.Text + "','" + com1.SelectedItem + "') ";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Record Successfully Saved......");


                MessageBox.Show("Record Successfully Saved.......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                clearall();
                displaydata();
            


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

            con.Close();
            }
            else
            {
                //butsave.Enabled = false;
                MessageBox.Show("Please Enter Correct ID/PassWord  or fill all the details.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        void clearall()
        {

            txtid.Clear();
            txtuser.Clear();
            txtpass.Clear();
            com1.SelectedIndex = -1;
            txtsearch.Clear();
            


            txtid.Focus();

        }

        private void butadd_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            txtid.Enabled = false;
            txtid.Text = grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtuser.Text = grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpass.Text = grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            com1.SelectedItem = grid.Rows[e.RowIndex].Cells[3].Value.ToString();

            



        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            if (txtid.TextLength == 2 && txtuser.Text != "" && txtpass.TextLength == 4 && com1.SelectedIndex != -1)
            {
                try
                {

                    string sql = "update Users set UserName = '" + txtuser.Text + "',Password = '" + txtpass.Text + "',UserType= '" + com1.SelectedItem + "' where Id ='" + txtid.Text + "' ";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Record Successfully Updated......");

                    MessageBox.Show("Record Successfully Updated.......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    displaydata();
                    clearall();

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

                finally
                {
                    con.Close();


                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct ID/PassWord  or fill all the details.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

        private void butdelete_Click(object sender, EventArgs e)
        {

            try
            {

                con.Open();



                string sql = "delete from Users where Id = '" + txtid.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record Successfully Deleted......");

                MessageBox.Show("Record Successfully Deleted.......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                displaydata();
                clearall();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {


                string sql = "Select * from Users where Id like '%" + txtsearch.Text + "%'  or  UserName like '%" + txtsearch.Text + "%' ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                grid.DataSource = dt;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

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
            //txtuser.Focus();

        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                txtuser.Focus();

            }
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                txtpass.Focus();

            }
        }

        String log;

        private void butback_Click(object sender, EventArgs e)
        {
            //Form7 f7 = new Form7();
            ////Form8 f8 = new Form8();
            //this.Hide();
            ////f8.Show();
            //f7.Show();


            Form7 x = new Form7(log);
            x.Show();
            this.Hide();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
               //MessageBox.Show("Numbers Only Allowed.....");

                MessageBox.Show("Numbers Only Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
               // MessageBox.Show("Numbers Not Allowed.....");

                MessageBox.Show("Numbers Not Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Numbers Only Allowed.....");
                MessageBox.Show("Numbers Only Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

            if (txtpass.TextLength == 4)
            {
                txtpass.ForeColor = Color.Black;
            }
            else
            {
                txtpass.ForeColor = Color.Red;
            }
        }


    }
}
