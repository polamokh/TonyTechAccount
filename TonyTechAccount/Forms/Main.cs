using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TonyTechAccount
{
    public partial class Main : Form
    {
        public static string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "su2VzkzdyUYWzVYs.mdf");

        public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=" + databasePath + ";Integrated Security=True;Connect Timeout=30";

        public static SqlConnection connection;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool isDatabaseExist = System.IO.File.Exists(databasePath);

            if (!isDatabaseExist)
                API.CreateSqlDatabase(databasePath);

            connection = new SqlConnection(connectionString);
            connection.Open();

            if (!isDatabaseExist)
                API.CreateTables(connection);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            connection.Dispose();
            Application.Exit();
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            Accounts accountsForm = new Accounts(this, connection);
            accountsForm.Show();
            this.Hide();
        }

        private void buttonBackupDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                connection.Dispose();
                string temp = buttonBackupDatabase.Text;
                buttonBackupDatabase.Text = "Please wait...";
                API.BackupDatabase(folderBrowserDialog.SelectedPath);
                buttonBackupDatabase.Text = temp;
            }
            folderBrowserDialog.Reset();
        }
    }
}
