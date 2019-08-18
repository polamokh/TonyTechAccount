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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            bool isDatabaseExist = System.IO.File.Exists(databasePath);

            if (!isDatabaseExist)
            {
                API.CreateSqlDatabase(databasePath);
                API.CreateTables(new SqlConnection(connectionString));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAccounts_Click(object sender, EventArgs e)
        {
            Accounts accountsForm = new Accounts(this, new SqlConnection(connectionString));
            accountsForm.Visible = true;
            this.Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            Forms.Print printForm = new Forms.Print(this, new SqlConnection(connectionString));
            printForm.Visible = true;
            this.Visible = false;
        }
    }
}
