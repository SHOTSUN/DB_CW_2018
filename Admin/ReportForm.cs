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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AIRPORTDataSet.getTicketsTable1". При необходимости она может быть перемещена или удалена.
            
        }

        private void dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.getTicketsTable1TableAdapter.Fill(this.AIRPORTDataSet.getTicketsTable1, dateDateTimePicker.Value, dateTimePicker1.Value);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AIRPORTDataSet.getTicketsTable". При необходимости она может быть перемещена или удалена.

            this.reportViewer1.RefreshReport();
        }
    }
}
