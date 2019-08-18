namespace TonyTechAccount
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxSearchType = new System.Windows.Forms.ComboBox();
            this.textBoxSearchText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelFooter = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelHeader.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelHeader, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelFooter, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.52941F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(659, 462);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelHeader
            // 
            this.tableLayoutPanelHeader.ColumnCount = 1;
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHeader.Controls.Add(this.groupBox, 0, 0);
            this.tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHeader.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            this.tableLayoutPanelHeader.RowCount = 1;
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHeader.Size = new System.Drawing.Size(653, 61);
            this.tableLayoutPanelHeader.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.comboBoxSearchType);
            this.groupBox.Controls.Add(this.textBoxSearchText);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(647, 55);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Search";
            // 
            // comboBoxSearchType
            // 
            this.comboBoxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchType.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchType.FormattingEnabled = true;
            this.comboBoxSearchType.Items.AddRange(new object[] {
            "Type",
            "First Name",
            "Last Name",
            "Mobile Number",
            "Email",
            "Created On"});
            this.comboBoxSearchType.Location = new System.Drawing.Point(396, 27);
            this.comboBoxSearchType.Name = "comboBoxSearchType";
            this.comboBoxSearchType.Size = new System.Drawing.Size(245, 24);
            this.comboBoxSearchType.TabIndex = 3;
            this.comboBoxSearchType.TextChanged += new System.EventHandler(this.comboBoxSearchType_TextChanged);
            // 
            // textBoxSearchText
            // 
            this.textBoxSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchText.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchText.Location = new System.Drawing.Point(6, 28);
            this.textBoxSearchText.Name = "textBoxSearchText";
            this.textBoxSearchText.Size = new System.Drawing.Size(384, 23);
            this.textBoxSearchText.TabIndex = 2;
            this.textBoxSearchText.TextChanged += new System.EventHandler(this.textBoxSearchText_TextChanged);
            this.textBoxSearchText.Enter += new System.EventHandler(this.textBoxSearchText_Enter);
            // 
            // tableLayoutPanelFooter
            // 
            this.tableLayoutPanelFooter.ColumnCount = 3;
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanelFooter.Controls.Add(this.buttonDelete, 0, 0);
            this.tableLayoutPanelFooter.Controls.Add(this.buttonNew, 0, 0);
            this.tableLayoutPanelFooter.Controls.Add(this.buttonClose, 2, 0);
            this.tableLayoutPanelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFooter.Location = new System.Drawing.Point(3, 409);
            this.tableLayoutPanelFooter.Name = "tableLayoutPanelFooter";
            this.tableLayoutPanelFooter.RowCount = 1;
            this.tableLayoutPanelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFooter.Size = new System.Drawing.Size(653, 50);
            this.tableLayoutPanelFooter.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::TonyTechAccount.Properties.Resources.remove_symbol;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.Location = new System.Drawing.Point(240, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(231, 44);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Image = global::TonyTechAccount.Properties.Resources.plus_black_symbol;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.Location = new System.Drawing.Point(3, 3);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(231, 44);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Image = global::TonyTechAccount.Properties.Resources.sign_out_option;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClose.Location = new System.Drawing.Point(477, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(173, 44);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(3, 70);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(653, 333);
            this.dataGridView.TabIndex = 4;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 462);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelHeader.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tableLayoutPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFooter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TextBox textBoxSearchText;
        private System.Windows.Forms.ComboBox comboBoxSearchType;
        private System.Windows.Forms.Button buttonClose;
    }
}