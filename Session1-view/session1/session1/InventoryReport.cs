using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using session1.api;
using session1.Utils;

namespace session1
{
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void DGV_dataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InventoryReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.Utils.Exit(this, e);
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InventoryManagement().Show();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            this.Initialization();
        }

        private void Initialization()
        {
            List<string> wareHouseList =  Utils.Utils.getWareHouseList();

            for (int i = 0; i < wareHouseList.Count; i++)
            {
                cbb_warehouse.Items.Add(wareHouseList[i]);
            }
            cbb_warehouse.Text = wareHouseList[0].ToString();
        }

    }
}
