using Glimpse.Core.ClientScript;
using session1.pojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session1.Service
{
    internal class PurchaseOrderService
    {
        List<OrderItems> items = new List<OrderItems>();

        public List<OrderItems> getOrderList(string partName, string BatchNumber, string Amount,string suppliers, string wareHouse)
        {
            if (String.IsNullOrEmpty(BatchNumber) || String.IsNullOrEmpty(partName) || String.IsNullOrEmpty(Amount) || String.IsNullOrEmpty(suppliers) || String.IsNullOrEmpty(wareHouse))
            {
                MessageBox.Show("Please enter complete information!", "prompt",MessageBoxButtons.OK, MessageBoxIcon.Error);
               return null;
            }
            int num;
            if(!int.TryParse(Amount,out num))
            {
                MessageBox.Show("Please enter a valid quantity, please re - enter!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (Convert.ToInt16(Amount) < 0)
            {
                MessageBox.Show("Please enter the correct quantity!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            for (int i = 0; i < items.Count; i++)
            {
                string batchName = items[i].BatchNumber1;
                if (batchName.Equals(BatchNumber))
                {
                    MessageBox.Show("Batch number should be unique!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
            OrderItems orderItems = new OrderItems();
            orderItems.Order1 = new Orders();
            orderItems.Parts1 = new Parts();
            orderItems.Order1.SuppliersName = suppliers;
            orderItems.Order1.WarehouseName = wareHouse;
            orderItems.Parts1.Name1 = partName;
            orderItems.BatchNumber1 = BatchNumber;
            orderItems.Amount1 = Amount;
            orderItems.Order1.TransactionType = "Purchase Order";
            items.Add(orderItems);
            return items;
        }
    }
}
