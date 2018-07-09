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
using System.Threading;
using System.Diagnostics;
namespace CopyTableFromPgSqlToMsSql
{
    public partial class CopyForm : Form
    {
        public CopyForm()
        {
            InitializeComponent();
        }

        public int second = 0;

        private void CopyForm_Load(object sender, EventArgs e)
        {
            radioBtnFromPgSqlToMsSql.Checked = true;

            groupSourcePgSql.Visible = true;
            groupDestinationMsSql.Visible = true;

            groupSourceMsSql.Visible = false;
            groupDestinationPgSql.Visible = false;
        }


        public String getNpgsqlConnectionString(String npgSqlServer, String npgSqlPort, String npgSqlDb, String npgSqlUserId, String npgSqlPassword)
        {
            var npgConnectionString = $@"Server={npgSqlServer};
                                      Port={npgSqlPort};
                                      Database={npgSqlDb};
                                      User Id={npgSqlUserId};
                                      Password={npgSqlPassword};
                                      Integrated Security=true;";

            return npgConnectionString;
        }

        public String getSqlConnectionString(String sqlServer, String sqlDb, String sqluserID)
        {
            var sqlConnectionString = $@"SERVER={sqlServer};
                                   Database={sqlDb};
                                   uId={sqluserID};
                                   Integrated Security=True";

            return sqlConnectionString;
        }


