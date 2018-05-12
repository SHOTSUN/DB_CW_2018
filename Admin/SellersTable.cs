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
            sellersBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(aIRPORTDataSet);

        }
    }
}
