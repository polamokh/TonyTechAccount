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
        private static Form calledByForm;
        private static SqlConnection connection;

        public NewAccount(Form form, SqlConnection conn)
        {
            InitializeComponent();
            calledByForm = form;
            connection = conn;
        }

        private void NewAccount_Load(object sender, EventArgs e)
        {
            textBoxCreatedOn.Text = DateTime.Now.Date.ToShortDateString();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            TextBox[] args = {textBoxFName, textBoxLName, textBoxMobile, textBoxBDDay, textBoxBDMonth,
                textBoxBDYear, textBoxEmail, textBoxPassword};
            API.ClearTextboxes(args);
            calledByForm.Visible = true;
            calledByForm.Controls[0].Controls[0].Controls[0].Controls["textBoxSearchText"].Focus();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            TextBox[] args = {textBoxFName, textBoxLName, textBoxBDDay, textBoxBDMonth,
                textBoxBDYear, textBoxEmail, textBoxPassword};
            if (API.CheckTextboxes(args))
            {
                if (textBoxEmail.Text.Contains("@") && textBoxEmail.Text.ToLower().Contains(".com"))
                {
                    if (API.NewAccount(new Account(textBoxFName.Text, textBoxLName.Text, textBoxMobile.Text,
                        int.Parse(textBoxBDDay.Text), int.Parse(textBoxBDMonth.Text), int.Parse(textBoxBDYear.Text),
                        textBoxEmail.Text, textBoxPassword.Text, comboBoxType.Text, textBoxCreatedOn.Text), connection))
                    {
                        API.ClearTextboxes(args);
                        textBoxMobile.Text = "";
                    }
                }
                else
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please fill all account details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (!(textBoxEmail.Text.Contains("@") && textBoxEmail.Text.ToLower().Contains(".com")))
                textBoxEmail.ForeColor = Color.Red;
            else
                textBoxEmail.ForeColor = SystemColors.WindowText;
        }
    }
}
