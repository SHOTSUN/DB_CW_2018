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
    public partial class ClientTable : Form
    {
        public ClientTable()
        {
            InitializeComponent();
        }

        private void ClientTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.aIRPORTDataSet.Client);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try {
            clientBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            MessageBox.Show("Изменения произведены успешно.");
            }
            catch (Exception ee)
            {
                string[] str = ee.Message.ToString().Split('.');
                MessageBox.Show(str[str.Length - 2]);
                aIRPORTDataSet.RejectChanges();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка ввода! Повторите снова!");
            e.ThrowException = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clientBindingSource.RemoveCurrent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                clientBindingSource.EndEdit();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
                MessageBox.Show("Изменения произведены успешно.");
                this.Close();
            }
            catch (Exception ee)
            {
                string[] str = ee.Message.ToString().Split('.');
                MessageBox.Show(str[str.Length - 2]);
                aIRPORTDataSet.RejectChanges();
                tableAdapterManager1.UpdateAll(aIRPORTDataSet);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveFirst();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clientBindingSource.MovePrevious();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clientBindingSource.MoveNext();
        }
    }
}
