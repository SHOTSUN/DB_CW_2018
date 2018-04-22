using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    class Manager
    {
        const string connectionString = @"Server=VLAD-PC\SQLEXPRESS;Database=AIRPORT;Trusted_Connection=True;";

        public static string GetHashString(string s)
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            SHA1 sha = new SHA1CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = sha.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }


        public static string insertToDB(string tableName, string commandText, Dictionary<string, Type> columns, object[] data )
        {
            string result = "false";

            DataSet set = new DataSet("dataSet");
            DataTable table = new DataTable(tableName);

            set.Tables.Add(table);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connection);


            foreach (KeyValuePair<string, Type> d in columns)
            {
                DataColumn nameColumn = new DataColumn(d.Key, d.Value);
                table.Columns.Add(nameColumn);
            }

            table.Rows.Add(data);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            try
            {
                adapter.Update(set, tableName);
                result = "true";
            }
            catch (System.Data.SqlClient.SqlException exception)
            {
               result = exception.Message;
            }

            connection.Close();
            return result;
        }


        public static DataSet readFromTable(string tableName, string commandText)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(commandText, connection);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset, tableName);
            connection.Close();
            return dataset;
        }

    }
}
