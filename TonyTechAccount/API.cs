using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TonyTechAccount
{
    class API
    {
        /// <summary>
        /// Add new account in database.
        /// </summary>
        /// <param name="type">Account Type</param>
        /// <param name="account">Account Details</param>
        /// <param name="connection">Database Connection</param>
        public static void NewAccount(Account account, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandText = string.Format("INSERT INTO Account VALUES(" +
                "'{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, '{7}', '{8}', '{9}')",
                account.Email, account.FirstName, account.LastName,
                account.MobileNumber, account.BD_Day, account.BD_Month, account.BD_Year,
                account.Password, account.Type, account.Created_On);

            adapter.InsertCommand = new SqlCommand(commandText, connection);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("The account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void CreateSqlDatabase(string filename)
        {
            string databaseName = System.IO.Path.GetFileNameWithoutExtension(filename);
            using (var connection = new SqlConnection(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master; Integrated Security=True;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        String.Format("CREATE DATABASE {0} ON PRIMARY (NAME={0}, FILENAME='{1}')", databaseName, filename);
                    command.ExecuteNonQuery();

                    command.CommandText =
                        String.Format("EXEC sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CreateTables(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandText = "CREATE TABLE [dbo].[Account] (" +
                "[Email]        VARCHAR (256) NOT NULL," +
                "[FName]        VARCHAR (256) NOT NULL," +
                "[LName]        VARCHAR (256) NOT NULL," +
                "[MobileNumber] VARCHAR (18)  NULL," +
                "[BD_Day]       NUMERIC (2)   NOT NULL," +
                "[BD_Month]     NUMERIC (2)   NOT NULL," +
                "[BD_Year]      NUMERIC (4)   NOT NULL," +
                "[Acc_Password] VARCHAR (256) NOT NULL," +
                "[Acc_Type]     VARCHAR (256) NOT NULL," +
                "[Created_On] DATE NOT NULL," +
                "PRIMARY KEY CLUSTERED ([Email], [Acc_Type])" +
                ");";
            adapter.InsertCommand = new SqlCommand(commandText, connection);
            adapter.InsertCommand.ExecuteNonQuery();
        }

        public static void ClearTextboxes(TextBox[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                args[i].Text = "";
            }
        }

        public static bool CheckTextboxes(TextBox[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Text == "")
                    return false;
            }
            return true;
        }
    }
}
