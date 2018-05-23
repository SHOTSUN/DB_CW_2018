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
    public partial class AdminPanel : Form
    {
        Form dialog;
        string flight_id;
        public AdminPanel()
        {
            InitializeComponent();
        }
 
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.aIRPORTDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.aIRPORTDataSet.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.aIRPORTDataSet.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Flight". При необходимости она может быть перемещена или удалена.
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Airport". При необходимости она может быть перемещена или удалена.
            this.airportTableAdapter.Fill(this.aIRPORTDataSet.Airport);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Airline". При необходимости она может быть перемещена или удалена.
            this.airlineTableAdapter.Fill(this.aIRPORTDataSet.Airline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aIRPORTDataSet.Flight". При необходимости она может быть перемещена или удалена.

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new SellersTable();
                dialog.Show();              
            }  
        
        }

        private void aIRPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new AirportTable();
                dialog.Show();
            }
        }

        private void aIRLINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new AirlineTable();
                dialog.Show();
            }
        }

        private void cLIENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new ClientTable();
                dialog.Show();
            }
        }

        private void fLIGHTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new FlightTable();
                dialog.Show();
            }
        }

        private void tICKETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dialog == null || dialog.IsDisposed)
            {
                dialog = new TicketTable();
                dialog.Show();
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void рЕЙСЫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightTable dialog = new FlightTable();
            dialog.ShowDialog();
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
        }

        private void аВИАКОМПАНИИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirlineTable dialog = new AirlineTable();
            dialog.ShowDialog();
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
            this.airlineTableAdapter.Fill(this.aIRPORTDataSet.Airline);
        }

        private void id_airlineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flightBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.flightBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.aIRPORTDataSet);

        }

        private void id_departureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string filterString()
        {
            String DATE = dateTimePicker1.Value.Month.ToString() + "/" +
                dateTimePicker1.Value.Day.ToString() + "/" +
                dateTimePicker1.Value.Year.ToString();
            string condition = "";
            if (checkBox1.Checked) { condition += "id_airline = " + comboBox1.SelectedValue; }
            if (checkBox2.Checked)
            {
                condition +=  (checkBox1.Checked == true) ? "AND departure_date > " + "#" + DATE + "#" :
                    "departure_date > " + "#" + DATE + "#";
            }
            if (checkBox4.Checked) {
                condition += (checkBox1.Checked == true || checkBox2.Checked == true) ?
                    "AND id_departure = " + comboBox2.SelectedValue :
                    "id_departure = " + comboBox2.SelectedValue;
            }
            if (checkBox5.Checked)
            {
                condition += (checkBox1.Checked == true || checkBox2.Checked == true || checkBox4.Checked == true) ?
                    "AND id_arrival = " + comboBox3.SelectedValue :
                    "id_arrival = " + comboBox3.SelectedValue;
            }
            return condition;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=VLAD-PC\\SQLEXPRESS;Initial Catalog=AIRPORT;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Flight", con);
            DataSet sellersList = new DataSet("sellersList");
            adapter.Fill(sellersList, "Flight");
            DataView view1 = new DataView(sellersList.Tables["Flight"]);
            flightDataGridView.DataSource = sellersList.Tables["Flight"];
            view1.RowFilter += filterString();
            flightDataGridView.DataSource = view1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flightDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flight_id = ((DataRowView)flightBindingSource.Current).Row["id"].ToString();
            button3.Enabled = true;
        }
        

        private void пРОДАВЦЫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellersTable dialog = new SellersTable();
            dialog.ShowDialog();
            this.sellersTableAdapter.Fill(this.aIRPORTDataSet.Sellers);
        }

        private void аЭРОПОРТЫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AirportTable dialog = new AirportTable();
            dialog.ShowDialog();
            this.flightTableAdapter.Fill(this.aIRPORTDataSet.Flight);
            this.airportTableAdapter.Fill(this.aIRPORTDataSet.Airport);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flightDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { comboBox1.Enabled = true; }
            else { comboBox1.Enabled = false; }
        }

       

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { comboBox2.Enabled = true; }
            else { comboBox2.Enabled = false; }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { dateTimePicker1.Enabled = true; }
            else { dateTimePicker1.Enabled = false; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) { comboBox3.Enabled = true; }
            else { comboBox3.Enabled = false; }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void кЛИЕНТЫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientTable dialog = new ClientTable();
            dialog.ShowDialog();
            this.clientTableAdapter.Fill(this.aIRPORTDataSet.Client);
        }

        private void бИЛЕТЫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketTable dialog = new TicketTable();
            dialog.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand();
            string connectionString = @"Server=VLAD-PC\SQLEXPRESS;Database=AIRPORT;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connectionString);
            command.Connection = con;
            con.Open();
            
            command = new SqlCommand("ticketAdd", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
            command.Parameters["@date"].Value = dateTimePicker1.Value.ToString();

            command.Parameters.Add(new SqlParameter("@id_flight", SqlDbType.Int, 4));
            command.Parameters["@id_flight"].Value = flight_id;

            command.Parameters.Add(new SqlParameter("@id_client", SqlDbType.Int, 4));
            command.Parameters["@id_client"].Value = comboBox5.SelectedValue;

            command.Parameters.Add(new SqlParameter("@id_seller", SqlDbType.Int, 4));
            command.Parameters["@id_seller"].Value = comboBox4.SelectedValue;

            command.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Билет успешно оформлен!");
            button3.Enabled = false;
        }

        private void id_sellerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
