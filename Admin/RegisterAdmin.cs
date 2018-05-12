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
using System.Security.Cryptography;

namespace Admin
{
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
            
        }
        

        string connectionString = @"Server=VLAD-PC\SQLEXPRESS;Database=AIRPORT;Trusted_Connection=True;";


        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT password FROM ADMIN WHERE login = " + "'" +
                textBox1.Text + "'", connection);

            DataSet dataset = new DataSet();
            adapter.Fill(dataset, "Admin");
            
            foreach (DataRow row in dataset.Tables["Admin"].Rows)
            {
                if (Manager.GetHashString(textBox2.Text) == row["password"].ToString())
                {
                    MessageBox.Show("Entered succesfully");
                    AdminPanel panel = new AdminPanel();
                    panel.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Try again!");
                }

                
            }

            connection.Close();

        }

            
    }
}

