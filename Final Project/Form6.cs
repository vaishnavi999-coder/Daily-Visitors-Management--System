using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }


        String log;
        private void button2_Click(object sender, EventArgs e)
        {


           Form7 F7 = new Form7(log);
           this.Hide();
           F7.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {



            if (ulog.type == "A")
            {
                btFM.Visible = true;
                btUD.Visible = true;
                btFD.Visible = true;
                btDV.Visible = true;
                //button5.Visible = true;
                button1.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;


            }
            else if (ulog.type == "U")
            {

                btFM.Visible = true;
                btUD.Enabled = false;
                btFD.Visible = true;
                btDV.Visible = true;
                //button5.Visible = true;

                button1.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Enabled = false;

            }




        }

        private void btFM_Click(object sender, EventArgs e)
        {
            Form12 n = new Form12();
            this.Hide();
            n.Show();
        }

        private void btFD_Click(object sender, EventArgs e)
        {
            Form8 n = new Form8();
            this.Hide();
            n.Show();
        }

        private void btDV_Click(object sender, EventArgs e)
        {
            Form11 n = new Form11();
            this.Hide();
            n.Show();
        }

        //string log;
        private void btUD_Click(object sender, EventArgs e)
        {
            Form9 n = new Form9();
            this.Hide();
            n.Show();
        }
    }
}
