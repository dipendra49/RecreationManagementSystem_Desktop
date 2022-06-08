
namespace RecreationManagementSystem
{
    partial class TicketRate
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
            this.components = new System.ComponentModel.Container();
            this.ticketRatePanel = new System.Windows.Forms.Panel();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketClearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ticketUpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ticketAddBtn = new Guna.UI2.WinForms.Guna2Button();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.labelTicketPrice = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelCustomerCategory = new System.Windows.Forms.Label();
            this.labelManageTicketPrice = new System.Windows.Forms.Label();
            this.manageEmployeeBtn = new System.Windows.Forms.Button();
            this.manageDiscountBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.ticketControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ticketControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ticketControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ticketRatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketRatePanel
            // 
            this.ticketRatePanel.BackColor = System.Drawing.Color.DarkOrange;
            this.ticketRatePanel.Controls.Add(this.ticketDataGridView);
            this.ticketRatePanel.Controls.Add(this.ticketClearBtn);
            this.ticketRatePanel.Controls.Add(this.ticketUpdateBtn);
            this.ticketRatePanel.Controls.Add(this.ticketAddBtn);
            this.ticketRatePanel.Controls.Add(this.priceTextBox);
            this.ticketRatePanel.Controls.Add(this.hourComboBox);
            this.ticketRatePanel.Controls.Add(this.categoryComboBox);
            this.ticketRatePanel.Controls.Add(this.labelTicketPrice);
            this.ticketRatePanel.Controls.Add(this.labelHour);
            this.ticketRatePanel.Controls.Add(this.labelCustomerCategory);
            this.ticketRatePanel.Controls.Add(this.labelManageTicketPrice);
            this.ticketRatePanel.Location = new System.Drawing.Point(277, 46);
            this.ticketRatePanel.Name = "ticketRatePanel";
            this.ticketRatePanel.Size = new System.Drawing.Size(1009, 653);
            this.ticketRatePanel.TabIndex = 0;
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AllowUserToAddRows = false;
            this.ticketDataGridView.AllowUserToDeleteRows = false;
            this.ticketDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Location = new System.Drawing.Point(437, 114);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.ReadOnly = true;
            this.ticketDataGridView.RowHeadersWidth = 51;
            this.ticketDataGridView.RowTemplate.Height = 24;
            this.ticketDataGridView.Size = new System.Drawing.Size(569, 525);
            this.ticketDataGridView.TabIndex = 30;
            this.ticketDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ticketDataGridView_CellClick);
            // 
            // ticketClearBtn
            // 
            this.ticketClearBtn.Animated = true;
            this.ticketClearBtn.BorderRadius = 8;
            this.ticketClearBtn.CheckedState.Parent = this.ticketClearBtn;
            this.ticketClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketClearBtn.CustomImages.Parent = this.ticketClearBtn;
            this.ticketClearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ticketClearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ticketClearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ticketClearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ticketClearBtn.DisabledState.Parent = this.ticketClearBtn;
            this.ticketClearBtn.FillColor = System.Drawing.Color.White;
            this.ticketClearBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ticketClearBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ticketClearBtn.HoverState.Parent = this.ticketClearBtn;
            this.ticketClearBtn.Location = new System.Drawing.Point(284, 282);
            this.ticketClearBtn.Name = "ticketClearBtn";
            this.ticketClearBtn.ShadowDecoration.Parent = this.ticketClearBtn;
            this.ticketClearBtn.Size = new System.Drawing.Size(106, 45);
            this.ticketClearBtn.TabIndex = 29;
            this.ticketClearBtn.Text = "CLEAR";
            this.ticketClearBtn.Click += new System.EventHandler(this.ticketClearBtn_Click);
            // 
            // ticketUpdateBtn
            // 
            this.ticketUpdateBtn.Animated = true;
            this.ticketUpdateBtn.BorderRadius = 8;
            this.ticketUpdateBtn.CheckedState.Parent = this.ticketUpdateBtn;
            this.ticketUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketUpdateBtn.CustomImages.Parent = this.ticketUpdateBtn;
            this.ticketUpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ticketUpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ticketUpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ticketUpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ticketUpdateBtn.DisabledState.Parent = this.ticketUpdateBtn;
            this.ticketUpdateBtn.FillColor = System.Drawing.Color.White;
            this.ticketUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.ticketUpdateBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ticketUpdateBtn.HoverState.Parent = this.ticketUpdateBtn;
            this.ticketUpdateBtn.Location = new System.Drawing.Point(148, 282);
            this.ticketUpdateBtn.Name = "ticketUpdateBtn";
            this.ticketUpdateBtn.ShadowDecoration.Parent = this.ticketUpdateBtn;
            this.ticketUpdateBtn.Size = new System.Drawing.Size(116, 45);
            this.ticketUpdateBtn.TabIndex = 27;
            this.ticketUpdateBtn.Text = "UPDATE";
            this.ticketUpdateBtn.Click += new System.EventHandler(this.ticketUpdateBtn_Click);
            // 
            // ticketAddBtn
            // 
            this.ticketAddBtn.Animated = true;
            this.ticketAddBtn.BorderRadius = 8;
            this.ticketAddBtn.CheckedState.Parent = this.ticketAddBtn;
            this.ticketAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketAddBtn.CustomImages.Parent = this.ticketAddBtn;
            this.ticketAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ticketAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ticketAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ticketAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ticketAddBtn.DisabledState.Parent = this.ticketAddBtn;
            this.ticketAddBtn.FillColor = System.Drawing.Color.White;
            this.ticketAddBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketAddBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.ticketAddBtn.HoverState.Parent = this.ticketAddBtn;
            this.ticketAddBtn.Location = new System.Drawing.Point(45, 282);
            this.ticketAddBtn.Name = "ticketAddBtn";
            this.ticketAddBtn.ShadowDecoration.Parent = this.ticketAddBtn;
            this.ticketAddBtn.Size = new System.Drawing.Size(93, 45);
            this.ticketAddBtn.TabIndex = 26;
            this.ticketAddBtn.Text = "ADD";
            this.ticketAddBtn.Click += new System.EventHandler(this.ticketAddBtn_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.Parent = this.priceTextBox;
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.FocusedState.Parent = this.priceTextBox;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.HoverState.Parent = this.priceTextBox;
            this.priceTextBox.Location = new System.Drawing.Point(203, 216);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.ShadowDecoration.Parent = this.priceTextBox;
            this.priceTextBox.Size = new System.Drawing.Size(187, 27);
            this.priceTextBox.TabIndex = 25;
            // 
            // hourComboBox
            // 
            this.hourComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Items.AddRange(new object[] {
            "----SELECT DURATION----",
            "1Hr",
            "2Hrs",
            "3Hrs",
            "4Hrs",
            "Whole Day"});
            this.hourComboBox.Location = new System.Drawing.Point(203, 126);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(187, 24);
            this.hourComboBox.TabIndex = 24;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "----SELECT TYPE----",
            "CHILD",
            "ADULT"});
            this.categoryComboBox.Location = new System.Drawing.Point(203, 168);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(187, 24);
            this.categoryComboBox.TabIndex = 23;
            // 
            // labelTicketPrice
            // 
            this.labelTicketPrice.AutoSize = true;
            this.labelTicketPrice.BackColor = System.Drawing.Color.DarkOrange;
            this.labelTicketPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketPrice.ForeColor = System.Drawing.Color.White;
            this.labelTicketPrice.Location = new System.Drawing.Point(39, 215);
            this.labelTicketPrice.Name = "labelTicketPrice";
            this.labelTicketPrice.Size = new System.Drawing.Size(155, 28);
            this.labelTicketPrice.TabIndex = 22;
            this.labelTicketPrice.Text = "Ticket Price(Rs.)";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.DarkOrange;
            this.labelHour.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.White;
            this.labelHour.Location = new System.Drawing.Point(60, 122);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(94, 28);
            this.labelHour.TabIndex = 21;
            this.labelHour.Text = "Duration";
            // 
            // labelCustomerCategory
            // 
            this.labelCustomerCategory.AutoSize = true;
            this.labelCustomerCategory.BackColor = System.Drawing.Color.DarkOrange;
            this.labelCustomerCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerCategory.ForeColor = System.Drawing.Color.White;
            this.labelCustomerCategory.Location = new System.Drawing.Point(40, 164);
            this.labelCustomerCategory.Name = "labelCustomerCategory";
            this.labelCustomerCategory.Size = new System.Drawing.Size(146, 28);
            this.labelCustomerCategory.TabIndex = 20;
            this.labelCustomerCategory.Text = "Customer Type";
            // 
            // labelManageTicketPrice
            // 
            this.labelManageTicketPrice.AutoSize = true;
            this.labelManageTicketPrice.BackColor = System.Drawing.Color.DarkOrange;
            this.labelManageTicketPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManageTicketPrice.ForeColor = System.Drawing.Color.White;
            this.labelManageTicketPrice.Location = new System.Drawing.Point(387, 9);
            this.labelManageTicketPrice.Name = "labelManageTicketPrice";
            this.labelManageTicketPrice.Size = new System.Drawing.Size(358, 45);
            this.labelManageTicketPrice.TabIndex = 17;
            this.labelManageTicketPrice.Text = "MANAGE TICKET RATE";
            // 
            // manageEmployeeBtn
            // 
            this.manageEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageEmployeeBtn.FlatAppearance.BorderSize = 0;
            this.manageEmployeeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manageEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageEmployeeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.manageEmployeeBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.manageEmployeeBtn.Location = new System.Drawing.Point(30, 120);
            this.manageEmployeeBtn.Name = "manageEmployeeBtn";
            this.manageEmployeeBtn.Size = new System.Drawing.Size(217, 37);
            this.manageEmployeeBtn.TabIndex = 1;
            this.manageEmployeeBtn.Text = "Manage Employee";
            this.manageEmployeeBtn.UseVisualStyleBackColor = true;
            this.manageEmployeeBtn.Click += new System.EventHandler(this.manageEmployeeBtn_Click);
            // 
            // manageDiscountBtn
            // 
            this.manageDiscountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageDiscountBtn.FlatAppearance.BorderSize = 0;
            this.manageDiscountBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manageDiscountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageDiscountBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.manageDiscountBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.manageDiscountBtn.Location = new System.Drawing.Point(16, 172);
            this.manageDiscountBtn.Name = "manageDiscountBtn";
            this.manageDiscountBtn.Size = new System.Drawing.Size(241, 42);
            this.manageDiscountBtn.TabIndex = 2;
            this.manageDiscountBtn.Text = "Manage Discount(%)";
            this.manageDiscountBtn.UseVisualStyleBackColor = true;
            this.manageDiscountBtn.Click += new System.EventHandler(this.manageDiscountBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.logoutBtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.logoutBtn.Location = new System.Drawing.Point(59, 610);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(121, 37);
            this.logoutBtn.TabIndex = 3;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // ticketControlBox3
            // 
            this.ticketControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ticketControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.ticketControlBox3.HoverState.Parent = this.ticketControlBox3;
            this.ticketControlBox3.IconColor = System.Drawing.Color.DimGray;
            this.ticketControlBox3.Location = new System.Drawing.Point(1159, 8);
            this.ticketControlBox3.Name = "ticketControlBox3";
            this.ticketControlBox3.ShadowDecoration.Parent = this.ticketControlBox3;
            this.ticketControlBox3.Size = new System.Drawing.Size(32, 29);
            this.ticketControlBox3.TabIndex = 15;
            // 
            // ticketControlBox1
            // 
            this.ticketControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.ticketControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.ticketControlBox1.ForeColor = System.Drawing.Color.Black;
            this.ticketControlBox1.HoverState.Parent = this.ticketControlBox1;
            this.ticketControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.ticketControlBox1.Location = new System.Drawing.Point(1241, 8);
            this.ticketControlBox1.Name = "ticketControlBox1";
            this.ticketControlBox1.ShadowDecoration.Parent = this.ticketControlBox1;
            this.ticketControlBox1.Size = new System.Drawing.Size(32, 29);
            this.ticketControlBox1.TabIndex = 14;
            // 
            // ticketControlBox2
            // 
            this.ticketControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ticketControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.ticketControlBox2.HoverState.Parent = this.ticketControlBox2;
            this.ticketControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.ticketControlBox2.Location = new System.Drawing.Point(1199, 8);
            this.ticketControlBox2.Name = "ticketControlBox2";
            this.ticketControlBox2.ShadowDecoration.Parent = this.ticketControlBox2;
            this.ticketControlBox2.Size = new System.Drawing.Size(32, 29);
            this.ticketControlBox2.TabIndex = 13;
            // 
            // TicketRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 700);
            this.Controls.Add(this.ticketControlBox3);
            this.Controls.Add(this.ticketControlBox1);
            this.Controls.Add(this.ticketControlBox2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.manageDiscountBtn);
            this.Controls.Add(this.manageEmployeeBtn);
            this.Controls.Add(this.ticketRatePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketRate";
            this.Load += new System.EventHandler(this.TicketRate_Load);
            this.ticketRatePanel.ResumeLayout(false);
            this.ticketRatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ticketRatePanel;
        private System.Windows.Forms.Label labelManageTicketPrice;
        private System.Windows.Forms.Button manageEmployeeBtn;
        private System.Windows.Forms.Button manageDiscountBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label labelTicketPrice;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelCustomerCategory;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox hourComboBox;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2Button ticketClearBtn;
        private Guna.UI2.WinForms.Guna2Button ticketUpdateBtn;
        private Guna.UI2.WinForms.Guna2Button ticketAddBtn;
        private Guna.UI2.WinForms.Guna2ControlBox ticketControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox ticketControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox ticketControlBox2;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}