namespace session1
{
    partial class InventoryManagement
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
            this.dgw_dataList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TS_PurchaseOrder = new System.Windows.Forms.ToolStripLabel();
            this.TS_WarehouseManagement = new System.Windows.Forms.ToolStripLabel();
            this.Ts_InventoryReport = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dataList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_dataList
            // 
            this.dgw_dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_dataList.Location = new System.Drawing.Point(12, 28);
            this.dgw_dataList.Name = "dgw_dataList";
            this.dgw_dataList.RowHeadersWidth = 51;
            this.dgw_dataList.RowTemplate.Height = 27;
            this.dgw_dataList.Size = new System.Drawing.Size(1029, 516);
            this.dgw_dataList.TabIndex = 1;
            this.dgw_dataList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_dataList_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_PurchaseOrder,
            this.TS_WarehouseManagement,
            this.Ts_InventoryReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TS_PurchaseOrder
            // 
            this.TS_PurchaseOrder.Name = "TS_PurchaseOrder";
            this.TS_PurchaseOrder.Size = new System.Drawing.Size(222, 22);
            this.TS_PurchaseOrder.Text = "Purchase Order Management";
            this.TS_PurchaseOrder.Click += new System.EventHandler(this.TS_PurchaseOrder_Click);
            // 
            // TS_WarehouseManagement
            // 
            this.TS_WarehouseManagement.Name = "TS_WarehouseManagement";
            this.TS_WarehouseManagement.Size = new System.Drawing.Size(192, 22);
            this.TS_WarehouseManagement.Text = "Warehouse Management";
            this.TS_WarehouseManagement.Click += new System.EventHandler(this.TS_WarehouseManagement_Click);
            // 
            // Ts_InventoryReport
            // 
            this.Ts_InventoryReport.Name = "Ts_InventoryReport";
            this.Ts_InventoryReport.Size = new System.Drawing.Size(133, 22);
            this.Ts_InventoryReport.Text = "Inventory Report";
            this.Ts_InventoryReport.Click += new System.EventHandler(this.Ts_InventoryReport_Click);
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 590);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgw_dataList);
            this.Name = "InventoryManagement";
            this.Text = "InventoryManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryManagement_FormClosing);
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_dataList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw_dataList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel TS_PurchaseOrder;
        private System.Windows.Forms.ToolStripLabel TS_WarehouseManagement;
        private System.Windows.Forms.ToolStripLabel Ts_InventoryReport;
    }
}