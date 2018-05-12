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
        public AdminPanel()
        {
            InitializeComponent();
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter valid values !");
                return;

            }

            Dictionary<string, Type> columns = new Dictionary<string, Type>();
            columns.Add("name", Type.GetType("System.String"));
            columns.Add("surname", Type.GetType("System.String"));
            columns.Add("password", Type.GetType("System.String"));
            object[] data = { textBox1.Text, textBox2.Text, Manager.GetHashString(textBox3.Text) };

            if (Manager.insertToDB("Sellers", "SELECT * FROM Sellers", columns, data) == "true")
            {
                MessageBox.Show("Seller " + textBox2.Text + " aded to DB.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                panel1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong! Try again.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Enter valid values !");
                return;
            }

            Dictionary<string, Type> columns = new Dictionary<string, Type>();
            columns.Add("name", Type.GetType("System.String"));
            columns.Add("country", Type.GetType("System.String"));
            columns.Add("city", Type.GetType("System.String"));
            object[] data = { textBox4.Text, textBox5.Text, textBox6.Text};

            if (Manager.insertToDB("Airport", "SELECT * FROM Airport", columns, data) == "true")
            {
                MessageBox.Show("Airport " + textBox4.Text + " aded to DB.");
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                panel2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong! Try again.");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" )
            {
                MessageBox.Show("Enter valid values !");
                return;
            }

            Dictionary<string, Type> columns = new Dictionary<string, Type>();
            columns.Add("name", Type.GetType("System.String"));
            object[] data = { textBox7.Text};

            if (Manager.insertToDB("Airline", "SELECT * FROM Airline", columns, data) == "true")
            {
                MessageBox.Show("Airline " + textBox7.Text + " aded to DB.");
                textBox7.Text = "";
                panel3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Something went wrong! Try again.");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            DataSet dataset = Manager.readFromTable("Airline", "SELECT name FROM Airline");
            foreach (DataRow row in dataset.Tables["Airline"].Rows)
            {
                comboBox1.Items.Add(row["name"].ToString());
            }
            comboBox1.SelectedIndex = 0;

            dataset = Manager.readFromTable("Airport", "SELECT * FROM Airport");
            foreach (DataRow row in dataset.Tables["Airport"].Rows)
            {
                comboBox2.Items.Add(String.Format("{0} ({1}, {2})", row["name"].ToString(),
                    row["city"].ToString(), row["country"].ToString()));
                comboBox3.Items.Add(String.Format("{0} ({1}, {2})", row["name"].ToString(),
                    row["city"].ToString(), row["country"].ToString()));
            }
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            panel4.Enabled = true;
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            string connectionString = @"Server=VLAD-PC\SQLEXPRESS;Database=AIRPORT;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connectionString);
            command.Connection = con;
            con.Open();

            command = new SqlCommand("createFlight", con);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@airline", SqlDbType.VarChar, 50));
            command.Parameters["@airline"].Value = comboBox1.SelectedItem.ToString();

            command.Parameters.Add(new SqlParameter("@departure_time", SqlDbType.DateTime));
            command.Parameters["@departure_time"].Value = dateTimePicker1.Value;

            command.Parameters.Add(new SqlParameter("@arrival_time", SqlDbType.DateTime));
            command.Parameters["@arrival_time"].Value = dateTimePicker2.Value;

            command.Parameters.Add(new SqlParameter("@departure", SqlDbType.VarChar, 50));
            command.Parameters["@departure"].Value = comboBox2.SelectedItem.ToString();

            command.Parameters.Add(new SqlParameter("@arrival", SqlDbType.VarChar, 50));
            command.Parameters["@arrival"].Value = comboBox3.SelectedItem.ToString();

            command.Parameters.Add(new SqlParameter("@cost", SqlDbType.Decimal, 4));
            command.Parameters["@cost"].Value = Convert.ToDecimal(textBox8.Text);
            
            command.ExecuteNonQuery();
            panel4.Enabled = false;
            MessageBox.Show("Created Succesfully");

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
