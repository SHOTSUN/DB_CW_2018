using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.aIRPORTDataSet1.Client);
            this.ticketTableAdapter.Fill(this.AIRPORTDataSet.Ticket);
            this.reportViewer2.RefreshReport();
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getFilteredTicketsTableTableAdapter.Fill(this.AIRPORTDataSet.getFilteredTicketsTable, dateDateTimePicker.Value, dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue.ToString()));

            this.reportViewer2.RefreshReport();
        }
    }
}
