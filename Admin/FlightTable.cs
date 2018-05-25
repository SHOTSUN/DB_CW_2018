using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            string costInStr = "0" + textBox1.Text;
            if (textBox1.Text != null & Convert.ToInt32(costInStr)  > 0 &
                dateTimePicker1.Value < dateTimePicker2.Value) {
                flightBindingSource.AddNew();
                ((DataRowView)flightBindingSource.Current).Row["id_airline"] = comboBox1.SelectedValue;
                ((DataRowView)flightBindingSource.Current).Row["departure_date"] = dateTimePicker1.Value;
                ((DataRowView)flightBindingSource.Current).Row["arrival_date"] = dateTimePicker2.Value;
                ((DataRowView)flightBindingSource.Current).Row["id_departure"] = comboBox2.SelectedValue;
                ((DataRowView)flightBindingSource.Current).Row["id_arrival"] = comboBox3.SelectedValue;
                ((DataRowView)flightBindingSource.Current).Row["cost"] = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Введите корректные данные !");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            flightBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
                flightBindingSource.EndEdit();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
                MessageBox.Show("Изменения произведены успешно.");
                this.Close();
            }
            catch (SqlException ee)
            {
                string[] str = ee.Message.ToString().Split('.');
                MessageBox.Show(str[str.Length - 2]);
                aIRPORTDataSet.RejectChanges();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            }
            catch
            {
                MessageBox.Show("Повторите снова !");
                this.Close();
            }
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AirlineTable dialog = new AirlineTable();
            dialog.ShowDialog();
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
            this.airlineTableAdapter.Fill(this.aIRPORTDataSet.Airline);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AirportTable dialog = new AirportTable();
            dialog.ShowDialog();
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
            this.airportTableAdapter.Fill(this.aIRPORTDataSet.Airport);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода! Повторите снова!");
            e.ThrowException = false;
        }
    }
}
