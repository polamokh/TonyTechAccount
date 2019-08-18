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

namespace TonyTechAccount.Forms
{
    public partial class Print : Form
    {
        private Form calledByForm;
        private SqlConnection connection;
        public Print(Form form, SqlConnection conn)
        {
            InitializeComponent();
            calledByForm = form;
            connection = conn;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            connection.Dispose();
            calledByForm.Visible = true;
            this.Close();
        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            int accountsCount = dataGridView.SelectedRows.Count;
            if (accountsCount <= 5)
            {
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select at maximum 5 accounts to print.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 220;
            int y = 10;

            int accountsCount = dataGridView.SelectedRows.Count;
            for (int i = 0; i < accountsCount; i++)
            {
                string email = dataGridView.SelectedRows[i].Cells["Email"].Value.ToString();
                string type = dataGridView.SelectedRows[i].Cells["Acc_Type"].Value.ToString();

                List<string> data = API.ExtractDataToPrint(API.GetData(connection, "Email", email));

                int repeat;
                if (radioButtonMultiAccount.Checked)
                    repeat = 1;
                else
                    repeat = 5;

                for (int j = 0; j < repeat; j++)
                {
                    Image image;
                    if (type == "Gmail")
                        image = Properties.Resources.gmail_logo;
                    else
                        image = Properties.Resources.icloud_logo;

                    e.Graphics.DrawImage(image, x, y, image.Width - 50, image.Height - 8);
                    y += image.Height; int yTmp = y; int xTmp = x; //Back to this point again when fill data.

                    x = 240;
                    y += 30;
                    e.Graphics.DrawImage(Properties.Resources.tony_tech_logo, x, y, image.Width - 50, image.Height - 10);

                    x = xTmp; y = yTmp;
                    API.CreatePrintLables(x, y, e);

                    y = yTmp;
                    x += 80;
                    API.FillPrintData(x, y, data, e);

                    x = 220;
                    y += 150;
                }
            }
        }

        private void Print_Load(object sender, EventArgs e)
        {
            connection.Open();
            dataGridView.DataSource = API.GetData(connection).Tables[0];
            radioButtonMultiAccount.Checked = true;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private void radioButtonMultiAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMultiAccount.Checked)
                dataGridView.MultiSelect = true;
            else
                dataGridView.MultiSelect = false;

            if (dataGridView.Rows.Count > 0)
                dataGridView.Rows[0].Selected = true;
        }
    }
}
