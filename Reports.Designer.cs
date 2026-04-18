namespace RestaurantManagementSystem.UI
{
    partial class Reports
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonTotally = new System.Windows.Forms.Button();
            this.buttonWeekly = new System.Windows.Forms.Button();
            this.buttonMonthly = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(416, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(133, 45);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Reports";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Location = new System.Drawing.Point(376, 229);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(964, 61);
            this.panelHeader.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 422);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(964, 347);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonTotally
            // 
            this.buttonTotally.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonTotally.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotally.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTotally.Location = new System.Drawing.Point(995, 798);
            this.buttonTotally.Name = "buttonTotally";
            this.buttonTotally.Size = new System.Drawing.Size(108, 35);
            this.buttonTotally.TabIndex = 6;
            this.buttonTotally.Text = "Totally";
            this.buttonTotally.UseVisualStyleBackColor = false;
            this.buttonTotally.Click += new System.EventHandler(this.buttonTotally_Click);
            // 
            // buttonWeekly
            // 
            this.buttonWeekly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeekly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWeekly.Location = new System.Drawing.Point(1113, 798);
            this.buttonWeekly.Name = "buttonWeekly";
            this.buttonWeekly.Size = new System.Drawing.Size(108, 35);
            this.buttonWeekly.TabIndex = 7;
            this.buttonWeekly.Text = "Weekly";
            this.buttonWeekly.UseVisualStyleBackColor = false;
            this.buttonWeekly.Click += new System.EventHandler(this.buttonWeekly_Click);
            // 
            // buttonMonthly
            // 
            this.buttonMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMonthly.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMonthly.Location = new System.Drawing.Point(1232, 798);
            this.buttonMonthly.Name = "buttonMonthly";
            this.buttonMonthly.Size = new System.Drawing.Size(108, 35);
            this.buttonMonthly.TabIndex = 8;
            this.buttonMonthly.Text = "Monthly";
            this.buttonMonthly.UseVisualStyleBackColor = false;
            this.buttonMonthly.Click += new System.EventHandler(this.buttonMonthly_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMonthly);
            this.Controls.Add(this.buttonWeekly);
            this.Controls.Add(this.buttonTotally);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHeader);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1721, 1046);
            this.Load += new System.EventHandler(this.Reports_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonTotally;
        private System.Windows.Forms.Button buttonWeekly;
        private System.Windows.Forms.Button buttonMonthly;
    }
}