        public void getPgTableInformations(String npgConnectionString, String npgSqlTableName)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(npgConnectionString))
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                connection.Open();
                command.CommandText = $@"SELECT column_name, data_type 
                                         FROM INFORMATION_SCHEMA.COLUMNS 
                                         WHERE TABLE_NAME = '{npgSqlTableName}'";
                command.Connection = connection;

                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }

        public void getSqlTableInformations(String sqlConnectionString, String sqlTableName)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.CommandText = $@"SELECT column_name as'Alan adı',data_type as'Veri tipi' 
                                         FROM INFORMATION_SCHEMA.COLUMNS 
                                         WHERE TABLE_NAME = '{sqlTableName}'";
                command.Connection = connection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
            }
        }


        public String convertValueTypeToPgSql(String msSqlValueType)
        {
            String pgSqlValueType = "";

            if (msSqlValueType.IndexOf("int") >= 0)
                pgSqlValueType = "integer";

            else if (msSqlValueType.IndexOf("float") >= 0)
                pgSqlValueType = "double precision";

            else if (msSqlValueType.IndexOf("decimal") >= 0)
                pgSqlValueType = "double precision";

            else if (msSqlValueType.IndexOf("bit") >= 0)
                pgSqlValueType = "boolean";

            else if (msSqlValueType.IndexOf("datetime") >= 0)
                pgSqlValueType = "timestamp";

            else if (msSqlValueType.IndexOf("date") >= 0)
                pgSqlValueType = "date";

            else if (msSqlValueType.IndexOf("time") >= 0)
                pgSqlValueType = "time";

            else pgSqlValueType = "text";

            MessageBox.Show(msSqlValueType + " to pg >>>> " + pgSqlValueType);
            return pgSqlValueType;
        }

        public String convertValueTypeToMsSql(String psSqlValueType)
        {
            String msSqlValueType = "";

            if (psSqlValueType.IndexOf("int") >= 0)
                msSqlValueType = "integer";

            else if (psSqlValueType.IndexOf("double precision") >= 0)
                msSqlValueType = "double precision";

            else if (psSqlValueType.IndexOf("boolean") >= 0)
                msSqlValueType = "bit";

            else if (psSqlValueType.IndexOf("timestamp") >= 0)
                msSqlValueType = "datetime";

            else if (psSqlValueType.IndexOf("date") >= 0)
                msSqlValueType = "date";

            else if (psSqlValueType.IndexOf("time") >= 0)
                msSqlValueType = "time";

            else msSqlValueType = "text";

            MessageBox.Show(psSqlValueType + " to mssql >>>> " + msSqlValueType);
            return msSqlValueType;
        }


        public String getCreateTablePgSqlQuery(DataGridView dataGridView, String targetTable)
        {
            int columnNumber = Int32.Parse(dataGridView.Rows.Count.ToString());

            string pgSqlQuery = $@"CREATE TABLE {targetTable}(";

            for (int i = 1; i < columnNumber; i++)
            {
                pgSqlQuery += dataGridView.Rows[(i - 1)].Cells[0].Value.ToString();

                String msSqlValueType = dataGridView.Rows[(i - 1)].Cells[1].Value.ToString();
                String pgSqlValueType =
                    convertValueTypeToPgSql(msSqlValueType);

                pgSqlQuery += " " + pgSqlValueType + " ,";

            }

            pgSqlQuery = pgSqlQuery.Substring(0, pgSqlQuery.Length - 1);
            pgSqlQuery += ")";
            MessageBox.Show(pgSqlQuery);
            return pgSqlQuery;
        }

        public String getCreateTableSqlQuery(DataGridView dataGridView, String targetTable)
        {
            int columnNumber = Int32.Parse(dataGridView.Rows.Count.ToString());

            string sqlQuery = $@"CREATE TABLE {targetTable}(";

            for (int i = 1; i < columnNumber; i++)
            {
                sqlQuery += dataGridView.Rows[(i - 1)].Cells[0].Value.ToString();  //Alan adı

                String pgSqlValueType = dataGridView.Rows[(i - 1)].Cells[1].Value.ToString();
                String msSqlValueType =
                    convertValueTypeToMsSql(pgSqlValueType);

                sqlQuery += " " + msSqlValueType + " ,"; //Alan tipi
            }

            sqlQuery += ")";
            MessageBox.Show(sqlQuery);
            return sqlQuery;
        }


        public void createSqlTable(String sqlConnectionString, String sqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = sqlQuery;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException sqlException)
                {
                    if (sqlException.Number == 2714)
                        MessageBox.Show("Bu tablo zaten mevcut.");
                }

            }
        }

        public void createPgSqlTable(String PgSqlConnectionString, String pgSqlQuery)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(PgSqlConnectionString))
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = pgSqlQuery;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (NpgsqlException npgSqlException)
                {
                    if (npgSqlException.Message.Contains("42P07"))
                        MessageBox.Show("Bu tablo zaten mevcut.");
                }

            }

        }


        public void insertIntoSqlTable(String connectionString, String sqlConnectionString, String npgSqlTableName, String msSqlTable)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int columnNumber = (dataGridView.Rows.Count) - 1;

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                uint offSetNumber = 0;
                connection.Open();
                command.Connection = connection;

                command.CommandText = "Select *" +
                                       $"From public.\"{npgSqlTableName}\"" +
                                       $"LIMIT 100 OFFSET {offSetNumber}";

                NpgsqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.HasRows)
                {
                    StringBuilder commandSqlInsertQuery = new StringBuilder();

                    while (dataReader.Read())
                    {
                        commandSqlInsertQuery.Append($"INSERT INTO {msSqlTable} " +
                                                     $"VALUES (");

                        if (columnNumber > 1)
                        {
                            //get first data for no exception because of ','

                            String dataType = dataGridView.Rows[0].Cells[1].Value.ToString();
                            String data = dataReader[0].ToString();

                            data =
                                getInsertIntoQueryData(data, dataType);

                            commandSqlInsertQuery.Append(data);

                            for (int i = 1; i < columnNumber; i++)
                            {
                                dataType = dataGridView.Rows[i].Cells[1].Value.ToString();
                                data = dataReader[i].ToString();

                                data =
                                    getInsertIntoQueryData(data, dataType);

                                commandSqlInsertQuery.Append("," + data);

                            }

                        }

                        commandSqlInsertQuery.Append("); ");

                    }

                    //MessageBox.Show(commandSqlInsertQuery.ToString());
                    copyAllDataToMsSql(sqlConnectionString, commandSqlInsertQuery.ToString());

                    offSetNumber += 100;                                 //Query for next 100 data
                    command.CommandText = "Select *" +
                                           $"From public.\"{npgSqlTableName}\"" +
                                           $"LIMIT 100 OFFSET {offSetNumber}";

                    dataReader.Close();
                    dataReader = command.ExecuteReader();
                }

                dataReader.Close();
            }

            timer.Stop();
            lblProcessTime.Text = ("Kopyalama başarılı.\n" +
                           timer.Elapsed.TotalSeconds +
                           " saniye işlem zamanı");
        }

        public void insertIntoPgSqlTable(String sqlConnectionString, String npgSqlConnectionString, String msSqlTable, String pgSqlTableName)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int columnNumber = (dataGridView.Rows.Count) - 1;

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            using (SqlCommand command = new SqlCommand())
            {
                uint offSetNumber = 0;
                connection.Open();
                command.Connection = connection;

                command.CommandText = "Select *" +
                                       $"From \"{msSqlTable}\" " +
                                       $"Order By {dataGridView.Rows[0].Cells[0].Value.ToString()} " +
                                       $"OFFSET {offSetNumber} ROWS " +
                                       $"Fetch Next 100 ROWS ONLY";

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.HasRows)
                {
                    StringBuilder commandPgSqlInsertQuery = new StringBuilder();

                    while (dataReader.Read())
                    {
                        commandPgSqlInsertQuery.Append($"INSERT INTO \"{pgSqlTableName.ToLower()}\" " +
                                                       $"VALUES (");

                        //get first data for no exception because of ','

                        String dataType = dataGridView.Rows[0].Cells[1].Value.ToString();
                        String data = dataReader[0].ToString();

                        data =
                            getInsertIntoQueryData(data, dataType);

                        commandPgSqlInsertQuery.Append(data);


                        if (columnNumber > 1)
                        {
                            for (int i = 1; i < columnNumber; i++)
                            {
                                dataType = dataGridView.Rows[i].Cells[1].Value.ToString();
                                data = dataReader[i].ToString();

                                data =
                                    getInsertIntoQueryData(data, dataType);

                                commandPgSqlInsertQuery.Append("," + data);

                            }

                        }

                        commandPgSqlInsertQuery.Append("); ");
                    }

                    //MessageBox.Show(commandPgSqlInsertQuery.ToString());
                    copyAllDataToPgSql(npgSqlConnectionString, commandPgSqlInsertQuery.ToString());

                    offSetNumber += 100;                                 //Query for next 100 data
                    command.CommandText = "Select *" +
                                       $"From \"{msSqlTable}\" " +
                                       $"Order By {dataGridView.Rows[0].Cells[0].Value.ToString()} " +
                                       $"OFFSET {offSetNumber} ROWS " +
                                       $"Fetch Next 100 ROWS ONLY";

                    dataReader.Close();
                    dataReader = command.ExecuteReader();
                }

                dataReader.Close();

            }

            timer.Stop();
            lblProcessTime.Text = ("Kopyalama başarılı.\n" +
                           timer.Elapsed.TotalSeconds +
                           " saniye işlem zamanı");
        }

        public String getInsertIntoQueryData(String data, String dataType)
        {
            if (dataType.IndexOf("int") >= 0)
                return data;

            else if (dataType.IndexOf("boolean") >= 0)
            {
                if (data.Equals("true")) return "1";
                else return "0";
            }

            else if (dataType.IndexOf("bit") >= 0)
            {
                if (data.Equals("1")) return "true";
                else return "false";
            }

            else if (dataType.IndexOf("datetime")>=0)
                return ("'" + data + "'");

            else if (dataType.IndexOf("date") >= 0)
                return ("'" + data + "'");

            else if (dataType.IndexOf("time") >= 0)
                return ("'" + data + "'");

            else
                return ("'" + data + "'");


        }

        public void copyAllDataToMsSql(String sqlConnectionString, String insertIntoSqlQuery)
        {
            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            using (SqlCommand command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = insertIntoSqlQuery;
                command.ExecuteNonQuery();
            }
        }

        public void copyAllDataToPgSql(String pgSqlConnectionString, String insertIntoPgSqlQuery)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(pgSqlConnectionString))
            using (NpgsqlCommand command = new NpgsqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = insertIntoPgSqlQuery;
                command.ExecuteNonQuery();
            }
        }


        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (radioBtnFromPgSqlToMsSql.Checked)
            {
                String npgSqlServer = txtSourcePgSqlServer.Text;
                String npgSqlPort = txtSourcePgSqlPort.Text;
                String npgSqlDb = txtSourcePgSqlDb.Text;
                String npgSqlTableName = txtSourcePgSqlTable.Text;
                String npgSqlUserId = txtSourcePgSqlUserId.Text;
                String npgSqlPassword = txtSourcePgSqlPassword.Text;

                String msSqlServer = txtDestinationMsSqlServer.Text;
                String msSqlDb = txtDestinationMsSqlDb.Text;
                String msSqlId = txtDestinationMsSqlUserId.Text;
                String msSqlTable = txtDestinationMsSqlTable.Text;

                var npgConnectionString =
                    getNpgsqlConnectionString(npgSqlServer, npgSqlPort, npgSqlDb, npgSqlUserId, npgSqlPassword);

                var sqlConnectionString =
                    getSqlConnectionString(msSqlServer, msSqlDb, msSqlId);

                getPgTableInformations(npgConnectionString, npgSqlTableName);

                String sqlQuery =
                    getCreateTableSqlQuery(dataGridView, msSqlTable);

                createSqlTable(sqlConnectionString, sqlQuery);

                insertIntoSqlTable(npgConnectionString, sqlConnectionString, npgSqlTableName, msSqlTable);
            }

            else
            {
                String sourceMsSqlServer = txtSourceMsSqlServer.Text;
                String sourceMsSqlDb = txtSourceMsSqlDb.Text;
                String sourceMsSqlId = txtSourceMsSqlUserId.Text;
                String sourceMsSqlTable = txtSourceMsSqlTable.Text;

                String destinationNpgSqlServer = txtDestinationPgSqlServer.Text;
                String destinationNpgSqlPort = txtDestinationPgSqlPort.Text;
                String destinationNpgSqlDb = txtDestinationPgSqlDb.Text;
                String destinationNpgSqlTableName = txtDestinationPgSqlTable.Text;
                String destinationNpgSqlUserId = txtDestinationPgSqlUserId.Text;
                String destinationNpgSqlPassword = txtDestinationPgSqlPassword.Text;

                var pgSqlConnectionString =
                    getNpgsqlConnectionString(destinationNpgSqlServer, destinationNpgSqlPort, destinationNpgSqlDb, destinationNpgSqlUserId, destinationNpgSqlPassword);

                var sqlConnectionString =
                    getSqlConnectionString(sourceMsSqlServer, sourceMsSqlDb, sourceMsSqlId);

                getSqlTableInformations(sqlConnectionString, sourceMsSqlTable);

                String pgSqlCreateTableQuery =
                    getCreateTablePgSqlQuery(dataGridView, destinationNpgSqlTableName);

                createPgSqlTable(pgSqlConnectionString, pgSqlCreateTableQuery);

                insertIntoPgSqlTable(sqlConnectionString, pgSqlConnectionString, sourceMsSqlTable, destinationNpgSqlTableName);

            }

            //(dataGridView.Rows.Count.ToString()); //count of column
            //(dataGridView.Rows[0].Cells[0].Value.ToString()); //Name of column
            //(dataGridView.Rows[0].Cells[1].Value.ToString()); //Type of column
        }

        private void radioBtnFromMsSql_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnFromMsSqlToPgSql.Checked)
            {
                groupSourceMsSql.Visible = true;
                groupDestinationPgSql.Visible = true;

            }
            else
            {
                groupSourceMsSql.Visible = false;
                groupDestinationPgSql.Visible = false;
            }
        }

        private void radioBtnFromPgSqlToMsSql_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnFromPgSqlToMsSql.Checked)
            {
                groupSourcePgSql.Visible = true;
                groupDestinationMsSql.Visible = true;
            }
            else
            {
                groupSourcePgSql.Visible = false;
                groupDestinationMsSql.Visible = false;
            }
        }


    }
}

