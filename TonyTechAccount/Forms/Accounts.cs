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
    public partial class Accounts : Form
    {
        private static Form calledByForm;
        private static SqlConnection connection;

        public Accounts(Form form, SqlConnection conn)
        {
            InitializeComponent();
            calledByForm = form;
            connection = conn;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            calledByForm.Show();
            this.Close();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewAccount newAccountForm = new NewAccount(this, connection);
            newAccountForm.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows[0].Selected)
            {
                if (API.DeleteAccount(dataGridView.SelectedRows[0].Cells["Email"].Value.ToString(),
                    dataGridView.SelectedRows[0].Cells["Acc_Type"].Value.ToString(), connection))
                    textBoxSearchText.Focus();
            }
        }

        private void textBoxSearchText_Enter(object sender, EventArgs e)
        {
            dataGridView.DataSource = API.GetData(connection, comboBoxSearchType.Text, textBoxSearchText.Text).Tables[0];
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            comboBoxSearchType.SelectedIndex = 0;
        }

        private void textBoxSearchText_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = API.GetData(connection, comboBoxSearchType.Text, textBoxSearchText.Text).Tables[0];
        }

        private void comboBoxSearchType_TextChanged(object sender, EventArgs e)
        {
            textBoxSearchText.Text = "";
            textBoxSearchText.Focus();
        }
    }
}
