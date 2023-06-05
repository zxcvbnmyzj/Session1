using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using session1.status;
using session1.api;
using session1.Utils;

namespace session1
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }


        private void POM_tsl_Click(object sender, EventArgs e)
        {

        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            //关闭自动生成列
            dgw_dataList.AutoGenerateColumns = false;
            dgvSetData();
        }

        private void dgw_dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void dgvSetData()
        {
            dgw_dataList.Columns.Clear();
            string url = "http://localhost:7777/yang/api/getInventory";

            //将数据赋值给 dataList
            dgw_dataList.DataSource = HttpRequest.getOrderData(url, "GET").Data;

            //新加一列
            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.DataPropertyName = "partName";
            column1.HeaderText = "Part Name";
            dgw_dataList.Columns.Add(column1);


            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.DataPropertyName = "transactionType";
            column2.HeaderText = "Transaction Type";
            dgw_dataList.Columns.Add(column2);

            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.DataPropertyName = "date";
            column3.HeaderText= "Date";
            dgw_dataList.Columns.Add(column3);

            DataGridViewColumn column4 = new DataGridViewTextBoxColumn();
            column4.DataPropertyName = "amount";
            column4.HeaderText = "Amount";
            dgw_dataList.Columns.Add(column4);

            DataGridViewColumn column5 = new DataGridViewTextBoxColumn();
            column5.DataPropertyName = "sourceWare";
            column5.HeaderText = "Source";
            dgw_dataList.Columns.Add(column5);

            DataGridViewColumn column6 = new DataGridViewTextBoxColumn();
            column6.DataPropertyName = "warehouseName";
            column6.HeaderText = "Destination";
            dgw_dataList.Columns.Add(column6);

            //删除列
            DataGridViewLinkColumn dataGridViewLinkColumn = new DataGridViewLinkColumn();
            dataGridViewLinkColumn.HeaderText = "Actions";
            dataGridViewLinkColumn.DataPropertyName = "action";
            dgw_dataList.Columns.Add(dataGridViewLinkColumn);
        }

        private void TS_WarehouseManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WarehouseManagement().Show();
        }

        private void TS_PurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder purchase = new PurchaseOrder();
            this.Hide();
            purchase.Show();
        }

        private void Ts_InventoryReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventoryReport().Show();
        }

        private void InventoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.Utils.Exit(this, e);
        }
    }
}
