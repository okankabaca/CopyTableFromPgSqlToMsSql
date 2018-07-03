using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace CopyTableFromPgSqlToMsSql
{
    public partial class CopyForm : Form
    {
        public CopyForm()
        {
            InitializeComponent();
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {

        }

        public String getNpgsqlConnectionString()
        {
            var connectionString = @"Server=127.0.0.1;" +
                                   "Port=5432;" +
                                   "Database=dbSource;" +
                                   "User Id=postgres;" +
                                   "Password=Logo1234;" +
                                   "Integrated Security=true;";
            return connectionString;
        }

        public String getSqlConnectionString(String SqlServer,String SqlDb,String SqluserID)
        {
            var connectionString = $@"SERVER={SqlServer};Database={SqlDb};
uId={SqluserID};Integrated Security=True";

            return connectionString;
        }

        public void createSqlTable(String connectionString,String sqlQuery) {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            connection.Dispose();
        }

        public String getSqlQuery(DataGridView dataGridView,String targetTable) {
            int columnNumber = Int32.Parse(dataGridView.Rows.Count.ToString());
            string sqlQuery=$@"CREATE TABLE {targetTable}(";

            for (int i = 1; i < columnNumber; i++)
            {
                sqlQuery += dataGridView.Rows[(i-1)].Cells[0].Value.ToString();
                sqlQuery += " " + dataGridView.Rows[(i - 1)].Cells[1].Value.ToString() + " ,";
            }

            sqlQuery +=")";
            MessageBox.Show(sqlQuery);
            return sqlQuery;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            var connectionString = getNpgsqlConnectionString();


            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                connection.Open();

                command.CommandText = @"SELECT column_name,data_type 
                                FROM INFORMATION_SCHEMA.COLUMNS 
                                WHERE TABLE_NAME = 'tableSource'";
                //command.CommandText = "SELECT *FROM Public.\"tableSource\"";
                command.Connection = connection;
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }

           

            String sqlConnectionString = getSqlConnectionString("GEBZEHAVUZ17","dbStaj", 
                @"LOGOMERKEZ\Okan.Kabaca");
            String sqlQuery = getSqlQuery(dataGridView, "dbYeni");

            createSqlTable(sqlConnectionString,sqlQuery);
           

            //MessageBox.Show(dataGridView.Rows.Count.ToString()); //count of column
            //MessageBox.Show(dataGridView.Rows[0].Cells[0].Value.ToString()); //Name of column
            //MessageBox.Show(dataGridView.Rows[0].Cells[1].Value.ToString()); //Type of column


        }
    }
}
