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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.aIRPORTDataSet.Ticket);

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
            ((DataRowView)flightBindingSource.Current).Row["id_airline"] = comboBox1.SelectedValue;
            ((DataRowView)flightBindingSource.Current).Row["departure_date"] = dateTimePicker1.Value;
            ((DataRowView)flightBindingSource.Current).Row["arrival_date"] = dateTimePicker2.Value;
            ((DataRowView)flightBindingSource.Current).Row["id_departure"] = comboBox2.SelectedValue;
            ((DataRowView)flightBindingSource.Current).Row["id_arrival"] = comboBox3.SelectedValue;
            ((DataRowView)flightBindingSource.Current).Row["cost"] = textBox1.Text;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            flightBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            flightBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            MessageBox.Show("Изменения произведены успешно.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
