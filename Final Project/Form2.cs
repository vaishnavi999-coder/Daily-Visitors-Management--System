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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dbconnect();
            displaydata();
        }

        string Type;

        void displaydata()
        {
           
            string sql = "select * from familydetails";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);


            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

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

            //txtfam.Clear();
            txtadd.Clear();
            txtno.Clear();
            txtall.Clear();
            txtsearch.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            txtfam.Focus();



        }

        private void Form2_Load(object sender, EventArgs e)
        {

            increment();
            txtfam.Enabled = false;
            
            if (ulog.type == "A")
            {
                btup.Visible = true;
                btde.Visible = true;
                btsave.Visible = true;
                btadd.Visible = true;
                btback.Visible = true;


            }
            else if (ulog.type == "U")
            {
                btup.Enabled = false;
                btde.Enabled = false;
                btsave.Visible = true;
                btadd.Visible = true;
                btback.Visible = true;


            }

           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            Type = "Permanent";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Type = "Temporary";
        }

        private void btsave_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (txtfam.TextLength == 5 &&  ((radioButton1.Checked = true) || (radioButton2.Checked = true))  && txtadd.Text != ""  &&  txtno.Text != "" && txtall.Text != "" )
                {
                
                con.Open();
                string sql = "insert into familydetails  (FamilyID,AddressType,Address,Members,MonthlyAllowance) values('" + txtfam.Text + "','" + Type + "','" + txtadd.Text + "','" + txtno.Text + "','" + txtall.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Record Successfully Saved......");

                MessageBox.Show("Record Successfully Saved......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                clearall();
                displaydata();
                
            }

                else
                {
                    //MessageBox.Show("Plese Enter all details.............");

                    MessageBox.Show("Plese Enter all details.............", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();

            }
            increment();

        }

        private void btadd_Click(object sender, EventArgs e)
        {

            clearall();
            increment();

        }

        private void btup_Click(object sender, EventArgs e)
        {
            
                try
                {

                    con.Open();
                    if (txtfam.Text != "" && ((radioButton1.Checked = true) || (radioButton2.Checked = true)) && txtadd.Text != "" && txtno.Text != "" && txtall.Text != "")
                {

                    string sql = "update familydetails set AddressType='" + Type + "',Address='" + txtadd.Text + "',Members='" + txtno.Text + "',MonthlyAllowance='" + txtall.Text + "' where FamilyID ='" + txtfam.Text + "'";

                    String sq = "update familymembers set Address = '"+txtadd.Text+"' where FamilyID = '"+txtfam.Text+"'";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MySqlCommand cm = new MySqlCommand(sq, con);
                    cm.ExecuteNonQuery();
                    //MessageBox.Show("Record Successfully Updated......");

                    MessageBox.Show("Record Successfully Updated......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                   

                }

                 else
            {
                MessageBox.Show("Plese Enter all details.............", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);


                }

                finally
                {
                     displaydata();
                    clearall();
                    increment();
                    con.Close();

                }
            }

        private void btde_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                String sql = "delete  from familydetails where FamilyID = '" + txtfam.Text + "'";

                //String sq = "delete from familymembers where FamilyID = '"+txtfam.Text+"'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Record Successfully Deleted......");

                //MySqlCommand cm= new MySqlCommand(sq, con);
                //cm.ExecuteNonQuery();


                MessageBox.Show("Record Successfully Deleted......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            increment();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtfam.Enabled = false;

            txtfam.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Type = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtall.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Permanent")
            {
                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;

            }

        }

        private void txtfam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtadd.Focus();

            }
        }

        private void txtadd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtno.Focus();

            }
        }

        private void txtno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtall.Focus();

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                string sql = "Select * from familydetails where FamilyID like '%" + txtsearch.Text + "%'    ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
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


        String log;

        private void btback_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7(log);
            this.Hide();
            x.Show();

        }

        private void txtall_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtall_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers Only Allowed.....","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void txtno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers Only Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }





        }

        private void txtfam_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtfam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Space Not Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void increment()
        {
           

            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count(FamilyID) from familydetails",con);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            string Fd = "FD00";
            txtfam.Text = Fd + i.ToString();
            con.Close();

           
            
            
         
        }
    }
}
