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
        public AdminPanel()
        {
            InitializeComponent();
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
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
    }
}
