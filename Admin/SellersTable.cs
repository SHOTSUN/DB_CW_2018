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
    public partial class SellersTable : Form
    {
        public SellersTable()
        {
            InitializeComponent();
        }

        private void SellersTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.aIRPORTDataSet.Sellers);

        }

        public void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Ошибка ввода!");
            anError.ThrowException = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sellersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sellersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
                sellersBindingSource.EndEdit();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
                MessageBox.Show("Изменения произведены успешно.");
            }
            catch (SqlException ee)
            {
                string[] str = ee.Message.ToString().Split('.');
                MessageBox.Show(str[str.Length - 2]);
                aIRPORTDataSet.RejectChanges();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowErrorTextNeeded(object sender, DataGridViewRowErrorTextNeededEventArgs e)
        {
            
            
        }

        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода! Повторите снова!");
            e.ThrowException = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sellersBindingSource.AddNew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sellersBindingSource.RemoveCurrent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                sellersBindingSource.EndEdit();
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
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MovePrevious();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveNext();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveFirst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sellersBindingSource.MoveLast();
        }
    }
}
