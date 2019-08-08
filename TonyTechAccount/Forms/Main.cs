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
        private static string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            "su2VzkzdyUYWzVYs.mdf");

        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=" + databasePath + ";Integrated Security=True;Connect Timeout=30";

        private static SqlConnection connection = new SqlConnection(connectionString);

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool isDatabaseExist = System.IO.File.Exists(databasePath);

            if (!isDatabaseExist)
                API.CreateSqlDatabase(databasePath);

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
    }
}
