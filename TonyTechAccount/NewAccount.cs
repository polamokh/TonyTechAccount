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
    public partial class NewAccount : Form
    {
        public static Form mainForm;
        public static SqlConnection connection;

        public NewAccount(Form form, SqlConnection conn)
        {
            InitializeComponent();
            mainForm = form;
            connection = conn;
        }

        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            textBoxCreatedOn.Text = DateTime.Now.Date.ToShortDateString();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            TextBox[] args = {textBoxFName, textBoxLName, textBoxMobile, textBoxBDDay, textBoxBDMonth,
                textBoxBDYear, textBoxEmail, textBoxPassword, textBoxCreatedOn};
            API.ClearTextboxes(args);
            this.Hide();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            TextBox[] args = {textBoxFName, textBoxLName, textBoxBDDay, textBoxBDMonth,
                textBoxBDYear, textBoxEmail, textBoxPassword, textBoxCreatedOn};
            if (API.CheckTextboxes(args))
            {
                API.NewAccount(new Account(textBoxFName.Text, textBoxLName.Text, textBoxMobile.Text,
                    int.Parse(textBoxBDDay.Text), int.Parse(textBoxBDMonth.Text), int.Parse(textBoxBDYear.Text),
                    textBoxEmail.Text, textBoxPassword.Text, comboBoxType.Text, textBoxCreatedOn.Text), connection);
            }
            else
            {
                MessageBox.Show("Please fill all account details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
