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
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            DataColumn loginColumn = new DataColumn("name", Type.GetType("System.String"));
            DataColumn passwordColumn = new DataColumn("surname", Type.GetType("System.String"));

            selelrTable.Columns.Add(idColumn);
            selelrTable.Columns.Add(loginColumn);
            selelrTable.Columns.Add(passwordColumn);
            selelrTable.PrimaryKey = new DataColumn[] { selelrTable.Columns["id"] };

            selelrTable.Rows.Add(new object[] { null, textBox1.Text, textBox2.Text});

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            try { 
                adapter.Update(sellerList, "Sellers");
            }
            catch(System.Data.SqlClient.SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
