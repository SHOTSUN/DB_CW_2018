namespace Admin
{
    partial class AdminPanel
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.aIRPORTDataSet = new Admin.AIRPORTDataSet();
            this.tableAdapterManager = new Admin.AIRPORTDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рЕЙСЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аВИАКОМПАНИИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пРОДАВЦЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аЭРОПОРТЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кЛИЕНТЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бИЛЕТЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportTableAdapter = new Admin.AIRPORTDataSetTableAdapters.AirportTableAdapter();
            this.airportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.airlineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.airlineTableAdapter = new Admin.AIRPORTDataSetTableAdapters.AirlineTableAdapter();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new Admin.AIRPORTDataSetTableAdapters.FlightTableAdapter();
            this.flightDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.airportDataSet1 = new Admin.AIRPORTDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Admin.AIRPORTDataSetTableAdapters.TicketTableAdapter();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new Admin.AIRPORTDataSetTableAdapters.SellersTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Admin.AIRPORTDataSetTableAdapters.ClientTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            dateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(585, 282);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 33;
            dateLabel.Text = "Дата:";
            // 
            // aIRPORTDataSet
            // 
            this.aIRPORTDataSet.DataSetName = "AIRPORTDataSet";
            this.aIRPORTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.AirlineTableAdapter = null;
            this.tableAdapterManager.AirportTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.FlightTableAdapter = null;
            this.tableAdapterManager.SellersTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin.AIRPORTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рЕЙСЫToolStripMenuItem,
            this.аВИАКОМПАНИИToolStripMenuItem,
            this.пРОДАВЦЫToolStripMenuItem,
            this.аЭРОПОРТЫToolStripMenuItem,
            this.кЛИЕНТЫToolStripMenuItem,
            this.бИЛЕТЫToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рЕЙСЫToolStripMenuItem
            // 
            this.рЕЙСЫToolStripMenuItem.Name = "рЕЙСЫToolStripMenuItem";
            this.рЕЙСЫToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.рЕЙСЫToolStripMenuItem.Text = "РЕЙСЫ";
            this.рЕЙСЫToolStripMenuItem.Click += new System.EventHandler(this.рЕЙСЫToolStripMenuItem_Click);
            // 
            // аВИАКОМПАНИИToolStripMenuItem
            // 
            this.аВИАКОМПАНИИToolStripMenuItem.Name = "аВИАКОМПАНИИToolStripMenuItem";
            this.аВИАКОМПАНИИToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.аВИАКОМПАНИИToolStripMenuItem.Text = "АВИАКОМПАНИИ";
            this.аВИАКОМПАНИИToolStripMenuItem.Click += new System.EventHandler(this.аВИАКОМПАНИИToolStripMenuItem_Click);
            // 
            // пРОДАВЦЫToolStripMenuItem
            // 
            this.пРОДАВЦЫToolStripMenuItem.Name = "пРОДАВЦЫToolStripMenuItem";
            this.пРОДАВЦЫToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.пРОДАВЦЫToolStripMenuItem.Text = "ПРОДАВЦЫ";
            this.пРОДАВЦЫToolStripMenuItem.Click += new System.EventHandler(this.пРОДАВЦЫToolStripMenuItem_Click);
            // 
            // аЭРОПОРТЫToolStripMenuItem
            // 
            this.аЭРОПОРТЫToolStripMenuItem.Name = "аЭРОПОРТЫToolStripMenuItem";
            this.аЭРОПОРТЫToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.аЭРОПОРТЫToolStripMenuItem.Text = "АЭРОПОРТЫ";
            this.аЭРОПОРТЫToolStripMenuItem.Click += new System.EventHandler(this.аЭРОПОРТЫToolStripMenuItem_Click);
            // 
            // кЛИЕНТЫToolStripMenuItem
            // 
            this.кЛИЕНТЫToolStripMenuItem.Name = "кЛИЕНТЫToolStripMenuItem";
            this.кЛИЕНТЫToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.кЛИЕНТЫToolStripMenuItem.Text = "КЛИЕНТЫ";
            this.кЛИЕНТЫToolStripMenuItem.Click += new System.EventHandler(this.кЛИЕНТЫToolStripMenuItem_Click);
            // 
            // бИЛЕТЫToolStripMenuItem
            // 
            this.бИЛЕТЫToolStripMenuItem.Name = "бИЛЕТЫToolStripMenuItem";
            this.бИЛЕТЫToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.бИЛЕТЫToolStripMenuItem.Text = "БИЛЕТЫ";
            this.бИЛЕТЫToolStripMenuItem.Click += new System.EventHandler(this.бИЛЕТЫToolStripMenuItem_Click);
            // 
            // airportBindingSource
            // 
            this.airportBindingSource.DataMember = "Airport";
            this.airportBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // airportTableAdapter
            // 
            this.airportTableAdapter.ClearBeforeFill = true;
            // 
            // airportBindingSource1
            // 
            this.airportBindingSource1.DataMember = "Airport";
            this.airportBindingSource1.DataSource = this.aIRPORTDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMMM/dd/ yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.airlineBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // airlineBindingSource
            // 
            this.airlineBindingSource.DataMember = "Airline";
            this.airlineBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.airportBindingSource, "id", true));
            this.comboBox2.DataSource = this.airportBindingSource;
            this.comboBox2.DisplayMember = "full_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(56, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.airportBindingSource1, "id", true));
            this.comboBox3.DataSource = this.airportBindingSource1;
            this.comboBox3.DisplayMember = "full_name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(56, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "id";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 133);
            this.button1.TabIndex = 20;
            this.button1.Text = "НАЙТИ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Выбрать рейс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // airlineTableAdapter
            // 
            this.airlineTableAdapter.ClearBeforeFill = true;
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
            // flightDataGridView
            // 
            this.flightDataGridView.AllowUserToAddRows = false;
            this.flightDataGridView.AllowUserToDeleteRows = false;
            this.flightDataGridView.AutoGenerateColumns = false;
            this.flightDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.flightDataGridView.DataSource = this.flightBindingSource;
            this.flightDataGridView.Location = new System.Drawing.Point(34, 37);
            this.flightDataGridView.Name = "flightDataGridView";
            this.flightDataGridView.ReadOnly = true;
            this.flightDataGridView.RowHeadersVisible = false;
            this.flightDataGridView.Size = new System.Drawing.Size(887, 209);
            this.flightDataGridView.TabIndex = 21;
            this.flightDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.flightDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_airline";
            this.dataGridViewTextBoxColumn2.DataSource = this.airlineBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "name";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.HeaderText = "АВИАКОМПАНИЯ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "departure_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "ДАТА ОТПРАВЛЕНИЯ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "arrival_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "ДАТА ПРИБЫТИЯ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_departure";
            this.dataGridViewTextBoxColumn5.DataSource = this.airportBindingSource;
            this.dataGridViewTextBoxColumn5.DisplayMember = "name";
            this.dataGridViewTextBoxColumn5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn5.HeaderText = "ИЗ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn5.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_arrival";
            this.dataGridViewTextBoxColumn6.DataSource = this.airportBindingSource1;
            this.dataGridViewTextBoxColumn6.DisplayMember = "name";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "В";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cost";
            this.dataGridViewTextBoxColumn7.HeaderText = "СТОИМОСТЬ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Авиакомпания";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(33, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "С";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox4.Location = new System.Drawing.Point(10, 92);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(40, 17);
            this.checkBox4.TabIndex = 31;
            this.checkBox4.Text = "Из";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox5.Location = new System.Drawing.Point(10, 121);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(33, 17);
            this.checkBox5.TabIndex = 32;
            this.checkBox5.Text = "В";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(130, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 178);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр поиска билетов";
            // 
            // airportDataSet1
            // 
            this.airportDataSet1.DataSetName = "AIRPORTDataSet";
            this.airportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(622, 278);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 34;
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 23);
            this.button3.TabIndex = 37;
            this.button3.Text = "Оформить билет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.sellersBindingSource;
            this.comboBox4.DisplayMember = "full_name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(651, 311);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(171, 21);
            this.comboBox4.TabIndex = 38;
            this.comboBox4.ValueMember = "id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(585, 316);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 39;
            label1.Text = "Продавец:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(585, 352);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 40;
            label2.Text = "Покупатель:";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.clientBindingSource;
            this.comboBox5.DisplayMember = "full_name";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(657, 349);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(165, 21);
            this.comboBox5.TabIndex = 41;
            this.comboBox5.ValueMember = "id";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 581);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flightDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AIRPORTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рЕЙСЫToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аВИАКОМПАНИИToolStripMenuItem;
        private System.Windows.Forms.BindingSource airportBindingSource;
        private AIRPORTDataSetTableAdapters.AirportTableAdapter airportTableAdapter;
        private System.Windows.Forms.BindingSource airportBindingSource1;
        public AIRPORTDataSet aIRPORTDataSet;
        private System.Windows.Forms.ToolStripMenuItem пРОДАВЦЫToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аЭРОПОРТЫToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource airlineBindingSource;
        private AIRPORTDataSetTableAdapters.AirlineTableAdapter airlineTableAdapter;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private AIRPORTDataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.DataGridView flightDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private AIRPORTDataSet airportDataSet1;
        private System.Windows.Forms.ToolStripMenuItem кЛИЕНТЫToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бИЛЕТЫToolStripMenuItem;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private AIRPORTDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private AIRPORTDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AIRPORTDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}