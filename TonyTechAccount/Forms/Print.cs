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
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 0;
            int y = 20;

            List<string> data = API.ExtractDataToPrint(API.GetData(connection, "Email", "polamokh@gmail.com"));

            Image image = Properties.Resources.gmail_logo;
            e.Graphics.DrawImage(image, x, y, image.Width - 50, image.Height - 8);
            y = 20 + image.Height;

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
            
            y = 20 + image.Height;
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

            x = 0;
            e.Graphics.DrawString("PLEASE KEEP THIS PAPER IN A SAFE PLACE.", new Font("Tahoma", 12, FontStyle.Bold),
                Brushes.Black, new Point(x, y));
            y += 70;
        }
    }
}
