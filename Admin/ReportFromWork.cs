using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace Admin
{
    public partial class ReportFromWork : Form
    {
        public ReportFromWork()
        {
            InitializeComponent();
        }

        private void ReportFromWork_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AIRPORTDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.AIRPORTDataSet.Sellers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "AIRPORTDataSet.Admin". При необходимости она может быть перемещена или удалена.
            this.AdminTableAdapter.Fill(this.AIRPORTDataSet.Admin);
            this.ticketTableAdapter.Fill(this.AIRPORTDataSet.Ticket);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=VLAD-PC\SQLEXPRESS;Database=AIRPORT;Trusted_Connection=True;";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("getSellerHiredDate", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter nameParam = new SqlParameter
            {
                ParameterName = "@id",
                Value = comboBox1.SelectedValue
            };
            command.Parameters.Add(nameParam);

            SqlParameter minAgeParam = new SqlParameter
            {
                ParameterName = "@result",
                SqlDbType = SqlDbType.Date // тип параметра
            };

            minAgeParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(minAgeParam);

            command.ExecuteNonQuery();
            
            connection.Close();
           
            
            ReportParameter pFIO = new ReportParameter("pFIO", comboBox1.Text);
            ReportParameter hired = new ReportParameter("hired", command.Parameters["@result"].Value.ToString().Split(' ')[0]);

            reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pFIO, hired });

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
