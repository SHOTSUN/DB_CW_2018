namespace Admin
{
    partial class FlightTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.airlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTDataSet = new Admin.AIRPORTDataSet();
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new Admin.AIRPORTDataSetTableAdapters.FlightTableAdapter();
            this.airlineTableAdapter = new Admin.AIRPORTDataSetTableAdapters.AirlineTableAdapter();
            this.airportTableAdapter = new Admin.AIRPORTDataSetTableAdapters.AirportTableAdapter();
            this.tableAdapterManager1 = new Admin.AIRPORTDataSetTableAdapters.TableAdapterManager();
            this.flightBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flightBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idairlineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.departuredateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivaldateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idarrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.airportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Admin.AIRPORTDataSetTableAdapters.TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.airlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // airlineBindingSource
            // 
            this.airlineBindingSource.DataMember = "Airline";
            this.airlineBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // aIRPORTDataSet
            // 
            this.aIRPORTDataSet.DataSetName = "AIRPORTDataSet";
            this.aIRPORTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataMember = "Airport";
            this.airportBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // airlineTableAdapter
            // 
            this.airlineTableAdapter.ClearBeforeFill = true;
            // 
            // airportTableAdapter
            // 
            this.airportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdminTableAdapter = null;
            this.tableAdapterManager1.AirlineTableAdapter = this.airlineTableAdapter;
            this.tableAdapterManager1.AirportTableAdapter = this.airportTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.FlightTableAdapter = this.flightTableAdapter;
            this.tableAdapterManager1.SellersTableAdapter = null;
            this.tableAdapterManager1.TicketTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Admin.AIRPORTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // flightBindingSource1
            // 
            this.flightBindingSource1.DataMember = "FK_Flight_Airport";
            this.flightBindingSource1.DataSource = this.airportBindingSource;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "ПРЕДЫДУЩАЯ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "ПОСЛЕДНЯЯ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(119, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "СЛЕДУЮЩАЯ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "ПЕРВАЯ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(24, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 80);
            this.panel1.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(770, 336);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "ДОБАВИТЬ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "УДАЛИТЬ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(294, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "СОХРАНИТЬ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(24, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 49);
            this.panel2.TabIndex = 6;
            // 
            // flightBindingSource2
            // 
            this.flightBindingSource2.DataMember = "Flight";
            this.flightBindingSource2.DataSource = this.aIRPORTDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idairlineDataGridViewTextBoxColumn,
            this.departuredateDataGridViewTextBoxColumn,
            this.arrivaldateDataGridViewTextBoxColumn,
            this.iddepartureDataGridViewTextBoxColumn,
            this.idarrivalDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(942, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idairlineDataGridViewTextBoxColumn
            // 
            this.idairlineDataGridViewTextBoxColumn.DataPropertyName = "id_airline";
            this.idairlineDataGridViewTextBoxColumn.DataSource = this.airlineBindingSource;
            this.idairlineDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idairlineDataGridViewTextBoxColumn.HeaderText = "Авиакомпания";
            this.idairlineDataGridViewTextBoxColumn.Name = "idairlineDataGridViewTextBoxColumn";
            this.idairlineDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idairlineDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idairlineDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // departuredateDataGridViewTextBoxColumn
            // 
            this.departuredateDataGridViewTextBoxColumn.DataPropertyName = "departure_date";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "01.01.2000";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departuredateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.departuredateDataGridViewTextBoxColumn.HeaderText = "Дата отправления";
            this.departuredateDataGridViewTextBoxColumn.Name = "departuredateDataGridViewTextBoxColumn";
            this.departuredateDataGridViewTextBoxColumn.ToolTipText = "01.01.2000";
            // 
            // arrivaldateDataGridViewTextBoxColumn
            // 
            this.arrivaldateDataGridViewTextBoxColumn.DataPropertyName = "arrival_date";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = "01.01.2000";
            this.arrivaldateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.arrivaldateDataGridViewTextBoxColumn.HeaderText = "Дата прибытия";
            this.arrivaldateDataGridViewTextBoxColumn.Name = "arrivaldateDataGridViewTextBoxColumn";
            // 
            // iddepartureDataGridViewTextBoxColumn
            // 
            this.iddepartureDataGridViewTextBoxColumn.DataPropertyName = "id_departure";
            this.iddepartureDataGridViewTextBoxColumn.DataSource = this.airportBindingSource;
            this.iddepartureDataGridViewTextBoxColumn.DisplayMember = "name";
            this.iddepartureDataGridViewTextBoxColumn.HeaderText = "Из";
            this.iddepartureDataGridViewTextBoxColumn.Name = "iddepartureDataGridViewTextBoxColumn";
            this.iddepartureDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iddepartureDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iddepartureDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // idarrivalDataGridViewTextBoxColumn
            // 
            this.idarrivalDataGridViewTextBoxColumn.DataPropertyName = "id_arrival";
            this.idarrivalDataGridViewTextBoxColumn.DataSource = this.airportBindingSource;
            this.idarrivalDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idarrivalDataGridViewTextBoxColumn.HeaderText = "В";
            this.idarrivalDataGridViewTextBoxColumn.Name = "idarrivalDataGridViewTextBoxColumn";
            this.idarrivalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idarrivalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idarrivalDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            dataGridViewCellStyle6.NullValue = "0";
            this.costDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMMdd,  yyyy | HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.airlineBindingSource, "id", true));
            this.comboBox1.DataSource = this.airlineBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(545, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MMMMdd,  yyyy | HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(545, 246);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.airportBindingSource, "id", true));
            this.comboBox2.DataSource = this.airportBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(545, 272);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.airportBindingSource, "id", true));
            this.comboBox3.DataSource = this.airportBindingSource1;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(545, 303);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.ValueMember = "id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // airportBindingSource1
            // 
            this.airportBindingSource1.DataMember = "Airport";
            this.airportBindingSource1.DataSource = this.aIRPORTDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "FK_Ticket_Flight";
            this.ticketBindingSource.DataSource = this.flightBindingSource;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // FlightTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 434);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FlightTable";
            this.Text = "FlightTable";
            this.Load += new System.EventHandler(this.FlightTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AIRPORTDataSet aIRPORTDataSet;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private AIRPORTDataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.BindingSource airlineBindingSource;
        private AIRPORTDataSetTableAdapters.AirlineTableAdapter airlineTableAdapter;
        private System.Windows.Forms.BindingSource airportBindingSource;
        private AIRPORTDataSetTableAdapters.AirportTableAdapter airportTableAdapter;
        private AIRPORTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource flightBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource flightBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idairlineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivaltimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iddepartureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idarrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource airportBindingSource1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private AIRPORTDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
    }
}