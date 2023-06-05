using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using session1.api;
using session1.pojo;
using session1.Service;
using session1.status;

namespace session1
{
    public partial class PurchaseOrder : Form
    {

        private PurchaseOrderService orderService = new PurchaseOrderService();
        private List<OrderItems> orderList = new List<OrderItems>();
        int index = 0;


        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {

            //关闭自动生成列
            dgv_ordersList.AutoGenerateColumns = false;

            Initialization();
        }

        private void PurchaseOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.Utils.Exit(this, e);
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventoryManagement().Show();
        }


        public void Initialization()
        {
            dgv_ordersList.Columns.Clear();

            List<string> partList = Utils.Utils.getPartList();
            List<string> supplierList = Utils.Utils.getSuppliersList();
            List<string> wareHousrList  = Utils.Utils.getWareHouseList();

            for (int i = 0; i < partList.Count; i++)
            {
                cbb_partName.Items.Add(partList[i]);
            }
            cbb_partName.Text= partList[0].ToString();

            for (int i = 0; i < supplierList.Count; i++)
            {
                cbb_Suppliers.Items.Add(supplierList[i]);
            }
            cbb_Suppliers.Text = supplierList[0].ToString();

            for (int i = 0; i < wareHousrList.Count; i++)
            {
                cbb_WareHouses.Items.Add(wareHousrList[i]);
            }
            cbb_WareHouses.Text = wareHousrList[0].ToString();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < orderList.Count; i++)
            {
                string url = "http://localhost:7777/yang/api/addOrder";
                order orders = new order();
                orders.suppliersName = orderList[i].Order1.SuppliersName;
                orders.wareHousesName= orderList[i].Order1.WarehouseName;
                string[] dateArr = dtp_dateTime.Value.ToString().Split(' ');
                orders.date = dateArr[0];
                orders.partName = orderList[i].Parts1.Name1;
                orders.batchNumber = orderList[i].BatchNumber1;
                orders.amount =  Convert.ToInt32(orderList[i].Amount1);
                orders.transactionName = orderList[i].Order1.TransactionType;
                HttpRequest.operateOrder(url, orders);
                if(HttpRequest.getRes())
                {
                    this.Hide();
                    new InventoryManagement().Show();
                }
            }
        }

        
        private void but_addList_Click(object sender, EventArgs e)
        {
            string suppliers = cbb_Suppliers.Text;
            string wareHouse = cbb_WareHouses.Text;
            string partName = cbb_partName.Text;
            string BatchNumber = txt_batchNum.Text;
            string Amount = txt_Amount.Text;
            
            orderList = orderService.getOrderList(partName,BatchNumber,Amount,suppliers,wareHouse);
            if (orderList == null || orderList.Count == 0)
            {
                txt_Amount.Text = "";
                return;
            }

            DataGridViewColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Part Name";
            column1.Width = 300;
            dgv_ordersList.Columns.Add(column1);


            DataGridViewColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Batch Number";
            column2.Width = 255;
            dgv_ordersList.Columns.Add(column2);

            DataGridViewColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Amount";
            column3.Width = 200;
            dgv_ordersList.Columns.Add(column3);

            DataGridViewLinkColumn dataGridViewLinkColumn = new DataGridViewLinkColumn();
            dataGridViewLinkColumn.HeaderText = "Actions";
            dataGridViewLinkColumn.Width = 200;
            dgv_ordersList.Columns.Add(dataGridViewLinkColumn);

            dgv_ordersList.Rows.Add();

            dgv_ordersList.Rows[index].Cells[0].Value = partName;
            dgv_ordersList.Rows[index].Cells[1].Value = BatchNumber;
            dgv_ordersList.Rows[index].Cells[2].Value = Amount;
            dgv_ordersList.Rows[index].Cells[3].Value = "Remove";

            index++;
        }
    }
}
