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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            dbconnect();
            displaydata();
            increment();
            
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

        void displaydata()
        {
            string sql = "select * from visits";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);


            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
            con.Close();

        }


       
        void clearall()
        {

           // txtvisit.Clear();
            txtid.Clear();
            txtfam.Clear();
            txtname.Clear();
            txtgen.Clear();
            txtnic.Clear();
            txtcontact.Clear();
            com1.SelectedIndex = -1;
            txtadd.Clear();
            txtpur.Clear();
            txtsearch.Clear();
            date1.Value = DateTime.Now;
            //date2.Value = DateTime.Now;
            com2.SelectedIndex = -1;
            date2.Clear();

            txtid.Focus();




        }

        private void btsave_Click(object sender, EventArgs e)
        {

        }

        private void btadd_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void increment()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select count(VisitID) from visits", con);

                int i = Convert.ToInt32(cmd.ExecuteScalar());

                i++;
                string Fd = "VT00";
                txtvisit.Text = Fd + i.ToString();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            //increment();

            date2.Enabled = false;
            txtvisit.Enabled = false;
            txtname.Enabled = false;
            txtgen.Enabled = false;
           // txtcontact.Enabled = false;
            txtnic.Enabled = false;
            txtadd.Enabled = false;
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
                btup.Enabled = true;
                btde.Enabled = false;
                btsave.Visible = true;
                btadd.Visible = true;
                btback.Visible = true;


            }
        }

        String log;
        private void btback_Click(object sender, EventArgs e)
        {

            Form7 n = new Form7(log);
            this.Hide();
            n.Show();

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {




            if (txtid.TextLength == 5)
            {
                txtid.ForeColor = Color.Black;
            }
            else
            {
                txtid.ForeColor = Color.Red;
            }
            //try
            //{
            //    if (txtid.Text != "")
            //    {
            //        con.Open();
            //        String Sql = "Select FamilyID,Name,Gender,NIC,Contact,Address from familymembers where ID ='" + txtid.Text + "' ";
            //        MySqlCommand cmd = new MySqlCommand(Sql, con);
            //        MySqlDataReader da = cmd.ExecuteReader();
            //        while (da.Read())
            //        {
            //            txtfam.Text = da.GetValue(0).ToString();
            //            txtname.Text = da.GetValue(1).ToString();
            //            txtgen.Text = da.GetValue(2).ToString();
            //            txtnic.Text = da.GetValue(3).ToString();
            //            txtcontact.Text = da.GetValue(4).ToString();
            //            txtadd.Text = da.GetValue(5).ToString();

            //        }

            //        con.Close();

            //    }


            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);

            //}

           
        }

        private void btsave_Click_1(object sender, EventArgs e)
        {
             try
            {
                 con.Open();
            

            if(txtid.TextLength == 5 && txtvisit.TextLength == 5)
            {



                string sql = "insert into visits (Date,VisitID,ID,FamilyID,Name,Gender,NIC,Contact,Address,Purpose,Department,WorkCondition,FinishDate) values('" + date1.Text + "','" + txtvisit.Text + "','" + txtid.Text + "','" + txtfam.Text + "','" + txtname.Text + "','" + txtgen.Text + "','" + txtnic.Text + "','" + txtcontact.Text + "','" + txtadd.Text + "','" + txtpur.Text + "','" + com2.SelectedItem + "','" + com1.SelectedItem + "','" + date2.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Record Successfully Saved......");

                MessageBox.Show("Record Successfully Saved......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displaydata();
                
               
             
            }
                   else
            {

                MessageBox.Show("VisitID or ID is Incorrect.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
             }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
                
            finally
            {
                increment();
                clearall();
            con.Close();
            }

           
        }
          
       
        

        private void btadd_Click_1(object sender, EventArgs e)
        {
            clearall();

            increment();
        }

        private void btup_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "update visits set Contact = '"+txtcontact.Text+"', Purpose='" + txtpur.Text + "',WorkCondition='" + com1.SelectedItem + "',FinishDate='" + date2.Text + "'  where VisitID ='" + txtvisit.Text + "'";

                string sq ="update familymembers set Contact = '"+txtcontact.Text+"' where ID = '"+txtid.Text+"'";  
               

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record Successfully Updated......");

                MySqlCommand cm = new MySqlCommand(sq, con);
                cm.ExecuteNonQuery();

                MessageBox.Show("Record Successfully Updated......", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btde_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                String sql = "delete from visits where VisitID = '" + txtvisit.Text + "'";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
               // MessageBox.Show("Record Successfully Deleted......");

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

        private void txtvisit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtid.Focus();

            }
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            // if (e.KeyCode == Keys.Enter)
            //{

                

            //}
        }

        private void txtid_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtid.Text != "")
                    {
                        con.Open();
                        String Sql = "Select FamilyID,Name,Gender,NIC,Contact,Address from familymembers where ID ='" + txtid.Text + "' ";
                        MySqlCommand cmd = new MySqlCommand(Sql, con);
                        MySqlDataReader da = cmd.ExecuteReader();
                        while (da.Read())
                        {
                            txtfam.Text = da.GetValue(0).ToString();
                            txtname.Text = da.GetValue(1).ToString();
                            txtgen.Text = da.GetValue(2).ToString();
                            txtnic.Text = da.GetValue(3).ToString();
                            txtcontact.Text = da.GetValue(4).ToString();
                            txtadd.Text = da.GetValue(5).ToString();

                            //da.Close();
                        }

                        da.Close();
                        //con.Close();

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
                txtpur.Focus();
        }
           
            }
            
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            //txtid.Enabled = false;
            
            txtvisit.Enabled = false;
            date1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtvisit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtfam.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtgen.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtnic.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtadd.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtpur.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            com2.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            com1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            
            date2.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            


        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {


                string sql = "Select * from visits where date like '%" + txtsearch.Text + "%'  or VisitID like '%" + txtsearch.Text + "%' ";

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

        //String log;
        private void btback_Click_1(object sender, EventArgs e)
        {
            Form7 x = new Form7(log);
            this.Hide();
            x.Show();
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Contact Number Not Contain letters.....","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void txtvisit_TextChanged(object sender, EventArgs e)
        {
            //increment();
            
            //if (txtvisit.TextLength == 5)
            //{
            //    txtvisit.ForeColor = Color.Black;
            //}
            //else
            //{
            //    txtvisit.ForeColor = Color.Red;
            //}
        }

        private void txtvisit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void com1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com1.SelectedIndex == 0)
            {
                date2.Enabled = true;

            }
            else
            {
                //date2.Enabled = false;
               // date2.Value = null;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void date2_ValueChanged(object sender, EventArgs e)
        {
            //date2.CustomFormat = "dd/MM/yyyy";
        }

        private void date2_KeyDown(object sender, KeyEventArgs e)
        {
            //if( (e.KeyCode == Keys.Back)  || (e.KeyCode == Keys.Delete) )
            //{

            //    //date2.CustomFormat = " ";
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        }
    }
