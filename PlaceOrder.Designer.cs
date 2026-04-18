namespace RestaurantManagementSystem.UI
{
    partial class PlaceOrder
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonPlaceOrder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxItem = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.restaurantDataSet1 = new RestaurantManagementSystem.restaurantDataSet1();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new RestaurantManagementSystem.restaurantDataSet1TableAdapters.ItemsTableAdapter();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxtextBoxDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.restaurantDataSet3 = new RestaurantManagementSystem.restaurantDataSet3();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter1 = new RestaurantManagementSystem.restaurantDataSet3TableAdapters.ItemsTableAdapter();
            this.restaurantDataSet4 = new RestaurantManagementSystem.restaurantDataSet4();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter2 = new RestaurantManagementSystem.restaurantDataSet4TableAdapters.ItemsTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(323, 269);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(176, 40);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // comboBoxItem
            // 
            this.comboBoxItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxItem.FormattingEnabled = true;
            this.comboBoxItem.Location = new System.Drawing.Point(547, 268);
            this.comboBoxItem.Name = "comboBoxItem";
            this.comboBoxItem.Size = new System.Drawing.Size(200, 40);
            this.comboBoxItem.TabIndex = 2;
            this.comboBoxItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItem_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(1129, 261);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 47);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeight = 34;
            this.dataGridViewOrder.Location = new System.Drawing.Point(325, 330);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 29;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(964, 300);
            this.dataGridViewOrder.TabIndex = 5;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            // 
            // restaurantDataSet1
            // 
            this.restaurantDataSet1.DataSetName = "restaurantDataSet1";
            this.restaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(309, 663);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(200, 30);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "Total: Rs ";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(1139, 649);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(150, 40);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.buttonPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.buttonPlaceOrder.Location = new System.Drawing.Point(709, 883);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(200, 50);
            this.buttonPlaceOrder.TabIndex = 7;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = false;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(315, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 61);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(791, 283);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 26);
            this.numericUpDown1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(786, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quanity";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(444, 663);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(110, 26);
            this.textBoxTotal.TabIndex = 16;
            // 
            // textBoxtextBoxDiscount
            // 
            this.textBoxtextBoxDiscount.Location = new System.Drawing.Point(444, 713);
            this.textBoxtextBoxDiscount.Name = "textBoxtextBoxDiscount";
            this.textBoxtextBoxDiscount.Size = new System.Drawing.Size(110, 26);
            this.textBoxtextBoxDiscount.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(309, 713);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Disc: Rs";
            // 
            // restaurantDataSet3
            // 
            this.restaurantDataSet3.DataSetName = "restaurantDataSet3";
            this.restaurantDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.restaurantDataSet3;
            this.itemsBindingSource1.CurrentChanged += new System.EventHandler(this.itemsBindingSource1_CurrentChanged);
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // restaurantDataSet4
            // 
            this.restaurantDataSet4.DataSetName = "restaurantDataSet4";
            this.restaurantDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.restaurantDataSet4;
            // 
            // itemsTableAdapter2
            // 
            this.itemsTableAdapter2.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(914, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Discount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(929, 282);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(91, 26);
            this.numericUpDown2.TabIndex = 19;
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Location = new System.Drawing.Point(444, 768);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new System.Drawing.Size(110, 26);
            this.textBoxGrandTotal.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(250, 768);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "Grand Total: Rs ";
            // 
            // PlaceOrder
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxGrandTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.textBoxtextBoxDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxItem);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Name = "PlaceOrder";
            this.Size = new System.Drawing.Size(1721, 1046);
            this.Load += new System.EventHandler(this.PlaceOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private restaurantDataSet1 restaurantDataSet1;
        private restaurantDataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxtextBoxDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private restaurantDataSet3 restaurantDataSet3;
        private restaurantDataSet3TableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private restaurantDataSet4 restaurantDataSet4;
        private restaurantDataSet4TableAdapters.ItemsTableAdapter itemsTableAdapter2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox textBoxGrandTotal;
        private System.Windows.Forms.Label label7;
    }
}


