using Microsoft.SqlServer.Server;
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
    public partial class AirlineTable : Form
    {
        public AirlineTable()
        {
            InitializeComponent();
        }

        private void AirlineTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Airline". При необходимости она может быть перемещена или удалена.
            this.airlineTableAdapter.Fill(this.aIRPORTDataSet.Airline);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            airlineBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            airlineBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            airlineBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            airlineBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            airlineBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           airlineBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
                airlineBindingSource.EndEdit();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
                MessageBox.Show("Изменения произведены успешно.");
                this.Close();
            }
            catch(Exception ee)
            {
                string [] str = ee.Message.ToString().Split('.');
                MessageBox.Show(str[str.Length - 2]);
                aIRPORTDataSet.RejectChanges();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            airlineBindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            airlineBindingSource.MoveNext();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода! Повторите снова!");
            e.ThrowException = false;
        }
    }
}
