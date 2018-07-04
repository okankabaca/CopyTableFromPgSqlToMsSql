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

        public String getNpgsqlConnectionString(String npgSqlServer, String npgSqlPort, String npgSqlDb, String npgSqlUserId, String npgSqlPassword)
        {
            var connectionString = $@"Server={npgSqlServer};
                                      Port={npgSqlPort};
                                      Database={npgSqlDb};
                                      User Id={npgSqlUserId};
                                      Password={npgSqlPassword};
                                      Integrated Security=true;";

            return connectionString;
        }

        public String getSqlConnectionString(String sqlServer, String sqlDb, String sqluserID)
        {
            var connectionString = $@"SERVER={sqlServer};
                                   Database={sqlDb};
                                   uId={sqluserID};
                                   Integrated Security=True";

            return connectionString;
        }

        public void createSqlTable(String connectionString, String sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
            }
        }

        public String getSqlQuery(DataGridView dataGridView, String targetTable)
        {
            int columnNumber = Int32.Parse(dataGridView.Rows.Count.ToString());

            string sqlQuery = $@"CREATE TABLE {targetTable}(";

            for (int i = 1; i < columnNumber; i++)
            {
                sqlQuery += dataGridView.Rows[(i - 1)].Cells[0].Value.ToString();
                sqlQuery += " " + dataGridView.Rows[(i - 1)].Cells[1].Value.ToString() + " ,";
            }

            sqlQuery += ")";
            //MessageBox.Show(sqlQuery);
            return sqlQuery;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            String npgSqlServer = txtNpgSqlServer.Text;
            String npgSqlPort = txtNpgSqlPort.Text;
            String npgSqlDb = txtNpgSqlDb.Text;
            String npgSqlTable = txtNpgSqlTable.Text;
            String npgSqlUserId = txtNpgSqlUserId.Text;
            String npgSqlPassword = txtNpgSqlPassword.Text;

            String msSqlServer = txtMsSqlServer.Text;
            String msSqlDb = txtMsSqlDb.Text;
            String msSqlId = txtMsSqlUserId.Text;
            String msSqlTable = txtMsSqlTable.Text;

            var connectionString =
                getNpgsqlConnectionString(npgSqlServer, npgSqlPort, npgSqlDb, npgSqlUserId, npgSqlPassword);

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                connection.Open();
                command.CommandText = $@"SELECT column_name,data_type 
                                         FROM INFORMATION_SCHEMA.COLUMNS 
                                         WHERE TABLE_NAME = '{npgSqlTable}'";
                command.Connection = connection;

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }

            String sqlConnectionString =
                getSqlConnectionString($@"{msSqlServer}", $@"{msSqlDb}", $@"{msSqlId}");

            String sqlQuery =
                getSqlQuery(dataGridView, $@"{msSqlTable}");

            createSqlTable(sqlConnectionString, sqlQuery);

            //(dataGridView.Rows.Count.ToString()); //count of column
            //(dataGridView.Rows[0].Cells[0].Value.ToString()); //Name of column
            //(dataGridView.Rows[0].Cells[1].Value.ToString()); //Type of column
        }
    }
}
