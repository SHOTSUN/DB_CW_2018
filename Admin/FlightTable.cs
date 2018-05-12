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
    public partial class FlightTable : Form
    {
        
        public FlightTable()
        {
            InitializeComponent();
        }

        private void FlightTable_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Airport". При необходимости она может быть перемещена или удалена.
            this.airportTableAdapter.Fill(this.aIRPORTDataSet.Airport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Airline". При необходимости она может быть перемещена или удалена.
            this.airlineTableAdapter.Fill(this.aIRPORTDataSet.Airline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            flightBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flightBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flightBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flightBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flightBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flightBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flightBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(aIRPORTDataSet);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
