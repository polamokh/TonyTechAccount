namespace TonyTechAccount.Forms
{
    partial class Print
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAccounts = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonIndividualAccount = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiAccount = new System.Windows.Forms.RadioButton();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanelRight.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintPreview.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrintPreview.Image = global::TonyTechAccount.Properties.Resources.magnifying_glass;
            this.buttonPrintPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPrintPreview.Location = new System.Drawing.Point(3, 3);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(84, 169);
            this.buttonPrintPreview.TabIndex = 1;
            this.buttonPrintPreview.Text = "Print Preview";
            this.buttonPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Image = global::TonyTechAccount.Properties.Resources.printing_tool;
            this.buttonPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPrint.Location = new System.Drawing.Point(3, 178);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(84, 125);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = global::TonyTechAccount.Properties.Resources.sign_out_option;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.Location = new System.Drawing.Point(3, 309);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(84, 127);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxAccounts, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelRight, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelTop, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(639, 475);
            this.tableLayoutPanelMain.TabIndex = 4;
            // 
            // groupBoxAccounts
            // 
            this.groupBoxAccounts.Controls.Add(this.dataGridView);
            this.groupBoxAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAccounts.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAccounts.Location = new System.Drawing.Point(3, 33);
            this.groupBoxAccounts.Name = "groupBoxAccounts";
            this.groupBoxAccounts.Size = new System.Drawing.Size(537, 439);
            this.groupBoxAccounts.TabIndex = 1;
            this.groupBoxAccounts.TabStop = false;
            this.groupBoxAccounts.Text = "Select Accounts to Print";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(531, 417);
            this.dataGridView.TabIndex = 6;
            // 
            // tableLayoutPanelRight
            // 
            this.tableLayoutPanelRight.ColumnCount = 1;
            this.tableLayoutPanelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRight.Controls.Add(this.buttonPrintPreview, 0, 0);
            this.tableLayoutPanelRight.Controls.Add(this.buttonClose, 0, 2);
            this.tableLayoutPanelRight.Controls.Add(this.buttonPrint, 0, 1);
            this.tableLayoutPanelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRight.Location = new System.Drawing.Point(546, 33);
            this.tableLayoutPanelRight.Name = "tableLayoutPanelRight";
            this.tableLayoutPanelRight.RowCount = 3;
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelRight.Size = new System.Drawing.Size(90, 439);
            this.tableLayoutPanelRight.TabIndex = 0;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTop.Controls.Add(this.radioButtonIndividualAccount, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.radioButtonMultiAccount, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(537, 24);
            this.tableLayoutPanelTop.TabIndex = 2;
            // 
            // radioButtonIndividualAccount
            // 
            this.radioButtonIndividualAccount.AutoSize = true;
            this.radioButtonIndividualAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonIndividualAccount.Location = new System.Drawing.Point(271, 3);
            this.radioButtonIndividualAccount.Name = "radioButtonIndividualAccount";
            this.radioButtonIndividualAccount.Size = new System.Drawing.Size(263, 18);
            this.radioButtonIndividualAccount.TabIndex = 1;
            this.radioButtonIndividualAccount.Text = "Individual Account (5 Times)";
            this.radioButtonIndividualAccount.UseVisualStyleBackColor = true;
            // 
            // radioButtonMultiAccount
            // 
            this.radioButtonMultiAccount.AutoSize = true;
            this.radioButtonMultiAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonMultiAccount.Location = new System.Drawing.Point(3, 3);
            this.radioButtonMultiAccount.Name = "radioButtonMultiAccount";
            this.radioButtonMultiAccount.Size = new System.Drawing.Size(262, 18);
            this.radioButtonMultiAccount.TabIndex = 0;
            this.radioButtonMultiAccount.Text = "Multi Account";
            this.radioButtonMultiAccount.UseVisualStyleBackColor = true;
            this.radioButtonMultiAccount.CheckedChanged += new System.EventHandler(this.radioButtonMultiAccount_CheckedChanged);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 475);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanelRight.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPrintPreview;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRight;
        private System.Windows.Forms.GroupBox groupBoxAccounts;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.RadioButton radioButtonIndividualAccount;
        private System.Windows.Forms.RadioButton radioButtonMultiAccount;
    }
}