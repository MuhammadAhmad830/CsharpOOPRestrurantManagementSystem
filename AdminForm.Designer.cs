namespace RestaurantManagementSystem.UI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.reports1 = new RestaurantManagementSystem.UI.Reports();
            this.updateForm1 = new RestaurantManagementSystem.UI.UpdateForm();
            this.viewCashier1 = new RestaurantManagementSystem.UI.ViewCashier();
            this.add_Cashier1 = new RestaurantManagementSystem.Add_Cashier();
            this.inventory1 = new RestaurantManagementSystem.UI.inventory();
            this.placeOrder1 = new RestaurantManagementSystem.UI.PlaceOrder();
            this.addEditItemControl1 = new RestaurantManagementSystem.UI.AddItem();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManageCashiers = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.reports1);
            this.panelMain.Controls.Add(this.updateForm1);
            this.panelMain.Controls.Add(this.viewCashier1);
            this.panelMain.Controls.Add(this.add_Cashier1);
            this.panelMain.Controls.Add(this.inventory1);
            this.panelMain.Controls.Add(this.placeOrder1);
            this.panelMain.Controls.Add(this.addEditItemControl1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(225, 72);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1699, 978);
            this.panelMain.TabIndex = 8;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // reports1
            // 
            this.reports1.Location = new System.Drawing.Point(0, 0);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(1721, 1046);
            this.reports1.TabIndex = 6;            // 
            // updateForm1
            // 
            this.updateForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateForm1.Location = new System.Drawing.Point(0, 0);
            this.updateForm1.Name = "updateForm1";
            this.updateForm1.Size = new System.Drawing.Size(1699, 978);
            this.updateForm1.TabIndex = 5;
            // 
            // viewCashier1
            // 
            this.viewCashier1.Location = new System.Drawing.Point(0, 0);
            this.viewCashier1.Name = "viewCashier1";
            this.viewCashier1.Size = new System.Drawing.Size(1721, 1046);
            this.viewCashier1.TabIndex = 4;
            // 
            // add_Cashier1
            // 
            this.add_Cashier1.Location = new System.Drawing.Point(0, 0);
            this.add_Cashier1.Name = "add_Cashier1";
            this.add_Cashier1.Size = new System.Drawing.Size(1721, 1046);
            this.add_Cashier1.TabIndex = 3;
            // 
            // inventory1
            // 
            this.inventory1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventory1.Location = new System.Drawing.Point(0, 0);
            this.inventory1.Name = "inventory1";
            this.inventory1.Size = new System.Drawing.Size(1721, 1046);
            this.inventory1.TabIndex = 2;
            // 
            // placeOrder1
            // 
            this.placeOrder1.BackColor = System.Drawing.Color.White;
            this.placeOrder1.Location = new System.Drawing.Point(0, 0);
            this.placeOrder1.Name = "placeOrder1";
            this.placeOrder1.Size = new System.Drawing.Size(1721, 1046);
            this.placeOrder1.TabIndex = 1;
            this.placeOrder1.Load += new System.EventHandler(this.placeOrder1_Load);
            // 
            // addEditItemControl1
            // 
            this.addEditItemControl1.Location = new System.Drawing.Point(0, 0);
            this.addEditItemControl1.Name = "addEditItemControl1";
            this.addEditItemControl1.Size = new System.Drawing.Size(1721, 1046);
            this.addEditItemControl1.TabIndex = 0;
            this.addEditItemControl1.Load += new System.EventHandler(this.addEditItemControl1_Load);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(0, 234);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnAddItem.Size = new System.Drawing.Size(225, 63);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "   Add Item";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelLeft.Controls.Add(this.button3);
            this.panelLeft.Controls.Add(this.button2);
            this.panelLeft.Controls.Add(this.button1);
            this.panelLeft.Controls.Add(this.btnLogout);
            this.panelLeft.Controls.Add(this.btnManageCashiers);
            this.panelLeft.Controls.Add(this.btnViewReports);
            this.panelLeft.Controls.Add(this.btnAddItem);
            this.panelLeft.Controls.Add(this.btnOrder);
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 72);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(225, 978);
            this.panelLeft.TabIndex = 7;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 619);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.button3.Size = new System.Drawing.Size(225, 77);
            this.button3.TabIndex = 9;
            this.button3.Text = " Update Cashiers";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 545);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.button2.Size = new System.Drawing.Size(225, 77);
            this.button2.TabIndex = 8;
            this.button2.Text = "   View Cashiers";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 352);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.button1.Size = new System.Drawing.Size(225, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "   Inventory";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 981);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnLogout.Size = new System.Drawing.Size(225, 63);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManageCashiers
            // 
            this.btnManageCashiers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnManageCashiers.FlatAppearance.BorderSize = 0;
            this.btnManageCashiers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnManageCashiers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCashiers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnManageCashiers.ForeColor = System.Drawing.Color.White;
            this.btnManageCashiers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCashiers.Location = new System.Drawing.Point(2, 485);
            this.btnManageCashiers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageCashiers.Name = "btnManageCashiers";
            this.btnManageCashiers.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnManageCashiers.Size = new System.Drawing.Size(225, 63);
            this.btnManageCashiers.TabIndex = 5;
            this.btnManageCashiers.Text = "   Cashiers";
            this.btnManageCashiers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCashiers.UseVisualStyleBackColor = false;
            this.btnManageCashiers.Click += new System.EventHandler(this.btnManageCashiers_Click);
            // 
            // btnViewReports
            // 
            this.btnViewReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnViewReports.FlatAppearance.BorderSize = 0;
            this.btnViewReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReports.Location = new System.Drawing.Point(0, 412);
            this.btnViewReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnViewReports.Size = new System.Drawing.Size(225, 63);
            this.btnViewReports.TabIndex = 4;
            this.btnViewReports.Text = "   View Reports";
            this.btnViewReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(-3, 292);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.btnOrder.Size = new System.Drawing.Size(225, 63);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "   Place Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(222, 210);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(686, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(429, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Restaurant Management System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1924, 72);
            this.panelTop.TabIndex = 6;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 72);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(686, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Management System";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManageCashiers;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelTop;
        private AddItem addEditItemControl1;
        private PlaceOrder placeOrder1;
        private inventory inventory1;
        private System.Windows.Forms.Button button1;
        private Add_Cashier add_Cashier1;
        private ViewCashier viewCashier1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private UpdateForm updateForm1;
        private Reports reports1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}


