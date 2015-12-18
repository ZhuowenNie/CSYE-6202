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
    public partial class MainWindow : Form
    {
        
        FlightBusiness fb = new FlightBusiness();
        FlightOrderBusiness fob = new FlightOrderBusiness();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //string departure = Departuretb.Text;
            string date = dataGridView1.CurrentRow.Cells["fdate"].Value.ToString();
            string fno=dataGridView1.CurrentRow.Cells["fname"].Value.ToString();
            string status = tb_status.Text;
            string carrier = tb_carrier.Text;
            string seat = seatIdtb.Text;
            string cid=tb_customer.Text;
            string price = tb_price.Text;
            //double price = Convert.ToDouble(getPrice(pricetb.Text));
            Tb_departure.Text = dataGridView1.CurrentRow.Cells["departure"].Value.ToString();
            tb_destination.Text = dataGridView1.CurrentRow.Cells["destination"].Value.ToString();
            tb_price.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
            tb_status.Text = "empty";
            tb_carrier.Text = tb_input_carrier.Text;
            seatIdtb.Text = cb_input_seatType.Text;
            
            fob.Purchase(fno, Convert.ToDateTime(date), price, status, carrier, seat, cid);
            //MessageBox.Show("Created Successfully!");
            Refresh();
        }
      
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = fb.GetFlightInfo(tb_input_destination.Text, Tb_input_departure.Text, tp_departureTime.Value);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public void DataBindtoGridView()
        {  
            DataSet ds = fb.GetFlightInfo(tb_input_destination.Text,Tb_input_departure.Text,tp_departureTime.Value);
            dataGridView1.DataSource = ds.Tables["All"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fname = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string date = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string crew = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string destination = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string departure = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string price = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string carrier = tb_input_carrier.Text;
            string seatType = cb_input_seatType.SelectedItem.ToString();

            tb_id.Text = fname;
            tb_status.Text = "default";
            Tb_departure.Text = tp_departureTime.Value.ToString();
            tb_carrier.Text = carrier;
            tb_destination.Text = destination;
            tb_seatType.Text = seatType;
            tb_price.Text = price;
            tb_customer.Text = "";
          

            //fob.Purchase(fno,Convert.ToDateTime(date),price,status,carrier,seat,cid);
           
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airlineSystemDataSet4.flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.airlineSystemDataSet4.flight);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
