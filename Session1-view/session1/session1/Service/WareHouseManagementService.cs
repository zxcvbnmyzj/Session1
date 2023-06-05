using session1.api;
using session1.pojo;
using session1.status;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session1.Service
{
    internal class WareHouseManagementService
    {
        private List<order> orders = new List<order>();

        public List<order> getOrderList(string sourceWareHouse,string DesWareHouse,string partName,string batchNum,string amount)
        {
            string url = "http://localhost:7777/yang/api/getWareHouseName";

            if (String.IsNullOrEmpty(sourceWareHouse) || String.IsNullOrEmpty(DesWareHouse) || String.IsNullOrEmpty(partName) || String.IsNullOrEmpty(batchNum) || String.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Please enter complete information!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            int num;
            if(!int.TryParse(amount, out num))
            {
                MessageBox.Show("Please enter a valid quantity, please re - enter!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if(Convert.ToInt16(amount) < 0)
            {
                MessageBox.Show("Please enter the correct quantity!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            for (int i = 0; i < orders.Count; i++)
            {
                string batch = orders[i].batchNumber;
                if (batch.Equals(batchNum))
                {
                    MessageBox.Show("Batch number should be unique!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }

            order orderItem = new order();
            orderItem.wareHousesName = sourceWareHouse;

            HttpRequest request = new HttpRequest();
            request.getWareHouseName(url, "POST", orderItem);

            

            order der = new order();
            return orders;
        }
    }
}
