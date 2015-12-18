using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Airline.Business;

namespace WindowsFormsApplication4
{
    public partial class Admin : Form
    {
        FlightBusiness fb = new FlightBusiness();
        
        public Admin()
        {
            InitializeComponent();
        }
        public void DataBindtoGridView()
        {
            DataSet ds = fb.GetFlightAllInfo();
            dataGridView1.DataSource = ds.Tables["e"];
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineSystemDataSet7.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter2.Fill(this.airlineSystemDataSet7.flight);
            // TODO: This line of code loads data into the 'airlineSystemDataSet6.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter1.Fill(this.airlineSystemDataSet6.flight);
            // TODO: This line of code loads data into the 'airlineSystemDataSet5.flightOrder' table. You can move, or remove it, as needed.
            this.flightOrderTableAdapter1.Fill(this.airlineSystemDataSet5.flightOrder);
            // TODO: This line of code loads data into the 'airlineSystemDataSet3.customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.airlineSystemDataSet3.customer);
            // TODO: This line of code loads data into the 'airlineSystemDataSet2.flightOrder' table. You can move, or remove it, as needed.
            //this.flightOrderTableAdapter.Fill(this.airlineSystemDataSet2.flightOrder);
            // TODO: This line of code loads data into the 'airlineSystemDataSet1.flight' table. You can move, or remove it, as needed.
            //this.flightTableAdapter.Fill(this.airlineSystemDataSet1.flight);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
                dataGridView1.Rows[i].Selected = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
            newButton.Enabled = false;
            UpdateButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
            deleteButton.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;

            //DataSet ds = fb.InsertFlight(textBox1.Text, Convert.ToDateTime(textBox2.Text), textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text);
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fname = dataGridView1.SelectedCells[0].ToString();
            DialogResult dr = MessageBox.Show("Are you sure you want to delete？", "warning~~~", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                fb.DeleteFlight(fname);
                DataBindtoGridView();
                int count = dataGridView1.Rows.Count;
                if (count > 0)
                    dataGridView1.Rows[0].Selected = false;
                newButton.Enabled = true;
                UpdateButton.Enabled = false;
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                deleteButton.Enabled = false;
                textBox1.Text = "";
                textBox1.Enabled = false;
                textBox2.Text = "";
                textBox2.Enabled = false;
                textBox3.Text = "";
                textBox3.Enabled = false;
                textBox4.Text = "";
                textBox4.Enabled = false;
                textBox5.Text = "";
                textBox5.Enabled = false;
                textBox6.Text = "";
                textBox6.Enabled = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = dataGridView1.SelectedCells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedCells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedCells[3].Value.ToString();
               
                newButton.Enabled = false;
                UpdateButton.Enabled = false;
                saveButton.Enabled = true;
                cancelButton.Enabled = true;
                deleteButton.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var a = dataGridView1.SelectedRows;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox6.Enabled=false;
                int index = dataGridView1.SelectedRows[0].Index;
                string fname = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                string crew = textBox2.Text;
                DateTime date= Convert.ToDateTime(textBox6.Text);
                string price = textBox3.Text;
                string departure=textBox4.Text;
                string destination=textBox5.Text;
                fb.UpdateFlight(fname,date,crew,destination,departure,price);
                DataBindtoGridView();
                dataGridView1.Rows[0].Selected = false;
                dataGridView1.Rows[index].Selected = true;
            }
            else
            {
                //var index1 = dataGridView1.SelectedRows[0].Cells[0].Value;
                int index = dataGridView1.SelectedRows[0].Index;
                 string fname = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                string crew = textBox2.Text;
                DateTime date= Convert.ToDateTime(textBox6.Text);
                string price = textBox3.Text;
                string departure=textBox4.Text;
                string destination=textBox5.Text;
                fb.InsertFlight(fname,date,crew,destination,departure,price );
                DataBindtoGridView();
                dataGridView1.Rows[0].Selected = false;
                int count = dataGridView1.Rows.Count;
                dataGridView1.Rows[count - 1].Selected = true;

            }
            newButton.Enabled = true;
            UpdateButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            deleteButton.Enabled = true;
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox3.Text = "";
            textBox3.Enabled = false;
            textBox4.Text = "";
            textBox4.Enabled = false;
            textBox5.Text = "";
            textBox5.Enabled = false;
            textBox6.Text = "";
            textBox6.Enabled = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //更新后，点击取消
                newButton.Enabled = true;
                UpdateButton.Enabled = true;
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                deleteButton.Enabled = true;

                textBox1.Text = "";
                textBox1.Enabled = false;
                textBox2.Text = "";
                textBox2.Enabled = false;
                textBox3.Text = "";
                textBox3.Enabled = false;
                textBox4.Text = "";
                textBox4.Enabled = false;
                textBox5.Text = "";
                textBox5.Enabled = false;
                textBox6.Text = "";
                textBox6.Enabled = false;
            }
            else
            {
                //新增后，点击取消
                newButton.Enabled = true;
                UpdateButton.Enabled = false;
                saveButton.Enabled = false;
                cancelButton.Enabled = false;
                deleteButton.Enabled = false;
                textBox1.Text = "";
                textBox1.Enabled = false;
                textBox2.Text = "";
                textBox2.Enabled = false;
                textBox3.Text = "";
                textBox3.Enabled = false;
                textBox4.Text = "";
                textBox4.Enabled = false;
                textBox5.Text = "";
                textBox5.Enabled = false;
                textBox6.Text = "";
                textBox6.Enabled = false;
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataBindtoGridView();
            int count = dataGridView1.Rows.Count;
            if (count > 0)
                dataGridView1.Rows[0].Selected = false;
            newButton.Enabled = true;
            UpdateButton.Enabled = false;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            deleteButton.Enabled = false;
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox3.Text = "";
            textBox3.Enabled = false;
            textBox4.Text = "";
            textBox4.Enabled = false;
            textBox5.Text = "";
            textBox5.Enabled = false;
            textBox6.Text = "";
            textBox6.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            newButton.Enabled = true;
            UpdateButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            deleteButton.Enabled = true;
            textBox1.Text = "";
            textBox1.Enabled = false;
            textBox2.Text = "";
            textBox2.Enabled = false;
            textBox3.Text = "";
            textBox3.Enabled = false;
            textBox4.Text = "";
            textBox4.Enabled = false;
            textBox5.Text = "";
            textBox5.Enabled = false;
            textBox6.Text = "";
            textBox6.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
