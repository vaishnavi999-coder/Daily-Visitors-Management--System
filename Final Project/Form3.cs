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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dbconnect();
            displaydata();
        }

        String Gender;
        //String  dob;
        //dob = date1.Text;
        

        void displaydata()
        {
            string sql = "select * from familymembers";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);


            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

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



        private void ff()
        {
            con.Open();
            String sql = "select FamilyID from familydetails";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader re;
            re = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FamilyID", typeof(string));
            dt.Load(re);
            comfam.ValueMember = "FamilyID";
            comfam.DataSource = dt;
            con.Close();



        }

        void clearall()
        {

            txtid.Clear();
            txtname.Clear();
            txtfam.Clear();
            txtcontact.Clear();
            txtnic.Clear();
            com1.SelectedIndex = -1;
            com2.SelectedIndex = -1;
            //txted.Clear();
            txtjob.Clear();
            txtall.Clear();
            rb1.Checked = false;
            rb2.Checked = false;
            txtsearch.Clear();
            txtadd.Clear();
            date1.Value = DateTime.Now;
            ed.SelectedIndex = -1;    

            txtid.Focus();




        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //increment();
            //if (txtid.TextLength == 5)
            //{
            //    txtid.ForeColor = Color.Black;
            //}
            //else
            //{
            //    txtid.ForeColor = Color.Red;
            //}
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            ff();

            increment();
            txtid.Enabled = false;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {

            Gender = "Male";

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";

        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                txtname.Focus();

            }
           
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                txtfam.Focus();

            }


        }

        private void txtnic_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                txtcontact.Focus();

            }


        }

        private void txtcontact_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btsave_Click(object sender, EventArgs e)
        {

            if(txtcontact .TextLength == 10  && txtid.TextLength == 5 && txtfam.TextLength ==5)
            {
            con.Open();
            try
            {


                string sql = "insert into familymembers (ID,Name,FamilyID,Address,Gender,DOB,NIC,Contact,Relationship,Education,Job,JobType,Allowance) values('" + txtid.Text + "','" + txtname.Text + "','" + txtfam.Text + "','"+txtadd.Text+"','"+Gender+"','" + date1.Text +" ','" + txtnic.Text + "','" + txtcontact.Text + "','" + com1.SelectedItem + "','" + ed.SelectedItem + "','" + txtjob.Text + "','" + com2.SelectedItem + "','" + txtall.Text + "')";

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
            increment();
            }
                

            else
            {

                MessageBox.Show("Contact number or FamilyID or ID is Incorrect.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void date1_ValueChanged(object sender, EventArgs e)
        {

            //dob = date1.Value.ToString();
        }

        private void rb1_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rb2_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btup_Click(object sender, EventArgs e)
        {

            if (txtcontact.TextLength == 10 && txtid.TextLength == 5 && txtfam.TextLength == 5)
            {
                try
                {

                    string sql = "update familymembers set Name='" + txtname.Text + "',FamilyID='" + txtfam.Text + "',Address='" + txtadd.Text + "',Gender='" + Gender + "', DOB = '" + date1.Text + "',NIC ='" + txtnic.Text + "',Contact='" + txtcontact.Text + "',Relationship='" + com1.SelectedItem + "',Education='" +ed.SelectedItem + "',Job='" + txtjob.Text + "',JobType='" + com2.SelectedItem + "',Allowance='" + txtall.Text + "' where ID ='" + txtid.Text + "'";

                    string sq = "update visits set Name='" + txtname.Text + "',FamilyID='" + txtfam.Text + "',Address='" + txtadd.Text + "',Gender='" + Gender + "', NIC ='" + txtnic.Text + "',Contact='" + txtcontact.Text + "' where ID ='" + txtid.Text + "'";

                    con.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MySqlCommand cm = new MySqlCommand(sq, con);
                    cm.ExecuteNonQuery();
                    //MessageBox.Show("Record Successfully Updated......");

                    MessageBox.Show("Record Successfully Updated.......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    displaydata();



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
            else
            {
                MessageBox.Show("Contact number or FamilyID or ID is Incorrect.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btde_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                String sql = "delete from familymembers where ID = '" + txtid.Text + "'";

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
            increment();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {


                string sql = "Select * from familymembers where ID like '%" + txtsearch.Text + "%'  or FamilyID like '%" + txtsearch.Text + "%' " ;

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtid.Enabled = false;
            //date1.Enabled = false;

            comfam.Visible = false;
            
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfam.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
            {
                rb1.Checked = true;

            }
            else
            {
                rb2.Checked = true;

            }




            txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtnic.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            com1.SelectedItem= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


            ed.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtjob.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            com2.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtall.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            date1.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            



        }

        private void txtid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtname.Focus();

            }
        }

        private void txted_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtjob.Focus();

            }
        }


       
        private void btadd_Click(object sender, EventArgs e)
        {
            clearall();
            increment();

        }


        String log;
        private void btback_Click(object sender, EventArgs e)
        {
            //Form7 x = new Form7();
            Form7 x = new Form7(log);
            this.Hide(); 
            x.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtfam_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (txtfam.Text != "")
                {
                    con.Open();
                    String Sql = "Select Address from familydetails where FamilyID ='" + txtfam.Text + "' ";
                    MySqlCommand cmd = new MySqlCommand(Sql, con);
                    MySqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        txtadd.Text = da.GetValue(0).ToString();

                    }

                    con.Close();

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        

            if (txtfam.TextLength == 5)
            {
                txtfam.ForeColor = Color.Black;
            }
            else
            {
                txtfam.ForeColor = Color.Red;
            }

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = false;

            //}
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers Not Allowed.....","Warning");

            }

            
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("A Phone number cannot contain Letters.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //if (char.IsWhiteSpace(e.KeyChar))
            //{
            //    e.Handled = true;

            //}

            
        }

        private void txtall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Numbers Only Allowed.....", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            if (txtcontact.TextLength == 10)
            {
                txtcontact.ForeColor = Color.Black;
            }
            else
            {
                txtcontact.ForeColor = Color.Red;
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtfam_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtnic_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void comfam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comfam_MouseClick(object sender, MouseEventArgs e)
        {
            //if (comfam.SelectedItem)
            //{

            //    string xcomfam = comfam.Text;
            //    txtfam.Text = xcomfam;
            //}
        }
        private void increment()
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("select count(ID) from familymembers", con);

            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            string Fd = "FM00";
            txtid.Text = Fd + i.ToString();
        }
    }
}
