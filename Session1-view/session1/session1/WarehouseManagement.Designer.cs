namespace session1
{
    partial class WarehouseManagement
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
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_submit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGV_dataList = new System.Windows.Forms.DataGridView();
            this.addList = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_PartName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_dataTime = new System.Windows.Forms.DateTimePicker();
            this.cbb_destination = new System.Windows.Forms.ComboBox();
            this.cbb_Source = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BatchNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dataList)).BeginInit();
            this.SuspendLayout();
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(543, 497);
            this.but_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(100, 29);
            this.but_cancel.TabIndex = 24;
            this.but_cancel.Text = "Cancel";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_submit
            // 
            this.but_submit.Location = new System.Drawing.Point(328, 497);
            this.but_submit.Margin = new System.Windows.Forms.Padding(4);
            this.but_submit.Name = "but_submit";
            this.but_submit.Size = new System.Drawing.Size(100, 29);
            this.but_submit.TabIndex = 23;
            this.but_submit.Text = "Submit";
            this.but_submit.UseVisualStyleBackColor = true;
            this.but_submit.Click += new System.EventHandler(this.but_submit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_BatchNum);
            this.groupBox1.Controls.Add(this.DGV_dataList);
            this.groupBox1.Controls.Add(this.addList);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_PartName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(36, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1094, 319);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parts List";
            // 
            // DGV_dataList
            // 
            this.DGV_dataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dataList.Location = new System.Drawing.Point(7, 73);
            this.DGV_dataList.Name = "DGV_dataList";
            this.DGV_dataList.RowHeadersWidth = 51;
            this.DGV_dataList.RowTemplate.Height = 27;
            this.DGV_dataList.Size = new System.Drawing.Size(1080, 239);
            this.DGV_dataList.TabIndex = 9;
            // 
            // addList
            // 
            this.addList.Location = new System.Drawing.Point(936, 41);
            this.addList.Margin = new System.Windows.Forms.Padding(4);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(121, 26);
            this.addList.TabIndex = 7;
            this.addList.Text = "+Add to list";
            this.addList.UseVisualStyleBackColor = true;
            this.addList.Click += new System.EventHandler(this.addList_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(809, 42);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(89, 25);
            this.txt_Amount.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Batch Number:";
            // 
            // cbb_PartName
            // 
            this.cbb_PartName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PartName.FormattingEnabled = true;
            this.cbb_PartName.Location = new System.Drawing.Point(103, 38);
            this.cbb_PartName.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_PartName.Name = "cbb_PartName";
            this.cbb_PartName.Size = new System.Drawing.Size(315, 23);
            this.cbb_PartName.TabIndex = 1;
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
            // dtp_dataTime
            // 
            this.dtp_dataTime.Location = new System.Drawing.Point(86, 120);
            this.dtp_dataTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dataTime.Name = "dtp_dataTime";
            this.dtp_dataTime.Size = new System.Drawing.Size(164, 25);
            this.dtp_dataTime.TabIndex = 21;
            // 
            // cbb_destination
            // 
            this.cbb_destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_destination.FormattingEnabled = true;
            this.cbb_destination.Location = new System.Drawing.Point(581, 51);
            this.cbb_destination.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_destination.Name = "cbb_destination";
            this.cbb_destination.Size = new System.Drawing.Size(285, 23);
            this.cbb_destination.TabIndex = 18;
            // 
            // cbb_Source
            // 
            this.cbb_Source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Source.FormattingEnabled = true;
            this.cbb_Source.Location = new System.Drawing.Point(36, 51);
            this.cbb_Source.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Source.Name = "cbb_Source";
            this.cbb_Source.Size = new System.Drawing.Size(275, 23);
            this.cbb_Source.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Source Warehouse:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Destination Warehouse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date:";
            // 
            // txt_BatchNum
            // 
            this.txt_BatchNum.Location = new System.Drawing.Point(562, 38);
            this.txt_BatchNum.Name = "txt_BatchNum";
            this.txt_BatchNum.Size = new System.Drawing.Size(146, 25);
            this.txt_BatchNum.TabIndex = 10;
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_dataTime);
            this.Controls.Add(this.cbb_destination);
            this.Controls.Add(this.cbb_Source);
            this.Controls.Add(this.label1);
            this.Name = "WarehouseManagement";
            this.Text = "WarehouseManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WarehouseManagement_FormClosing);
            this.Load += new System.EventHandler(this.WarehouseManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_submit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_PartName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_dataTime;
        private System.Windows.Forms.ComboBox cbb_destination;
        private System.Windows.Forms.ComboBox cbb_Source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_dataList;
        private System.Windows.Forms.TextBox txt_BatchNum;
    }
}