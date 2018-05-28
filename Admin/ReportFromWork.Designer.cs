namespace Admin
{
    partial class ReportFromWork
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
            this.AdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AIRPORTDataSet = new Admin.AIRPORTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AdminTableAdapter = new Admin.AIRPORTDataSetTableAdapters.AdminTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sellersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellersTableAdapter = new Admin.AIRPORTDataSetTableAdapters.SellersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketTableAdapter = new Admin.AIRPORTDataSetTableAdapters.TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIRPORTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminBindingSource
            // 
            this.AdminBindingSource.DataMember = "Admin";
            this.AdminBindingSource.DataSource = this.AIRPORTDataSet;
            // 
            // AIRPORTDataSet
            // 
            this.AIRPORTDataSet.DataSetName = "AIRPORTDataSet";
            this.AIRPORTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AdminBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Admin.ReportFromWork.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 130);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(678, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // AdminTableAdapter
            // 
            this.AdminTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(413, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sellersBindingSource;
            this.comboBox1.DisplayMember = "full_name";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(195, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 27);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sellersBindingSource
            // 
            this.sellersBindingSource.DataMember = "Sellers";
            this.sellersBindingSource.DataSource = this.AIRPORTDataSet;
            // 
            // sellersTableAdapter
            // 
            this.sellersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(163, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Справка с места работы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(136, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Кому";
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // ReportFromWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportFromWork";
            this.Text = "ReportFromWork";
            this.Load += new System.EventHandler(this.ReportFromWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AIRPORTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AdminBindingSource;
        private AIRPORTDataSet AIRPORTDataSet;
        private AIRPORTDataSetTableAdapters.AdminTableAdapter AdminTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource sellersBindingSource;
        private AIRPORTDataSetTableAdapters.SellersTableAdapter sellersTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private AIRPORTDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
    }
}