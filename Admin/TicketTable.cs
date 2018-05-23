﻿using System;
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
    public partial class TicketTable : Form
    {
        public TicketTable()
        {
            InitializeComponent();
        }

        private void TicketTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.aIRPORTDataSet.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.aIRPORTDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.aIRPORTDataSet.Ticket);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ticketBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ticketBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ticketBindingSource.EndEdit();
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
    }
}
