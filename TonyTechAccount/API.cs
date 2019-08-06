using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TonyTechAccount
{
    class API
    {
        public static string ConstructEmail(string email, string type)
        {
            return email.ToLower() + "@" + type.ToLower() + ".com";
        }

        public static void NewAccount(string type, Account account, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandText = string.Format("INSERT INTO Account VALUES(" +
                "'{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, '{7}', '{8}')",
                ConstructEmail(account.Email, type), account.FirstName, account.LastName,
                account.MobileNumber, account.BD_Day, account.BD_Month, account.BD_Year,
                account.Password, type);

            adapter.InsertCommand = new SqlCommand(commandText, connection);
            adapter.InsertCommand.ExecuteNonQuery();
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
                "PRIMARY KEY CLUSTERED ([Email] ASC)" +
                ");";
            adapter.InsertCommand = new SqlCommand(commandText, connection);
            adapter.InsertCommand.ExecuteNonQuery();
        }
    }
}
