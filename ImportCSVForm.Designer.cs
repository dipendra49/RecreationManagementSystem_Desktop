
namespace RecreationManagementSystem
{
    partial class ImportCSVForm
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
            this.ticketRatePanel = new System.Windows.Forms.Panel();
            this.importCsvDataGridView = new System.Windows.Forms.DataGridView();
            this.labelImportToCSV = new System.Windows.Forms.Label();
            this.importControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.importControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.importControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.fileTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.openCSVFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ticketRatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importCsvDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketRatePanel
            // 
            this.ticketRatePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.ticketRatePanel.Controls.Add(this.openCSVFileBtn);
            this.ticketRatePanel.Controls.Add(this.fileTextBox);
            this.ticketRatePanel.Controls.Add(this.importCsvDataGridView);
            this.ticketRatePanel.Controls.Add(this.labelImportToCSV);
            this.ticketRatePanel.Location = new System.Drawing.Point(-1, 36);
            this.ticketRatePanel.Name = "ticketRatePanel";
            this.ticketRatePanel.Size = new System.Drawing.Size(1366, 645);
            this.ticketRatePanel.TabIndex = 20;
            // 
            // importCsvDataGridView
            // 
            this.importCsvDataGridView.AllowUserToAddRows = false;
            this.importCsvDataGridView.AllowUserToDeleteRows = false;
            this.importCsvDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.importCsvDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importCsvDataGridView.Location = new System.Drawing.Point(3, 144);
            this.importCsvDataGridView.Name = "importCsvDataGridView";
            this.importCsvDataGridView.ReadOnly = true;
            this.importCsvDataGridView.RowHeadersWidth = 51;
            this.importCsvDataGridView.RowTemplate.Height = 24;
            this.importCsvDataGridView.Size = new System.Drawing.Size(1360, 495);
            this.importCsvDataGridView.TabIndex = 30;
            // 
            // labelImportToCSV
            // 
            this.labelImportToCSV.AutoSize = true;
            this.labelImportToCSV.BackColor = System.Drawing.Color.DarkOrange;
            this.labelImportToCSV.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImportToCSV.ForeColor = System.Drawing.Color.White;
            this.labelImportToCSV.Location = new System.Drawing.Point(451, 13);
            this.labelImportToCSV.Name = "labelImportToCSV";
            this.labelImportToCSV.Size = new System.Drawing.Size(278, 45);
            this.labelImportToCSV.TabIndex = 17;
            this.labelImportToCSV.Text = "IMPORT CSV FILE";
            // 
            // importControlBox3
            // 
            this.importControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.importControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.importControlBox3.HoverState.Parent = this.importControlBox3;
            this.importControlBox3.IconColor = System.Drawing.Color.DimGray;
            this.importControlBox3.Location = new System.Drawing.Point(1234, 3);
            this.importControlBox3.Name = "importControlBox3";
            this.importControlBox3.ShadowDecoration.Parent = this.importControlBox3;
            this.importControlBox3.Size = new System.Drawing.Size(32, 29);
            this.importControlBox3.TabIndex = 33;
            // 
            // importControlBox1
            // 
            this.importControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.importControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.importControlBox1.ForeColor = System.Drawing.Color.Black;
            this.importControlBox1.HoverState.Parent = this.importControlBox1;
            this.importControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.importControlBox1.Location = new System.Drawing.Point(1316, 3);
            this.importControlBox1.Name = "importControlBox1";
            this.importControlBox1.ShadowDecoration.Parent = this.importControlBox1;
            this.importControlBox1.Size = new System.Drawing.Size(32, 29);
            this.importControlBox1.TabIndex = 32;
            // 
            // importControlBox2
            // 
            this.importControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.importControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.importControlBox2.HoverState.Parent = this.importControlBox2;
            this.importControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.importControlBox2.Location = new System.Drawing.Point(1274, 3);
            this.importControlBox2.Name = "importControlBox2";
            this.importControlBox2.ShadowDecoration.Parent = this.importControlBox2;
            this.importControlBox2.Size = new System.Drawing.Size(32, 29);
            this.importControlBox2.TabIndex = 31;
            // 
            // fileTextBox
            // 
            this.fileTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileTextBox.DefaultText = "";
            this.fileTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fileTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fileTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileTextBox.DisabledState.Parent = this.fileTextBox;
            this.fileTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fileTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileTextBox.FocusedState.Parent = this.fileTextBox;
            this.fileTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fileTextBox.HoverState.Parent = this.fileTextBox;
            this.fileTextBox.Location = new System.Drawing.Point(336, 83);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.PasswordChar = '\0';
            this.fileTextBox.PlaceholderText = "";
            this.fileTextBox.SelectedText = "";
            this.fileTextBox.ShadowDecoration.Parent = this.fileTextBox;
            this.fileTextBox.Size = new System.Drawing.Size(370, 31);
            this.fileTextBox.TabIndex = 31;
            // 
            // openCSVFileBtn
            // 
            this.openCSVFileBtn.Animated = true;
            this.openCSVFileBtn.BorderRadius = 8;
            this.openCSVFileBtn.CheckedState.Parent = this.openCSVFileBtn;
            this.openCSVFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCSVFileBtn.CustomImages.Parent = this.openCSVFileBtn;
            this.openCSVFileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openCSVFileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openCSVFileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openCSVFileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openCSVFileBtn.DisabledState.Parent = this.openCSVFileBtn;
            this.openCSVFileBtn.FillColor = System.Drawing.Color.White;
            this.openCSVFileBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCSVFileBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.openCSVFileBtn.HoverState.Parent = this.openCSVFileBtn;
            this.openCSVFileBtn.Location = new System.Drawing.Point(724, 75);
            this.openCSVFileBtn.Name = "openCSVFileBtn";
            this.openCSVFileBtn.ShadowDecoration.Parent = this.openCSVFileBtn;
            this.openCSVFileBtn.Size = new System.Drawing.Size(198, 45);
            this.openCSVFileBtn.TabIndex = 32;
            this.openCSVFileBtn.Text = "Open CSV File";
            this.openCSVFileBtn.Click += new System.EventHandler(this.openCSVFileBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImportCSVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 682);
            this.Controls.Add(this.importControlBox3);
            this.Controls.Add(this.ticketRatePanel);
            this.Controls.Add(this.importControlBox1);
            this.Controls.Add(this.importControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportCSVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportCSVForm";
            this.ticketRatePanel.ResumeLayout(false);
            this.ticketRatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importCsvDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ticketRatePanel;
        private System.Windows.Forms.DataGridView importCsvDataGridView;
        private System.Windows.Forms.Label labelImportToCSV;
        private Guna.UI2.WinForms.Guna2ControlBox importControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox importControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox importControlBox2;
        private Guna.UI2.WinForms.Guna2TextBox fileTextBox;
        private Guna.UI2.WinForms.Guna2Button openCSVFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}