using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1.pojo
{
    internal class OrderItems
    {
        private string OId;
        private Orders Order;
        private Parts Parts;
        private string BatchNumber;
        private string Amount;

        public OrderItems()
        {
        }

        public OrderItems(string oId, Orders order, Parts parts, string batchNumber, string amount)
        {
            OId = oId;
            Order = order;
            Parts = parts;
            BatchNumber = batchNumber;
            Amount = amount;
        }

        public string OId1 { get => OId; set => OId = value; }
        public string BatchNumber1 { get => BatchNumber; set => BatchNumber = value; }
        public string Amount1 { get => Amount; set => Amount = value; }
        internal Orders Order1 { get => Order; set => Order = value; }
        internal Parts Parts1 { get => Parts; set => Parts = value; }


    }
}
