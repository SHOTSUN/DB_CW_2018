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
    public partial class AirportTable : Form
    {
        public AirportTable()
        {
            InitializeComponent();
        }

        private void AirportTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Airport". При необходимости она может быть перемещена или удалена.
            this.airportTableAdapter.Fill(this.aIRPORTDataSet.Airport);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            airportBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            airportBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            airportBindingSource.EndEdit();
            tableAdapterManager1.UpdateAll(aIRPORTDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            airportBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            airportBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            airportBindingSource.MoveLast();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            airportBindingSource.MoveNext();
        }
    }
}
