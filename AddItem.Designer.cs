using System.Windows.Forms;

using System;



namespace RestaurantManagementSystem.UI

{

    partial class AddItem

    {

        private System.ComponentModel.IContainer components = null;



        // Controls for the Add/Edit/Delete functionality

        private Button btnSave;

        private Button btnDelete;

        private Button btnClear;

        private TextBox textBoxItemName;

        private Label lblItemName;

        private Label lblPrice;

        private Label lblCategory;



        protected override void Dispose(bool disposing)

        {

            if (disposing && (components != null))

            {

                components.Dispose();

            }

            base.Dispose(disposing);

        }



        private void InitializeComponent()

        {

            this.btnSave = new System.Windows.Forms.Button();

            this.btnDelete = new System.Windows.Forms.Button();

            this.btnClear = new System.Windows.Forms.Button();

            this.textBoxItemName = new System.Windows.Forms.TextBox();

            this.lblItemName = new System.Windows.Forms.Label();

            this.lblPrice = new System.Windows.Forms.Label();

            this.lblCategory = new System.Windows.Forms.Label();

            this.panel1 = new System.Windows.Forms.Panel();

            this.label1 = new System.Windows.Forms.Label();

            this.textBox1 = new System.Windows.Forms.TextBox();

            this.textBox2 = new System.Windows.Forms.TextBox();

            this.textBoxStock = new System.Windows.Forms.TextBox();

            this.label2 = new System.Windows.Forms.Label();

            this.textBox4 = new System.Windows.Forms.TextBox();

            this.label3 = new System.Windows.Forms.Label();

            this.button1 = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();

            this.SuspendLayout();

            // 

            // btnSave

            // 

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));

            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

            this.btnSave.ForeColor = System.Drawing.Color.White;

            this.btnSave.Location = new System.Drawing.Point(508, 803);

            this.btnSave.Name = "btnSave";

            this.btnSave.Size = new System.Drawing.Size(150, 50);

            this.btnSave.TabIndex = 0;

            this.btnSave.Text = "Save Item";

