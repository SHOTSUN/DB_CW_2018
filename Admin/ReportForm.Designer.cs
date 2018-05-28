namespace Admin
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.getFilteredTicketsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AIRPORTDataSet = new Admin.AIRPORTDataSet();
            this.getTicketsTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTicketsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getTicketsTableTableAdapter = new Admin.AIRPORTDataSetTableAdapters.getTicketsTableTableAdapter();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.getTicketsTable1TableAdapter = new Admin.AIRPORTDataSetTableAdapters.getTicketsTable1TableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getFilteredTicketsTableTableAdapter = new Admin.AIRPORTDataSetTableAdapters.getFilteredTicketsTableTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aIRPORTDataSet1 = new Admin.AIRPORTDataSet();
            this.clientTableAdapter = new Admin.AIRPORTDataSetTableAdapters.ClientTableAdapter();
            this.ticketTableAdapter = new Admin.AIRPORTDataSetTableAdapters.TicketTableAdapter();
            this.airportDataSet2 = new Admin.AIRPORTDataSet();
            this.airportDataSet3 = new Admin.AIRPORTDataSet();
            this.airportDataSet4 = new Admin.AIRPORTDataSet();
            this.airportDataSet5 = new Admin.AIRPORTDataSet();
            this.airportDataSet6 = new Admin.AIRPORTDataSet();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.getFilteredTicketsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIRPORTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTicketsTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTicketsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // getFilteredTicketsTableBindingSource
            // 
            this.getFilteredTicketsTableBindingSource.DataMember = "getFilteredTicketsTable";
            this.getFilteredTicketsTableBindingSource.DataSource = this.AIRPORTDataSet;
            // 
            // AIRPORTDataSet
            // 
            this.AIRPORTDataSet.DataSetName = "AIRPORTDataSet";
            this.AIRPORTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTicketsTable1BindingSource
            // 
            this.getTicketsTable1BindingSource.DataMember = "getTicketsTable1";
            this.getTicketsTable1BindingSource.DataSource = this.AIRPORTDataSet;
            // 
            // getTicketsTableBindingSource
            // 
            this.getTicketsTableBindingSource.DataMember = "getTicketsTable";
            this.getTicketsTableBindingSource.DataSource = this.AIRPORTDataSet;
            // 
            // getTicketsTableTableAdapter
            // 
            this.getTicketsTableTableAdapter.ClearBeforeFill = true;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDateTimePicker.Location = new System.Drawing.Point(42, 72);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateDateTimePicker.TabIndex = 35;
            this.dateDateTimePicker.Value = new System.DateTime(2018, 5, 1, 23, 31, 0, 0);
            this.dateDateTimePicker.ValueChanged += new System.EventHandler(this.dateDateTimePicker_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(335, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 37;
            this.button1.Text = "Отобразить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getTicketsTable1TableAdapter
            // 
            this.getTicketsTable1TableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "Отчет по проданным билетам";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(260, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "По";
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSetTicket";
            reportDataSource1.Value = this.getFilteredTicketsTableBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Admin.ReportTicket.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(78, 183);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(633, 230);
            this.reportViewer2.TabIndex = 42;
            // 
            // getFilteredTicketsTableTableAdapter
            // 
            this.getFilteredTicketsTableTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientBindingSource;
            this.comboBox1.DisplayMember = "full_name";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(616, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 27);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.ValueMember = "id";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.aIRPORTDataSet1;
            // 
            // aIRPORTDataSet1
            // 
            this.aIRPORTDataSet1.DataSetName = "AIRPORTDataSet";
            this.aIRPORTDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // airportDataSet2
            // 
            this.airportDataSet2.DataSetName = "AIRPORTDataSet";
            this.airportDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportDataSet3
            // 
            this.airportDataSet3.DataSetName = "AIRPORTDataSet";
            this.airportDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportDataSet4
            // 
            this.airportDataSet4.DataSetName = "AIRPORTDataSet";
            this.airportDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportDataSet5
            // 
            this.airportDataSet5.DataSetName = "AIRPORTDataSet";
            this.airportDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportDataSet6
            // 
            this.airportDataSet6.DataSetName = "AIRPORTDataSet";
            this.airportDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(538, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Клиент:";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateDateTimePicker);
            this.Name = "ReportForm";
            this.Text = "Отчет билетов";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.getFilteredTicketsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIRPORTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTicketsTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTicketsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aIRPORTDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource getTicketsTableBindingSource;
        private AIRPORTDataSet AIRPORTDataSet;
        private AIRPORTDataSetTableAdapters.getTicketsTableTableAdapter getTicketsTableTableAdapter;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource getTicketsTable1BindingSource;
        private AIRPORTDataSetTableAdapters.getTicketsTable1TableAdapter getTicketsTable1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource getFilteredTicketsTableBindingSource;
        private AIRPORTDataSetTableAdapters.getFilteredTicketsTableTableAdapter getFilteredTicketsTableTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private AIRPORTDataSet aIRPORTDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AIRPORTDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private AIRPORTDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private AIRPORTDataSet airportDataSet2;
        private AIRPORTDataSet airportDataSet3;
        private AIRPORTDataSet airportDataSet4;
        private AIRPORTDataSet airportDataSet5;
        private AIRPORTDataSet airportDataSet6;
        private System.Windows.Forms.Label label4;
    }
}