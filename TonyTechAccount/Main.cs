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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Dispose();
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            NewAccount newAccountForm = new NewAccount(this);
            newAccountForm.Show();
            this.Hide();
        }
    }
}
