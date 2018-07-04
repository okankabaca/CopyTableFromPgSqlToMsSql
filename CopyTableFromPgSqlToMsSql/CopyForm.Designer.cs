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
            this.txtNpgSqlServer = new System.Windows.Forms.TextBox();
            this.txtNpgSqlPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNpgSqlDb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNpgSqlUserId = new System.Windows.Forms.TextBox();
            this.txtNpgSqlPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNpgSqlTable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMsSqlServer = new System.Windows.Forms.TextBox();
            this.txtMsSqlDb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMsSqlUserId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMsSqlTable = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(317, 194);
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
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NpgSQL Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NpgSQL Port";
            // 
            // txtNpgSqlServer
            // 
            this.txtNpgSqlServer.Location = new System.Drawing.Point(132, 19);
            this.txtNpgSqlServer.Name = "txtNpgSqlServer";
            this.txtNpgSqlServer.Size = new System.Drawing.Size(118, 20);
            this.txtNpgSqlServer.TabIndex = 4;
            this.txtNpgSqlServer.Text = "127.0.0.1";
            // 
            // txtNpgSqlPort
            // 
            this.txtNpgSqlPort.Location = new System.Drawing.Point(132, 45);
            this.txtNpgSqlPort.Name = "txtNpgSqlPort";
            this.txtNpgSqlPort.Size = new System.Drawing.Size(118, 20);
            this.txtNpgSqlPort.TabIndex = 5;
            this.txtNpgSqlPort.Text = "5432";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NpgSQL DB";
            // 
            // txtNpgSqlDb
            // 
            this.txtNpgSqlDb.Location = new System.Drawing.Point(132, 71);
            this.txtNpgSqlDb.Name = "txtNpgSqlDb";
            this.txtNpgSqlDb.Size = new System.Drawing.Size(118, 20);
            this.txtNpgSqlDb.TabIndex = 7;
            this.txtNpgSqlDb.Text = "dbSource";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NpgSQL User ID";
            // 
            // txtNpgSqlUserId
            // 
            this.txtNpgSqlUserId.Location = new System.Drawing.Point(132, 123);
            this.txtNpgSqlUserId.Name = "txtNpgSqlUserId";
            this.txtNpgSqlUserId.Size = new System.Drawing.Size(118, 20);
            this.txtNpgSqlUserId.TabIndex = 9;
            this.txtNpgSqlUserId.Text = "postgres";
            // 
            // txtNpgSqlPassword
            // 
            this.txtNpgSqlPassword.Location = new System.Drawing.Point(132, 149);
            this.txtNpgSqlPassword.Name = "txtNpgSqlPassword";
            this.txtNpgSqlPassword.Size = new System.Drawing.Size(118, 20);
            this.txtNpgSqlPassword.TabIndex = 11;
            this.txtNpgSqlPassword.Text = "Logo1234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "NpgSQL Password";
            // 
            // txtNpgSqlTable
            // 
            this.txtNpgSqlTable.Location = new System.Drawing.Point(132, 97);
            this.txtNpgSqlTable.Name = "txtNpgSqlTable";
            this.txtNpgSqlTable.Size = new System.Drawing.Size(118, 20);
            this.txtNpgSqlTable.TabIndex = 13;
            this.txtNpgSqlTable.Text = "tableSource";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "NpgSQL Table";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "MsSQL Server";
            // 
            // txtMsSqlServer
            // 
            this.txtMsSqlServer.Location = new System.Drawing.Point(416, 19);
            this.txtMsSqlServer.Name = "txtMsSqlServer";
            this.txtMsSqlServer.Size = new System.Drawing.Size(118, 20);
            this.txtMsSqlServer.TabIndex = 15;
            this.txtMsSqlServer.Text = "GEBZEHAVUZ17";
            // 
            // txtMsSqlDb
            // 
            this.txtMsSqlDb.Location = new System.Drawing.Point(416, 45);
            this.txtMsSqlDb.Name = "txtMsSqlDb";
            this.txtMsSqlDb.Size = new System.Drawing.Size(118, 20);
            this.txtMsSqlDb.TabIndex = 17;
            this.txtMsSqlDb.Text = "dbStaj";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "MsSQL DB";
            // 
            // txtMsSqlUserId
            // 
            this.txtMsSqlUserId.Location = new System.Drawing.Point(416, 71);
            this.txtMsSqlUserId.Name = "txtMsSqlUserId";
            this.txtMsSqlUserId.Size = new System.Drawing.Size(118, 20);
            this.txtMsSqlUserId.TabIndex = 19;
            this.txtMsSqlUserId.Text = "LOGOMERKEZ\\Okan.Kabaca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "MsSQL User ID";
            // 
            // txtMsSqlTable
            // 
            this.txtMsSqlTable.Location = new System.Drawing.Point(416, 97);
            this.txtMsSqlTable.Name = "txtMsSqlTable";
            this.txtMsSqlTable.Size = new System.Drawing.Size(118, 20);
            this.txtMsSqlTable.TabIndex = 21;
            this.txtMsSqlTable.Text = "dbBackUp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(314, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "MsSQL Table";
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.txtMsSqlTable);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMsSqlUserId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMsSqlDb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMsSqlServer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNpgSqlTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNpgSqlPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNpgSqlUserId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNpgSqlDb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNpgSqlPort);
            this.Controls.Add(this.txtNpgSqlServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnBackup);
            this.Name = "CopyForm";
            this.Text = "CopyForm";
            this.Load += new System.EventHandler(this.CopyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNpgSqlServer;
        private System.Windows.Forms.TextBox txtNpgSqlPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNpgSqlDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNpgSqlUserId;
        private System.Windows.Forms.TextBox txtNpgSqlPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNpgSqlTable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMsSqlServer;
        private System.Windows.Forms.TextBox txtMsSqlDb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMsSqlUserId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMsSqlTable;
        private System.Windows.Forms.Label label10;
    }
}

