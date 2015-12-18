namespace WindowsFormsApplication4
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_input_seatType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_input_carrier = new System.Windows.Forms.TextBox();
            this.b_confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineSystemDataSet4 = new WindowsFormsApplication4.AirlineSystemDataSet4();
            this.button1 = new System.Windows.Forms.Button();
            this.tp_departureTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_input_departure = new System.Windows.Forms.TextBox();
            this.tb_input_destination = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_customer = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.seatIdtb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_carrier = new System.Windows.Forms.TextBox();
            this.tb_status = new System.Windows.Forms.TextBox();
            this.tb_seatType = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.Tb_departure = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.flightTableAdapter = new WindowsFormsApplication4.AirlineSystemDataSet4TableAdapters.flightTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineSystemDataSet4)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_input_seatType);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tb_input_carrier);
            this.tabPage1.Controls.Add(this.b_confirm);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tp_departureTime);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Tb_input_departure);
            this.tabPage1.Controls.Add(this.tb_input_destination);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(910, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search Flight";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_input_seatType
            // 
            this.cb_input_seatType.FormattingEnabled = true;
            this.cb_input_seatType.Items.AddRange(new object[] {
            "Business",
            "Economic",
            "Economic Plus"});
            this.cb_input_seatType.Location = new System.Drawing.Point(501, 488);
            this.cb_input_seatType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_input_seatType.Name = "cb_input_seatType";
            this.cb_input_seatType.Size = new System.Drawing.Size(180, 28);
            this.cb_input_seatType.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(408, 495);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Seat Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(102, 495);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Carrier Number";
            // 
            // tb_input_carrier
            // 
            this.tb_input_carrier.Location = new System.Drawing.Point(240, 489);
            this.tb_input_carrier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_input_carrier.Name = "tb_input_carrier";
            this.tb_input_carrier.Size = new System.Drawing.Size(148, 26);
            this.tb_input_carrier.TabIndex = 9;
            this.tb_input_carrier.Text = "2";
            // 
            // b_confirm
            // 
            this.b_confirm.Location = new System.Drawing.Point(714, 489);
            this.b_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b_confirm.Name = "b_confirm";
            this.b_confirm.Size = new System.Drawing.Size(123, 35);
            this.b_confirm.TabIndex = 8;
            this.b_confirm.Text = "Confirm";
            this.b_confirm.UseVisualStyleBackColor = true;
            this.b_confirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnameDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.crewDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(106, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(660, 262);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crewDataGridViewTextBoxColumn
            // 
            this.crewDataGridViewTextBoxColumn.DataPropertyName = "crew";
            this.crewDataGridViewTextBoxColumn.HeaderText = "crew";
            this.crewDataGridViewTextBoxColumn.Name = "crewDataGridViewTextBoxColumn";
            this.crewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "flight";
            this.flightBindingSource.DataSource = this.airlineSystemDataSet4;
            // 
            // airlineSystemDataSet4
            // 
            this.airlineSystemDataSet4.DataSetName = "AirlineSystemDataSet4";
            this.airlineSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 129);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search Flight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tp_departureTime
            // 
            this.tp_departureTime.Location = new System.Drawing.Point(537, 68);
            this.tp_departureTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tp_departureTime.Name = "tp_departureTime";
            this.tp_departureTime.Size = new System.Drawing.Size(298, 26);
            this.tp_departureTime.TabIndex = 5;
            this.tp_departureTime.Value = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Departure Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departure";
            // 
            // Tb_input_departure
            // 
            this.Tb_input_departure.Location = new System.Drawing.Point(174, 63);
            this.Tb_input_departure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_input_departure.Name = "Tb_input_departure";
            this.Tb_input_departure.Size = new System.Drawing.Size(148, 26);
            this.Tb_input_departure.TabIndex = 1;
            this.Tb_input_departure.Text = "Paris";
            // 
            // tb_input_destination
            // 
            this.tb_input_destination.Location = new System.Drawing.Point(174, 138);
            this.tb_input_destination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_input_destination.Name = "tb_input_destination";
            this.tb_input_destination.Size = new System.Drawing.Size(148, 26);
            this.tb_input_destination.TabIndex = 0;
            this.tb_input_destination.Text = "Boston";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.tb_customer);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.seatIdtb);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_carrier);
            this.tabPage2.Controls.Add(this.tb_status);
            this.tabPage2.Controls.Add(this.tb_seatType);
            this.tabPage2.Controls.Add(this.tb_price);
            this.tabPage2.Controls.Add(this.tb_destination);
            this.tabPage2.Controls.Add(this.Tb_departure);
            this.tabPage2.Controls.Add(this.tb_id);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(910, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Confirm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(518, 283);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Customer ID";
            // 
            // tb_customer
            // 
            this.tb_customer.Location = new System.Drawing.Point(653, 278);
            this.tb_customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customer.Name = "tb_customer";
            this.tb_customer.Size = new System.Drawing.Size(148, 26);
            this.tb_customer.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(537, 377);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 18;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 377);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // seatIdtb
            // 
            this.seatIdtb.AutoSize = true;
            this.seatIdtb.Location = new System.Drawing.Point(518, 208);
            this.seatIdtb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seatIdtb.Name = "seatIdtb";
            this.seatIdtb.Size = new System.Drawing.Size(81, 20);
            this.seatIdtb.TabIndex = 15;
            this.seatIdtb.Text = "Seat Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 20);
            this.label10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Carrier";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Departure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Flight ID";
            // 
            // tb_carrier
            // 
            this.tb_carrier.Location = new System.Drawing.Point(648, 131);
            this.tb_carrier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_carrier.Name = "tb_carrier";
            this.tb_carrier.Size = new System.Drawing.Size(148, 26);
            this.tb_carrier.TabIndex = 6;
            // 
            // tb_status
            // 
            this.tb_status.Location = new System.Drawing.Point(648, 57);
            this.tb_status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_status.Name = "tb_status";
            this.tb_status.Size = new System.Drawing.Size(148, 26);
            this.tb_status.TabIndex = 5;
            // 
            // tb_seatType
            // 
            this.tb_seatType.Location = new System.Drawing.Point(648, 202);
            this.tb_seatType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_seatType.Name = "tb_seatType";
            this.tb_seatType.Size = new System.Drawing.Size(148, 26);
            this.tb_seatType.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(222, 278);
            this.tb_price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(148, 26);
            this.tb_price.TabIndex = 3;
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(222, 202);
            this.tb_destination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(148, 26);
            this.tb_destination.TabIndex = 2;
            // 
            // Tb_departure
            // 
            this.Tb_departure.Location = new System.Drawing.Point(222, 131);
            this.Tb_departure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tb_departure.Name = "Tb_departure";
            this.Tb_departure.Size = new System.Drawing.Size(148, 26);
            this.Tb_departure.TabIndex = 1;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(222, 57);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(148, 26);
            this.tb_id.TabIndex = 0;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 589);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineSystemDataSet4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_input_departure;
        private System.Windows.Forms.TextBox tb_input_destination;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker tp_departureTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_departure;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_carrier;
        private System.Windows.Forms.TextBox tb_status;
        private System.Windows.Forms.TextBox tb_seatType;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_input_carrier;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label seatIdtb;
        private System.Windows.Forms.ComboBox cb_input_seatType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_customer;
        private AirlineSystemDataSet4 airlineSystemDataSet4;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private AirlineSystemDataSet4TableAdapters.flightTableAdapter flightTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}