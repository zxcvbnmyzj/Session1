namespace session1
{
    partial class InventoryReport
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_outOfStock = new System.Windows.Forms.RadioButton();
            this.rb_received = new System.Windows.Forms.RadioButton();
            this.rb_current = new System.Windows.Forms.RadioButton();
            this.cbb_warehouse = new System.Windows.Forms.ComboBox();
            this.DGV_dataList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.but_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_outOfStock);
            this.groupBox1.Controls.Add(this.rb_received);
            this.groupBox1.Controls.Add(this.rb_current);
            this.groupBox1.Location = new System.Drawing.Point(363, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(563, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory Type";
            // 
            // rb_outOfStock
            // 
            this.rb_outOfStock.AutoSize = true;
            this.rb_outOfStock.Location = new System.Drawing.Point(389, 44);
            this.rb_outOfStock.Margin = new System.Windows.Forms.Padding(4);
            this.rb_outOfStock.Name = "rb_outOfStock";
            this.rb_outOfStock.Size = new System.Drawing.Size(132, 19);
            this.rb_outOfStock.TabIndex = 2;
            this.rb_outOfStock.TabStop = true;
            this.rb_outOfStock.Text = " Out of Stock";
            this.rb_outOfStock.UseVisualStyleBackColor = true;
            // 
            // rb_received
            // 
            this.rb_received.AutoSize = true;
            this.rb_received.Location = new System.Drawing.Point(208, 44);
            this.rb_received.Margin = new System.Windows.Forms.Padding(4);
            this.rb_received.Name = "rb_received";
            this.rb_received.Size = new System.Drawing.Size(148, 19);
            this.rb_received.TabIndex = 1;
            this.rb_received.TabStop = true;
            this.rb_received.Text = " Received Stock";
            this.rb_received.UseVisualStyleBackColor = true;
            // 
            // rb_current
            // 
            this.rb_current.AutoSize = true;
            this.rb_current.Location = new System.Drawing.Point(39, 44);
            this.rb_current.Margin = new System.Windows.Forms.Padding(4);
            this.rb_current.Name = "rb_current";
            this.rb_current.Size = new System.Drawing.Size(132, 19);
            this.rb_current.TabIndex = 0;
            this.rb_current.TabStop = true;
            this.rb_current.Text = "Current Stock";
            this.rb_current.UseVisualStyleBackColor = true;
            // 
            // cbb_warehouse
            // 
            this.cbb_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_warehouse.FormattingEnabled = true;
            this.cbb_warehouse.Location = new System.Drawing.Point(14, 45);
            this.cbb_warehouse.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_warehouse.Name = "cbb_warehouse";
            this.cbb_warehouse.Size = new System.Drawing.Size(236, 23);
            this.cbb_warehouse.TabIndex = 6;
            // 
            // DGV_dataList
            // 
            this.DGV_dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dataList.Location = new System.Drawing.Point(12, 111);
            this.DGV_dataList.Name = "DGV_dataList";
            this.DGV_dataList.RowHeadersWidth = 51;
            this.DGV_dataList.RowTemplate.Height = 27;
            this.DGV_dataList.Size = new System.Drawing.Size(948, 324);
            this.DGV_dataList.TabIndex = 9;
            this.DGV_dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_dataList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Warehouse:";
            // 
            // but_Cancel
            // 
            this.but_Cancel.Location = new System.Drawing.Point(792, 461);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(104, 48);
            this.but_Cancel.TabIndex = 11;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 532);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_dataList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbb_warehouse);
            this.Name = "InventoryReport";
            this.Text = "InventoryReport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryReport_FormClosing);
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_outOfStock;
        private System.Windows.Forms.RadioButton rb_received;
        private System.Windows.Forms.RadioButton rb_current;
        private System.Windows.Forms.ComboBox cbb_warehouse;
        private System.Windows.Forms.DataGridView DGV_dataList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Cancel;
    }
}