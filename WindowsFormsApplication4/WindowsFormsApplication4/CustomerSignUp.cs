using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline.Business;

namespace WindowsFormsApplication4
{
    public partial class CustomerSignUp : Form
    {
        
        public CustomerSignUp()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (cidtb.Text != "")
            {
                if(loginNametb.Text!="")
                {
                    if(emailtb.Text!="")
                    {
                        CustomerBusiness cb = new Airline.Business.CustomerBusiness();
                        cb.AddCustomer(cidtb.Text, loginNametb.Text, passwordtb.Text, emailtb.Text);
                    }
                    else
                    {
                        label7.Visible=true;
                    }
                }
                else
                {
                    label6.Visible = true;
                }  
            }
            else
            {
                labelCheck1.Visible = true;
            }
        }
    }
}
