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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Enter valid values !");
                return;
             
            }

            string connectionString = @"Server=VLAD-PC\SQLEXPRESS;Database=AIRPORT;Trusted_Connection=True;";
            
            DataSet sellerList = new DataSet("sellerList");
            DataTable selelrTable = new DataTable("Sellers");

            sellerList.Tables.Add(selelrTable);

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sellers", connection);


            DataColumn idColumn = new DataColumn("id", Type.GetType("System.Int32"));
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.AutoIncrementSeed = 0;
            idColumn.AutoIncrementStep = 1;

            DataColumn nameColumn = new DataColumn("name", Type.GetType("System.String"));
            DataColumn surnameColumn = new DataColumn("surname", Type.GetType("System.String"));
            DataColumn passwordColumn = new DataColumn("password", Type.GetType("System.String"));

            selelrTable.Columns.Add(idColumn);
            selelrTable.Columns.Add(nameColumn);
            selelrTable.Columns.Add(surnameColumn);
            selelrTable.Columns.Add(passwordColumn);
            selelrTable.PrimaryKey = new DataColumn[] { selelrTable.Columns["id"] };

            selelrTable.Rows.Add(new object[] { null, textBox1.Text, textBox2.Text, Manager.GetHashString(textBox3.Text)});

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            try { 
                adapter.Update(sellerList, "Sellers");
                MessageBox.Show("Seller " + textBox1.Text + " aded to database.");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                panel1.Enabled = false;
            }
            catch(System.Data.SqlClient.SqlException exception)
            {
                MessageBox.Show(exception.Message);
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
    }
}
