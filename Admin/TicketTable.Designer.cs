namespace Admin
{
    partial class TicketTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTDataSet = new Admin.AIRPORTDataSet();
            this.ticketTableAdapter = new Admin.AIRPORTDataSetTableAdapters.TicketTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new Admin.AIRPORTDataSetTableAdapters.TableAdapterManager();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flightTableAdapter = new Admin.AIRPORTDataSetTableAdapters.FlightTableAdapter();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Admin.AIRPORTDataSetTableAdapters.ClientTableAdapter();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new Admin.AIRPORTDataSetTableAdapters.SellersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idflightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idsellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idflightDataGridViewTextBoxColumn,
            this.idclientDataGridViewTextBoxColumn,
            this.idsellerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(510, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // aIRPORTDataSet
            // 
            this.aIRPORTDataSet.DataSetName = "AIRPORTDataSet";
            this.aIRPORTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Location = new System.Drawing.Point(152, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 49);
            this.panel2.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(240, 13);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "СОХРАНИТЬ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(131, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "УДАЛИТЬ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "ДОБАВИТЬ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(152, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 80);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "ПЕРВАЯ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(186, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "СЛЕДУЮЩАЯ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "ПОСЛЕДНЯЯ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "ПРЕДЫДУЩАЯ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AdminTableAdapter = null;
            this.tableAdapterManager1.AirlineTableAdapter = null;
            this.tableAdapterManager1.AirportTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientTableAdapter = null;
            this.tableAdapterManager1.FlightTableAdapter = null;
            this.tableAdapterManager1.SellersTableAdapter = null;
            this.tableAdapterManager1.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Admin.AIRPORTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.aIRPORTDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата покупки";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idflightDataGridViewTextBoxColumn
            // 
            this.idflightDataGridViewTextBoxColumn.DataPropertyName = "id_flight";
            this.idflightDataGridViewTextBoxColumn.DataSource = this.flightBindingSource;
            this.idflightDataGridViewTextBoxColumn.DisplayMember = "id";
            this.idflightDataGridViewTextBoxColumn.HeaderText = "Номер рейса";
            this.idflightDataGridViewTextBoxColumn.Name = "idflightDataGridViewTextBoxColumn";
            this.idflightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idflightDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "id_client";
            this.idclientDataGridViewTextBoxColumn.DataSource = this.clientBindingSource;
            this.idclientDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "Номер клиента";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idclientDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idclientDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // idsellerDataGridViewTextBoxColumn
            // 
            this.idsellerDataGridViewTextBoxColumn.DataPropertyName = "id_seller";
            this.idsellerDataGridViewTextBoxColumn.DataSource = this.sellersBindingSource;
            this.idsellerDataGridViewTextBoxColumn.DisplayMember = "full_name";
            this.idsellerDataGridViewTextBoxColumn.HeaderText = "Номер продавца";
            this.idsellerDataGridViewTextBoxColumn.Name = "idsellerDataGridViewTextBoxColumn";
            this.idsellerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsellerDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsellerDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // TicketTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TicketTable";
            this.Text = "TicketTable";
            this.Load += new System.EventHandler(this.TicketTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AIRPORTDataSet aIRPORTDataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private AIRPORTDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private AIRPORTDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private AIRPORTDataSetTableAdapters.FlightTableAdapter flightTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AIRPORTDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private AIRPORTDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idflightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsellerDataGridViewTextBoxColumn;
    }
}