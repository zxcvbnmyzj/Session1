using session1.pojo;
using session1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session1
{
    public partial class WarehouseManagement : Form
    {
        public WarehouseManagement()
        {
            InitializeComponent();
        }

        private void WarehouseManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.Utils.Exit(this, e);
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventoryManagement().Show();
        }

        private void but_submit_Click(object sender, EventArgs e)
        {

        }

        private void WarehouseManagement_Load(object sender, EventArgs e)
        {
            this.Initialization();
        }

        private void Initialization()
        {
            List<string> wareHouseList = Utils.Utils.getWareHouseList();
            for (int i = 0; i < wareHouseList.Count; i++)
            {
                cbb_Source.Items.Add(wareHouseList[i]);
                cbb_destination.Items.Add(wareHouseList[i]);
            }
            cbb_Source.Text = wareHouseList[0].ToString();
            cbb_destination.Text = wareHouseList[0].ToString();

            List<string> partNameList = Utils.Utils.getPartList();
            for(int i =0;i< partNameList.Count;i++)
            {
                cbb_PartName.Items.Add(partNameList[i]);
            }
            cbb_PartName.Text= partNameList[0].ToString();
        }

        private List<OrderItems> orderList;



        private void addList_Click(object sender, EventArgs e)
        {
            string sourceWareHouse = cbb_Source.Text;
            string DesWareHouse = cbb_destination.Text;
            string partName = cbb_PartName.Text;
            string batchNum = txt_BatchNum.Text;
            string amount = txt_Amount.Text;

            new WareHouseManagementService().getOrderList(sourceWareHouse,DesWareHouse,partName, batchNum, amount);

        }
    }
}
