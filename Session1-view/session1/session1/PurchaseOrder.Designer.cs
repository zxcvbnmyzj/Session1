namespace session1
{
    partial class PurchaseOrder
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ordersList = new System.Windows.Forms.DataGridView();
            this.but_addList = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_batchNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_partName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dateTime = new System.Windows.Forms.DateTimePicker();
            this.cbb_WareHouses = new System.Windows.Forms.ComboBox();
            this.cbb_Suppliers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordersList)).BeginInit();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(676, 502);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(100, 29);
            this.but_cancel.TabIndex = 17;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_submit
            // 
            this.but_submit.Location = new System.Drawing.Point(320, 502);
            this.but_submit.Margin = new System.Windows.Forms.Padding(4);
            this.but_submit.Name = "but_submit";
            this.but_submit.Size = new System.Drawing.Size(100, 29);
            this.but_submit.TabIndex = 16;
            this.but_submit.Text = "Submit";
            this.but_submit.UseVisualStyleBackColor = true;
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_ordersList);
            this.groupBox1.Controls.Add(this.but_addList);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_batchNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_partName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1056, 321);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts List";
            // 
            // dgv_ordersList
            // 
            this.dgv_ordersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordersList.Location = new System.Drawing.Point(11, 77);
            this.dgv_ordersList.Name = "dgv_ordersList";
            this.dgv_ordersList.RowHeadersWidth = 51;
            this.dgv_ordersList.RowTemplate.Height = 27;
            this.dgv_ordersList.Size = new System.Drawing.Size(1029, 237);
            this.dgv_ordersList.TabIndex = 8;
            // 
            // but_addList
            // 
            this.but_addList.Location = new System.Drawing.Point(919, 34);
            this.but_addList.Margin = new System.Windows.Forms.Padding(4);
            this.but_addList.Name = "but_addList";
            this.but_addList.Size = new System.Drawing.Size(121, 29);
            this.but_addList.TabIndex = 7;
            this.but_addList.Text = "+Add to list";
            this.but_addList.UseVisualStyleBackColor = true;
            this.but_addList.Click += new System.EventHandler(this.but_addList_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(794, 38);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(89, 25);
            this.txt_Amount.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount:";
            // 
            // txt_batchNum
            // 
            this.txt_batchNum.Location = new System.Drawing.Point(529, 38);
            this.txt_batchNum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_batchNum.Name = "txt_batchNum";
            this.txt_batchNum.Size = new System.Drawing.Size(167, 25);
            this.txt_batchNum.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Batch Number:";
            // 
            // cbb_partName
            // 
            this.cbb_partName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_partName.FormattingEnabled = true;
            this.cbb_partName.Location = new System.Drawing.Point(103, 38);
            this.cbb_partName.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_partName.Name = "cbb_partName";
            this.cbb_partName.Size = new System.Drawing.Size(274, 23);
            this.cbb_partName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Part Name:";
            // 
            // dtp_dateTime
            // 
            this.dtp_dateTime.Location = new System.Drawing.Point(116, 109);
            this.dtp_dateTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dateTime.Name = "dtp_dateTime";
            this.dtp_dateTime.Size = new System.Drawing.Size(164, 25);
            this.dtp_dateTime.TabIndex = 14;
            // 
            // cbb_WareHouses
            // 
            this.cbb_WareHouses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_WareHouses.FormattingEnabled = true;
            this.cbb_WareHouses.Location = new System.Drawing.Point(583, 39);
            this.cbb_WareHouses.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_WareHouses.Name = "cbb_WareHouses";
            this.cbb_WareHouses.Size = new System.Drawing.Size(297, 23);
            this.cbb_WareHouses.TabIndex = 11;
            // 
            // cbb_Suppliers
            // 
            this.cbb_Suppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Suppliers.FormattingEnabled = true;
            this.cbb_Suppliers.Location = new System.Drawing.Point(52, 39);
            this.cbb_Suppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Suppliers.Name = "cbb_Suppliers";
            this.cbb_Suppliers.Size = new System.Drawing.Size(275, 23);
            this.cbb_Suppliers.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suppliers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "WareHouses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "date:";
            // 
            // PurchaseOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1079, 549);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_dateTime);
            this.Controls.Add(this.cbb_WareHouses);
            this.Controls.Add(this.cbb_Suppliers);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseOrder";
            this.Text = "Purchase_Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchaseOrder_FormClosing);
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ordersList;
        private System.Windows.Forms.Button but_addList;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_batchNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_partName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dateTime;
        private System.Windows.Forms.ComboBox cbb_WareHouses;
        private System.Windows.Forms.ComboBox cbb_Suppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

