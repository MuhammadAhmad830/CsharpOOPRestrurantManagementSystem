namespace RestaurantManagementSystem.UI
{
    partial class inventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantDataSet6 = new RestaurantManagementSystem.restaurantDataSet6();
            this.restaurantDataSet2 = new RestaurantManagementSystem.restaurantDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.restaurantDataSet = new RestaurantManagementSystem.restaurantDataSet();
            this.itemsTableAdapter = new RestaurantManagementSystem.restaurantDataSetTableAdapters.ItemsTableAdapter();
            this.restaurantDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter1 = new RestaurantManagementSystem.restaurantDataSet2TableAdapters.ItemsTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.restaurantDataSet5 = new RestaurantManagementSystem.restaurantDataSet5();
            this.itemsTableAdapter2 = new RestaurantManagementSystem.restaurantDataSet5TableAdapters.ItemsTableAdapter();
            this.itemsTableAdapter3 = new RestaurantManagementSystem.restaurantDataSet6TableAdapters.ItemsTableAdapter();
            this.restaurantDataSet8 = new RestaurantManagementSystem.restaurantDataSet8();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter4 = new RestaurantManagementSystem.restaurantDataSet8TableAdapters.ItemsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(402, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(344, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 61);
            this.panel1.TabIndex = 11;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.originalPriceDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.remainingStockDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.itemsBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrder.Location = new System.Drawing.Point(344, 381);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 29;
            this.dataGridViewOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrder.Size = new System.Drawing.Size(964, 372);
            this.dataGridViewOrder.TabIndex = 12;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // originalPriceDataGridViewTextBoxColumn
            // 
            this.originalPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.HeaderText = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.originalPriceDataGridViewTextBoxColumn.Name = "originalPriceDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // remainingStockDataGridViewTextBoxColumn
            // 
            this.remainingStockDataGridViewTextBoxColumn.DataPropertyName = "RemainingStock";
            this.remainingStockDataGridViewTextBoxColumn.HeaderText = "RemainingStock";
            this.remainingStockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.remainingStockDataGridViewTextBoxColumn.Name = "remainingStockDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.restaurantDataSet6;
            // 
            // restaurantDataSet6
            // 
            this.restaurantDataSet6.DataSetName = "restaurantDataSet6";
            this.restaurantDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantDataSet2
            // 
            this.restaurantDataSet2.DataSetName = "restaurantDataSet2";
            this.restaurantDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(352, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1003, 756);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(459, 325);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(236, 30);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "restaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantDataSetBindingSource
            // 
            this.restaurantDataSetBindingSource.DataSource = this.restaurantDataSet;
            this.restaurantDataSetBindingSource.Position = 0;
            this.restaurantDataSetBindingSource.CurrentChanged += new System.EventHandler(this.restaurantDataSetBindingSource_CurrentChanged);
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // restaurantDataSet5
            // 
            this.restaurantDataSet5.DataSetName = "restaurantDataSet5";
            this.restaurantDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter2
            // 
            this.itemsTableAdapter2.ClearBeforeFill = true;
            // 
            // itemsTableAdapter3
            // 
            this.itemsTableAdapter3.ClearBeforeFill = true;
            // 
            // restaurantDataSet8
            // 
            this.restaurantDataSet8.DataSetName = "restaurantDataSet8";
            this.restaurantDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.restaurantDataSet8;
            // 
            // itemsTableAdapter4
            // 
            this.itemsTableAdapter4.ClearBeforeFill = true;
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "inventory";
            this.Size = new System.Drawing.Size(1721, 1046);
            this.Load += new System.EventHandler(this.inventory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
        private restaurantDataSet restaurantDataSet;
        private restaurantDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private restaurantDataSet2 restaurantDataSet2;
        private System.Windows.Forms.BindingSource restaurantDataSetBindingSource;
        private restaurantDataSet2TableAdapters.ItemsTableAdapter itemsTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private restaurantDataSet5 restaurantDataSet5;
        private restaurantDataSet5TableAdapters.ItemsTableAdapter itemsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private restaurantDataSet6 restaurantDataSet6;
        private restaurantDataSet6TableAdapters.ItemsTableAdapter itemsTableAdapter3;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private restaurantDataSet8 restaurantDataSet8;
        private restaurantDataSet8TableAdapters.ItemsTableAdapter itemsTableAdapter4;
    }
}


