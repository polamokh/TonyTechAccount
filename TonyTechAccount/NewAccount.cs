using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonyTechAccount
{
    public partial class NewAccount : Form
    {
        public static Form mainForm;
        public NewAccount(Form form)
        {
            InitializeComponent();
            mainForm = form;
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
    }
}