            this.btnSave.UseVisualStyleBackColor = false;

            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);

            // 

            // btnDelete

            // 

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));

            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

            this.btnDelete.ForeColor = System.Drawing.Color.White;

            this.btnDelete.Location = new System.Drawing.Point(678, 803);

            this.btnDelete.Name = "btnDelete";

            this.btnDelete.Size = new System.Drawing.Size(150, 50);

            this.btnDelete.TabIndex = 1;

            this.btnDelete.Text = "Delete Item";

            this.btnDelete.UseVisualStyleBackColor = false;

            // 

            // btnClear

            // 

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));

            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

            this.btnClear.ForeColor = System.Drawing.Color.White;

            this.btnClear.Location = new System.Drawing.Point(1014, 803);

            this.btnClear.Name = "btnClear";

            this.btnClear.Size = new System.Drawing.Size(150, 50);

            this.btnClear.TabIndex = 2;

            this.btnClear.Text = "Clear Fields";

            this.btnClear.UseVisualStyleBackColor = false;

            // 

            // textBoxItemName

            // 

            this.textBoxItemName.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.textBoxItemName.Location = new System.Drawing.Point(684, 327);

            this.textBoxItemName.Name = "textBoxItemName";

            this.textBoxItemName.Size = new System.Drawing.Size(305, 39);

            this.textBoxItemName.TabIndex = 3;

            // 

            // lblItemName

            // 

            this.lblItemName.AutoSize = true;

            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblItemName.Location = new System.Drawing.Point(684, 292);

            this.lblItemName.Name = "lblItemName";

            this.lblItemName.Size = new System.Drawing.Size(133, 32);

            this.lblItemName.TabIndex = 6;

            this.lblItemName.Text = "Item Name";

            // 

            // lblPrice

            // 

            this.lblPrice.AutoSize = true;

            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblPrice.Location = new System.Drawing.Point(684, 393);

            this.lblPrice.Name = "lblPrice";

            this.lblPrice.Size = new System.Drawing.Size(65, 32);

            this.lblPrice.TabIndex = 7;

            this.lblPrice.Text = "Price";

            // 

            // lblCategory

            // 

            this.lblCategory.AutoSize = true;

            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.lblCategory.Location = new System.Drawing.Point(684, 477);

            this.lblCategory.Name = "lblCategory";

            this.lblCategory.Size = new System.Drawing.Size(110, 32);

            this.lblCategory.TabIndex = 8;

            this.lblCategory.Text = "Category";

            // 

            // panel1

            // 

            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));

            this.panel1.Controls.Add(this.label1);

            this.panel1.Location = new System.Drawing.Point(354, 150);

            this.panel1.Name = "panel1";

            this.panel1.Size = new System.Drawing.Size(964, 61);

            this.panel1.TabIndex = 10;

            // 

            // label1

            // 

            this.label1.AutoSize = true;

            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);

            this.label1.ForeColor = System.Drawing.Color.White;

            this.label1.Location = new System.Drawing.Point(405, 8);

            this.label1.Name = "label1";

            this.label1.Size = new System.Drawing.Size(154, 45);

            this.label1.TabIndex = 1;

            this.label1.Text = "Add Item";

            // 

            // textBox1

            // 

            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.textBox1.Location = new System.Drawing.Point(684, 428);

            this.textBox1.Name = "textBox1";

            this.textBox1.Size = new System.Drawing.Size(305, 39);

            this.textBox1.TabIndex = 4;

            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);

            // 

            // textBox2

            // 

            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.textBox2.Location = new System.Drawing.Point(684, 512);

            this.textBox2.Name = "textBox2";

            this.textBox2.Size = new System.Drawing.Size(305, 39);

            this.textBox2.TabIndex = 11;

            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);

            // 

            // textBoxStock

            // 

            this.textBoxStock.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.textBoxStock.Location = new System.Drawing.Point(678, 601);

            this.textBoxStock.Name = "textBoxStock";

            this.textBoxStock.Size = new System.Drawing.Size(311, 39);

            this.textBoxStock.TabIndex = 13;

            // 

            // label2

            // 

            this.label2.AutoSize = true;

            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.label2.Location = new System.Drawing.Point(678, 566);

            this.label2.Name = "label2";

            this.label2.Size = new System.Drawing.Size(71, 32);

            this.label2.TabIndex = 12;

            this.label2.Text = "Stock";

            // 

            // textBox4

            // 

            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.textBox4.Location = new System.Drawing.Point(672, 697);

            this.textBox4.Name = "textBox4";

            this.textBox4.Size = new System.Drawing.Size(317, 39);

            this.textBox4.TabIndex = 15;

            // 

            // label3

            // 

            this.label3.AutoSize = true;

            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);

            this.label3.Location = new System.Drawing.Point(672, 662);

            this.label3.Name = "label3";

            this.label3.Size = new System.Drawing.Size(78, 32);

            this.label3.TabIndex = 14;

            this.label3.Text = "Status";

            // 

            // button1

            // 

            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));

            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);

            this.button1.ForeColor = System.Drawing.Color.White;

            this.button1.Location = new System.Drawing.Point(847, 803);

            this.button1.Name = "button1";

            this.button1.Size = new System.Drawing.Size(150, 50);

            this.button1.TabIndex = 16;

            this.button1.Text = "Update";

            this.button1.UseVisualStyleBackColor = false;

            // 

            // AddItem

            // 

            this.Controls.Add(this.button1);

            this.Controls.Add(this.textBox4);

            this.Controls.Add(this.label3);

            this.Controls.Add(this.textBoxStock);

            this.Controls.Add(this.label2);

            this.Controls.Add(this.textBox2);

            this.Controls.Add(this.textBox1);

            this.Controls.Add(this.panel1);

            this.Controls.Add(this.lblCategory);

            this.Controls.Add(this.lblPrice);

            this.Controls.Add(this.lblItemName);

            this.Controls.Add(this.textBoxItemName);

            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.btnDelete);

            this.Controls.Add(this.btnSave);

            this.Name = "AddItem";

            this.Size = new System.Drawing.Size(1721, 1046);

            this.Load += new System.EventHandler(this.AddItem_Load_1);

            this.panel1.ResumeLayout(false);

            this.panel1.PerformLayout();

            this.ResumeLayout(false);

            this.PerformLayout();



        }



        private void AddItem_Load_1(object sender, EventArgs e)

        {



        }

        private void btnSave_Click_1(object sender, EventArgs e)

        {

            // This method is unnecessary and can be removed.

        }

        private void textBox2_TextChanged(object sender, EventArgs e)

        {

            // Your code for handling the TextChanged event

        }







        private Panel panel1;

        private Label label1;

        private TextBox textBox1;

        private TextBox textBox2;

        private TextBox textBoxStock;

        private Label label2;

        private TextBox textBox4;

        private Label label3;

        private Button button1;

    }

}