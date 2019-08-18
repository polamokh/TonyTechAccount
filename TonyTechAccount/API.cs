using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing;

namespace TonyTechAccount
{
    class API
    {
        public static bool NewAccount(Account account, SqlConnection connection)
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
                return false;
            }

            MessageBox.Show("The account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
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

        public static DataSet GetData(SqlConnection connection, string searchType = "", string searchText = "")
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandText = "";

            if (searchText == "")
                commandText = string.Format("SELECT * FROM Account");
            else
            {
                if (searchType == "Type")
                    commandText = string.Format("SELECT * FROM Account WHERE Acc_Type like '%{0}%'", searchText);
                else if (searchType == "First Name")
                    commandText = string.Format("SELECT * FROM Account WHERE FName like '%{0}%'", searchText);
                else if (searchType == "Last Name")
                    commandText = string.Format("SELECT * FROM Account WHERE LName like '%{0}%'", searchText);
                else if (searchType == "Mobile Number")
                    commandText = string.Format("SELECT * FROM Account WHERE MobileNumber like '%{0}%'", searchText);
                else if (searchType == "Email")
                    commandText = string.Format("SELECT * FROM Account WHERE Email like '%{0}%'", searchText);
                else if (searchType == "Created On")
                    try
                    {
                        commandText = string.Format("SELECT * FROM Account WHERE Created_On = '{0}'",
                            DateTime.Parse(searchText));
                    }
                    catch (Exception)
                    {
                        commandText = string.Format("SELECT * FROM Account");
                    }
            }

            adapter.SelectCommand = new SqlCommand(commandText, connection);
            adapter.Fill(dataSet);

            return dataSet;
        }

        public static bool DeleteAccount(string email, string type, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string commandText = string.Format("DELETE Account WHERE Email = '{0}' AND Acc_Type = '{1}'",
                email, type);

            adapter.InsertCommand = new SqlCommand(commandText, connection);
            DialogResult result = MessageBox.Show("Are you sure that you want to delete this account?", "Ask",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    adapter.InsertCommand.ExecuteNonQuery();
                    MessageBox.Show("The account deleted successfully!", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        public static List<string> ExtractDataToPrint(DataSet dataSet)
        {
            List<string> data = new List<string>();
            data.Add(dataSet.Tables[0].Rows[0]["FName"].ToString() + ' ' + dataSet.Tables[0].Rows[0]["LName"].ToString());
            data.Add(dataSet.Tables[0].Rows[0]["Email"].ToString());
            data.Add(dataSet.Tables[0].Rows[0]["Acc_Password"].ToString());
            data.Add(dataSet.Tables[0].Rows[0]["BD_Day"].ToString() + '/' + dataSet.Tables[0].Rows[0]["BD_Month"].ToString() +
                '/' + dataSet.Tables[0].Rows[0]["BD_Year"].ToString());

            return data;
        }

        public static void CreatePrintLables(int x, int y, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Name: ", new Font("Tahoma", 12, FontStyle.Regular),
                    Brushes.Black, new Point(x, y));
            y += 25;
            e.Graphics.DrawString("Email: ", new Font("Tahoma", 12, FontStyle.Regular),
                Brushes.Black, new Point(x, y));
            y += 25;
            e.Graphics.DrawString("Password: ", new Font("Tahoma", 12, FontStyle.Regular),
                Brushes.Black, new Point(x, y));
            y += 25;
            e.Graphics.DrawString("Birthdate: ", new Font("Tahoma", 12, FontStyle.Regular),
                Brushes.Black, new Point(x, y));
            y += 30;
            e.Graphics.DrawString("PLEASE KEEP THIS PAPER IN A SAFE PLACE.", new Font("Tahoma", 12, FontStyle.Bold),
                    Brushes.Black, new Point(x, y));
        }

        public static void FillPrintData(int x, int y, List<string> data, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(data[0], new Font("Tahoma", 12, FontStyle.Bold),
                    Brushes.Black, new Point(x, y));
            y += 25;
            e.Graphics.DrawString(data[1], new Font("Tahoma", 12, FontStyle.Bold),
                Brushes.Black, new Point(x, y));
            y += 25;
            e.Graphics.DrawString(data[2], new Font("Tahoma", 12, FontStyle.Bold),
                Brushes.Black, new Point(x, y));
            y += 25;
            e.Graphics.DrawString(data[3], new Font("Tahoma", 12, FontStyle.Bold),
                Brushes.Black, new Point(x, y));
        }
    }
}
