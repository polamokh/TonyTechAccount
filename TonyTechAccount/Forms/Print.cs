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
            this.Close();
            calledByForm.Visible = true;
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
            int x = 10;
            int y = 10;

            int accountsCount = dataGridView.SelectedRows.Count;
            for (int i = 0; i < accountsCount; i++)
            {
                string email = dataGridView.SelectedRows[i].Cells["Email"].Value.ToString();
                string type = dataGridView.SelectedRows[i].Cells["Acc_Type"].Value.ToString();

                List<string> data = API.ExtractDataToPrint(API.GetData(connection, "Email", email));

                Image image;
                if (type == "Gmail")
                    image = Properties.Resources.gmail_logo;
                else
                    image = Properties.Resources.icloud_logo;

                e.Graphics.DrawImage(image, x, y, image.Width - 50, image.Height - 8);
                y += image.Height; int yTmp = y; //Back to this point again when fill data.

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

                y = yTmp;
                x += 80;

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
                y += 30;

                x = 10;
                e.Graphics.DrawString("PLEASE KEEP THIS PAPER IN A SAFE PLACE.", new Font("Tahoma", 12, FontStyle.Bold),
                    Brushes.Black, new Point(x, y));
                y += 50;
            }
        }

        private void Print_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = API.GetData(connection, "", "").Tables[0];
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DialogResult result = printDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }
    }
}
