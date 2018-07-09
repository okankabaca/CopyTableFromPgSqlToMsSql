namespace CopyTableFromPgSqlToMsSql
{
    partial class CopyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBackup = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSourcePgSqlServer = new System.Windows.Forms.TextBox();
            this.txtSourcePgSqlPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSourcePgSqlDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSourcePgSqlUserId = new System.Windows.Forms.TextBox();
            this.txtSourcePgSqlPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSourcePgSqlTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDestinationMsSqlServer = new System.Windows.Forms.TextBox();
            this.txtDestinationMsSqlDb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDestinationMsSqlUserId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDestinationMsSqlTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProcessTime = new System.Windows.Forms.Label();
            this.radioBtnFromPgSqlToMsSql = new System.Windows.Forms.RadioButton();
            this.radioBtnFromMsSqlToPgSql = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupSourcePgSql = new System.Windows.Forms.GroupBox();
            this.groupDestinationMsSql = new System.Windows.Forms.GroupBox();
            this.groupDestinationPgSql = new System.Windows.Forms.GroupBox();
            this.txtDestinationPgSqlTable = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDestinationPgSqlPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDestinationPgSqlUserId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDestinationPgSqlDb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDestinationPgSqlPort = new System.Windows.Forms.TextBox();
            this.txtDestinationPgSqlServer = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupSourceMsSql = new System.Windows.Forms.GroupBox();
            this.txtSourceMsSqlTable = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSourceMsSqlUserId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSourceMsSqlDb = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSourceMsSqlServer = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupSourcePgSql.SuspendLayout();
            this.groupDestinationMsSql.SuspendLayout();
            this.groupDestinationPgSql.SuspendLayout();
            this.groupSourceMsSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(313, 286);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 194);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NpgSQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NpgSQL Port";
            // 
            // txtSourcePgSqlServer
            // 
            this.txtSourcePgSqlServer.Location = new System.Drawing.Point(105, 14);
            this.txtSourcePgSqlServer.Name = "txtSourcePgSqlServer";
            this.txtSourcePgSqlServer.Size = new System.Drawing.Size(118, 20);
            this.txtSourcePgSqlServer.TabIndex = 4;
            this.txtSourcePgSqlServer.Text = "127.0.0.1";
            // 
            // txtSourcePgSqlPort
            // 
            this.txtSourcePgSqlPort.Location = new System.Drawing.Point(105, 40);
            this.txtSourcePgSqlPort.Name = "txtSourcePgSqlPort";
            this.txtSourcePgSqlPort.Size = new System.Drawing.Size(118, 20);
            this.txtSourcePgSqlPort.TabIndex = 5;
            this.txtSourcePgSqlPort.Text = "5432";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NpgSQL DB";
            // 
            // txtSourcePgSqlDb
            // 
            this.txtSourcePgSqlDb.Location = new System.Drawing.Point(105, 66);
            this.txtSourcePgSqlDb.Name = "txtSourcePgSqlDb";
            this.txtSourcePgSqlDb.Size = new System.Drawing.Size(118, 20);
            this.txtSourcePgSqlDb.TabIndex = 7;
            this.txtSourcePgSqlDb.Text = "dbSource";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NpgSQL User ID";
            // 
            // txtSourcePgSqlUserId
            // 
            this.txtSourcePgSqlUserId.Location = new System.Drawing.Point(105, 118);
            this.txtSourcePgSqlUserId.Name = "txtSourcePgSqlUserId";
            this.txtSourcePgSqlUserId.Size = new System.Drawing.Size(118, 20);
            this.txtSourcePgSqlUserId.TabIndex = 9;
            this.txtSourcePgSqlUserId.Text = "postgres";
            // 
            // txtSourcePgSqlPassword
            // 
            this.txtSourcePgSqlPassword.Location = new System.Drawing.Point(105, 144);
            this.txtSourcePgSqlPassword.Name = "txtSourcePgSqlPassword";
            this.txtSourcePgSqlPassword.Size = new System.Drawing.Size(118, 20);
            this.txtSourcePgSqlPassword.TabIndex = 11;
            this.txtSourcePgSqlPassword.Text = "Logo1234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NpgSQL Password";
            // 
            // txtSourcePgSqlTable
            // 
            this.txtSourcePgSqlTable.Location = new System.Drawing.Point(105, 92);
            this.txtSourcePgSqlTable.Name = "txtSourcePgSqlTable";
            this.txtSourcePgSqlTable.Size = new System.Drawing.Size(118, 20);
            this.txtSourcePgSqlTable.TabIndex = 13;
            this.txtSourcePgSqlTable.Text = "tablesource";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NpgSQL Table";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "MsSQL Server";
            // 
            // txtDestinationMsSqlServer
            // 
            this.txtDestinationMsSqlServer.Location = new System.Drawing.Point(112, 14);
            this.txtDestinationMsSqlServer.Name = "txtDestinationMsSqlServer";
            this.txtDestinationMsSqlServer.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationMsSqlServer.TabIndex = 15;
            this.txtDestinationMsSqlServer.Text = "GEBZEHAVUZ17";
            // 
            // txtDestinationMsSqlDb
            // 
            this.txtDestinationMsSqlDb.Location = new System.Drawing.Point(112, 40);
            this.txtDestinationMsSqlDb.Name = "txtDestinationMsSqlDb";
            this.txtDestinationMsSqlDb.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationMsSqlDb.TabIndex = 17;
            this.txtDestinationMsSqlDb.Text = "dbStaj";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "MsSQL DB";
            // 
            // txtDestinationMsSqlUserId
            // 
            this.txtDestinationMsSqlUserId.Location = new System.Drawing.Point(112, 66);
            this.txtDestinationMsSqlUserId.Name = "txtDestinationMsSqlUserId";
            this.txtDestinationMsSqlUserId.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationMsSqlUserId.TabIndex = 19;
            this.txtDestinationMsSqlUserId.Text = "LOGOMERKEZ\\Okan.Kabaca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "MsSQL User ID";
            // 
            // txtDestinationMsSqlTable
            // 
            this.txtDestinationMsSqlTable.Location = new System.Drawing.Point(112, 92);
            this.txtDestinationMsSqlTable.Name = "txtDestinationMsSqlTable";
            this.txtDestinationMsSqlTable.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationMsSqlTable.TabIndex = 21;
            this.txtDestinationMsSqlTable.Text = "tableBackUp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "MsSQL Table";
            // 
            // lblProcessTime
            // 
            this.lblProcessTime.AutoSize = true;
            this.lblProcessTime.Location = new System.Drawing.Point(314, 315);
            this.lblProcessTime.Name = "lblProcessTime";
            this.lblProcessTime.Size = new System.Drawing.Size(13, 13);
            this.lblProcessTime.TabIndex = 22;
            this.lblProcessTime.Text = "0";
            // 
            // radioBtnFromPgSqlToMsSql
            // 
            this.radioBtnFromPgSqlToMsSql.AutoSize = true;
            this.radioBtnFromPgSqlToMsSql.Location = new System.Drawing.Point(11, 19);
            this.radioBtnFromPgSqlToMsSql.Name = "radioBtnFromPgSqlToMsSql";
            this.radioBtnFromPgSqlToMsSql.Size = new System.Drawing.Size(109, 17);
            this.radioBtnFromPgSqlToMsSql.TabIndex = 23;
            this.radioBtnFromPgSqlToMsSql.TabStop = true;
            this.radioBtnFromPgSqlToMsSql.Text = "PgSQL to MsSQL";
            this.radioBtnFromPgSqlToMsSql.UseVisualStyleBackColor = true;
            this.radioBtnFromPgSqlToMsSql.CheckedChanged += new System.EventHandler(this.radioBtnFromPgSqlToMsSql_CheckedChanged);
            // 
            // radioBtnFromMsSqlToPgSql
            // 
            this.radioBtnFromMsSqlToPgSql.AutoSize = true;
            this.radioBtnFromMsSqlToPgSql.Location = new System.Drawing.Point(11, 42);
            this.radioBtnFromMsSqlToPgSql.Name = "radioBtnFromMsSqlToPgSql";
            this.radioBtnFromMsSqlToPgSql.Size = new System.Drawing.Size(109, 17);
            this.radioBtnFromMsSqlToPgSql.TabIndex = 24;
            this.radioBtnFromMsSqlToPgSql.TabStop = true;
            this.radioBtnFromMsSqlToPgSql.Text = "MsSQL to PgSQL";
            this.radioBtnFromMsSqlToPgSql.UseVisualStyleBackColor = true;
            this.radioBtnFromMsSqlToPgSql.CheckedChanged += new System.EventHandler(this.radioBtnFromMsSql_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnFromMsSqlToPgSql);
            this.groupBox1.Controls.Add(this.radioBtnFromPgSqlToMsSql);
            this.groupBox1.Location = new System.Drawing.Point(306, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 73);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Process Type";
            // 
            // groupSourcePgSql
            // 
            this.groupSourcePgSql.Controls.Add(this.txtSourcePgSqlTable);
            this.groupSourcePgSql.Controls.Add(this.label6);
            this.groupSourcePgSql.Controls.Add(this.txtSourcePgSqlPassword);
            this.groupSourcePgSql.Controls.Add(this.label5);
            this.groupSourcePgSql.Controls.Add(this.txtSourcePgSqlUserId);
            this.groupSourcePgSql.Controls.Add(this.label4);
            this.groupSourcePgSql.Controls.Add(this.txtSourcePgSqlDb);
            this.groupSourcePgSql.Controls.Add(this.label3);
            this.groupSourcePgSql.Controls.Add(this.txtSourcePgSqlPort);
            this.groupSourcePgSql.Controls.Add(this.txtSourcePgSqlServer);
            this.groupSourcePgSql.Controls.Add(this.label2);
            this.groupSourcePgSql.Controls.Add(this.label1);
            this.groupSourcePgSql.Location = new System.Drawing.Point(27, 5);
            this.groupSourcePgSql.Name = "groupSourcePgSql";
            this.groupSourcePgSql.Size = new System.Drawing.Size(250, 178);
            this.groupSourcePgSql.TabIndex = 26;
            this.groupSourcePgSql.TabStop = false;
            this.groupSourcePgSql.Text = "Source PgSQL Db";
            // 
            // groupDestinationMsSql
            // 
            this.groupDestinationMsSql.Controls.Add(this.txtDestinationMsSqlTable);
            this.groupDestinationMsSql.Controls.Add(this.label10);
            this.groupDestinationMsSql.Controls.Add(this.txtDestinationMsSqlUserId);
            this.groupDestinationMsSql.Controls.Add(this.label9);
            this.groupDestinationMsSql.Controls.Add(this.txtDestinationMsSqlDb);
            this.groupDestinationMsSql.Controls.Add(this.label8);
            this.groupDestinationMsSql.Controls.Add(this.txtDestinationMsSqlServer);
            this.groupDestinationMsSql.Controls.Add(this.label7);
            this.groupDestinationMsSql.Location = new System.Drawing.Point(300, 5);
            this.groupDestinationMsSql.Name = "groupDestinationMsSql";
            this.groupDestinationMsSql.Size = new System.Drawing.Size(250, 178);
            this.groupDestinationMsSql.TabIndex = 27;
            this.groupDestinationMsSql.TabStop = false;
            this.groupDestinationMsSql.Text = "Destination MsSQLDb";
            // 
            // groupDestinationPgSql
            // 
            this.groupDestinationPgSql.Controls.Add(this.txtDestinationPgSqlTable);
            this.groupDestinationPgSql.Controls.Add(this.label11);
            this.groupDestinationPgSql.Controls.Add(this.txtDestinationPgSqlPassword);
            this.groupDestinationPgSql.Controls.Add(this.label12);
            this.groupDestinationPgSql.Controls.Add(this.txtDestinationPgSqlUserId);
            this.groupDestinationPgSql.Controls.Add(this.label13);
            this.groupDestinationPgSql.Controls.Add(this.txtDestinationPgSqlDb);
            this.groupDestinationPgSql.Controls.Add(this.label14);
            this.groupDestinationPgSql.Controls.Add(this.txtDestinationPgSqlPort);
            this.groupDestinationPgSql.Controls.Add(this.txtDestinationPgSqlServer);
            this.groupDestinationPgSql.Controls.Add(this.label15);
            this.groupDestinationPgSql.Controls.Add(this.label16);
            this.groupDestinationPgSql.Location = new System.Drawing.Point(300, 5);
            this.groupDestinationPgSql.Name = "groupDestinationPgSql";
            this.groupDestinationPgSql.Size = new System.Drawing.Size(250, 178);
            this.groupDestinationPgSql.TabIndex = 28;
            this.groupDestinationPgSql.TabStop = false;
            this.groupDestinationPgSql.Text = "Destination PgSQL Db";
            // 
            // txtDestinationPgSqlTable
            // 
            this.txtDestinationPgSqlTable.Location = new System.Drawing.Point(105, 92);
            this.txtDestinationPgSqlTable.Name = "txtDestinationPgSqlTable";
            this.txtDestinationPgSqlTable.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationPgSqlTable.TabIndex = 13;
            this.txtDestinationPgSqlTable.Text = "tableSource2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "NpgSQL Table";
            // 
            // txtDestinationPgSqlPassword
            // 
            this.txtDestinationPgSqlPassword.Location = new System.Drawing.Point(105, 144);
            this.txtDestinationPgSqlPassword.Name = "txtDestinationPgSqlPassword";
            this.txtDestinationPgSqlPassword.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationPgSqlPassword.TabIndex = 11;
            this.txtDestinationPgSqlPassword.Text = "Logo1234";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "NpgSQL Password";
            // 
            // txtDestinationPgSqlUserId
            // 
            this.txtDestinationPgSqlUserId.Location = new System.Drawing.Point(105, 118);
            this.txtDestinationPgSqlUserId.Name = "txtDestinationPgSqlUserId";
            this.txtDestinationPgSqlUserId.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationPgSqlUserId.TabIndex = 9;
            this.txtDestinationPgSqlUserId.Text = "postgres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "NpgSQL User ID";
            // 
            // txtDestinationPgSqlDb
            // 
            this.txtDestinationPgSqlDb.Location = new System.Drawing.Point(105, 66);
            this.txtDestinationPgSqlDb.Name = "txtDestinationPgSqlDb";
            this.txtDestinationPgSqlDb.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationPgSqlDb.TabIndex = 7;
            this.txtDestinationPgSqlDb.Text = "dbSource";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "NpgSQL DB";
            // 
            // txtDestinationPgSqlPort
            // 
            this.txtDestinationPgSqlPort.Location = new System.Drawing.Point(105, 40);
            this.txtDestinationPgSqlPort.Name = "txtDestinationPgSqlPort";
            this.txtDestinationPgSqlPort.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationPgSqlPort.TabIndex = 5;
            this.txtDestinationPgSqlPort.Text = "5432";
            // 
            // txtDestinationPgSqlServer
            // 
            this.txtDestinationPgSqlServer.Location = new System.Drawing.Point(105, 14);
            this.txtDestinationPgSqlServer.Name = "txtDestinationPgSqlServer";
            this.txtDestinationPgSqlServer.Size = new System.Drawing.Size(118, 20);
            this.txtDestinationPgSqlServer.TabIndex = 4;
            this.txtDestinationPgSqlServer.Text = "127.0.0.1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "NpgSQL Port";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "NpgSQL Server";
            // 
            // groupSourceMsSql
            // 
            this.groupSourceMsSql.Controls.Add(this.txtSourceMsSqlTable);
            this.groupSourceMsSql.Controls.Add(this.label17);
            this.groupSourceMsSql.Controls.Add(this.txtSourceMsSqlUserId);
            this.groupSourceMsSql.Controls.Add(this.label18);
            this.groupSourceMsSql.Controls.Add(this.txtSourceMsSqlDb);
            this.groupSourceMsSql.Controls.Add(this.label19);
            this.groupSourceMsSql.Controls.Add(this.txtSourceMsSqlServer);
            this.groupSourceMsSql.Controls.Add(this.label20);
            this.groupSourceMsSql.Location = new System.Drawing.Point(27, 5);
            this.groupSourceMsSql.Name = "groupSourceMsSql";
            this.groupSourceMsSql.Size = new System.Drawing.Size(250, 178);
            this.groupSourceMsSql.TabIndex = 28;
            this.groupSourceMsSql.TabStop = false;
            this.groupSourceMsSql.Text = "Source MsSQL Db";
            // 
            // txtSourceMsSqlTable
            // 
            this.txtSourceMsSqlTable.Location = new System.Drawing.Point(112, 92);
            this.txtSourceMsSqlTable.Name = "txtSourceMsSqlTable";
            this.txtSourceMsSqlTable.Size = new System.Drawing.Size(118, 20);
            this.txtSourceMsSqlTable.TabIndex = 21;
            this.txtSourceMsSqlTable.Text = "tableBackUp";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "MsSQL Table";
            // 
            // txtSourceMsSqlUserId
            // 
            this.txtSourceMsSqlUserId.Location = new System.Drawing.Point(112, 66);
            this.txtSourceMsSqlUserId.Name = "txtSourceMsSqlUserId";
            this.txtSourceMsSqlUserId.Size = new System.Drawing.Size(118, 20);
            this.txtSourceMsSqlUserId.TabIndex = 19;
            this.txtSourceMsSqlUserId.Text = "LOGOMERKEZ\\Okan.Kabaca";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "MsSQL User ID";
            // 
            // txtSourceMsSqlDb
            // 
            this.txtSourceMsSqlDb.Location = new System.Drawing.Point(112, 40);
            this.txtSourceMsSqlDb.Name = "txtSourceMsSqlDb";
            this.txtSourceMsSqlDb.Size = new System.Drawing.Size(118, 20);
            this.txtSourceMsSqlDb.TabIndex = 17;
            this.txtSourceMsSqlDb.Text = "dbStaj";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "MsSQL DB";
            // 
            // txtSourceMsSqlServer
            // 
            this.txtSourceMsSqlServer.Location = new System.Drawing.Point(112, 14);
            this.txtSourceMsSqlServer.Name = "txtSourceMsSqlServer";
            this.txtSourceMsSqlServer.Size = new System.Drawing.Size(118, 20);
            this.txtSourceMsSqlServer.TabIndex = 15;
            this.txtSourceMsSqlServer.Text = "GEBZEHAVUZ17";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "MsSQL Server";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.groupSourcePgSql);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProcessTime);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.groupDestinationPgSql);
            this.Controls.Add(this.groupDestinationMsSql);
            this.Controls.Add(this.groupSourceMsSql);
            this.Name = "CopyForm";
            this.Text = "CopyForm";
            this.Load += new System.EventHandler(this.CopyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupSourcePgSql.ResumeLayout(false);
            this.groupSourcePgSql.PerformLayout();
            this.groupDestinationMsSql.ResumeLayout(false);
            this.groupDestinationMsSql.PerformLayout();
            this.groupDestinationPgSql.ResumeLayout(false);
            this.groupDestinationPgSql.PerformLayout();
            this.groupSourceMsSql.ResumeLayout(false);
            this.groupSourceMsSql.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSourcePgSqlServer;
        private System.Windows.Forms.TextBox txtSourcePgSqlPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSourcePgSqlDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSourcePgSqlUserId;
        private System.Windows.Forms.TextBox txtSourcePgSqlPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSourcePgSqlTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDestinationMsSqlServer;
        private System.Windows.Forms.TextBox txtDestinationMsSqlDb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDestinationMsSqlUserId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDestinationMsSqlTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProcessTime;
        private System.Windows.Forms.RadioButton radioBtnFromPgSqlToMsSql;
        private System.Windows.Forms.RadioButton radioBtnFromMsSqlToPgSql;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupSourcePgSql;
        private System.Windows.Forms.GroupBox groupDestinationMsSql;
        private System.Windows.Forms.GroupBox groupDestinationPgSql;
        private System.Windows.Forms.TextBox txtDestinationPgSqlTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDestinationPgSqlPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDestinationPgSqlUserId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDestinationPgSqlDb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDestinationPgSqlPort;
        private System.Windows.Forms.TextBox txtDestinationPgSqlServer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupSourceMsSql;
        private System.Windows.Forms.TextBox txtSourceMsSqlTable;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSourceMsSqlUserId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtSourceMsSqlDb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSourceMsSqlServer;
        private System.Windows.Forms.Label label20;
    }
}

