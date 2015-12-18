using System;
using System.Windows.Forms;
using Airline.Business;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin"&& textBox2.Text=="admin")
            {
                this.Hide();
                Admin a = new Admin();
                a.Show();
            }
            else
            {
                if (textBox1.Text != "")
                {
                    if (textBox2.Text != "")
                    {
                        CustomerBusiness ub = new CustomerBusiness();
                        if (ub.IsUserExist(textBox1.Text, textBox2.Text) > 0)
                        {
                            MainWindow mv = new MainWindow();

                            mv.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("LoginName or Password invalid!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password cannot be empty!");
                    }
                }
                else
                {
                    MessageBox.Show("LoginName cannot be empty!");
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignUp cs = new CustomerSignUp();
            cs.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
