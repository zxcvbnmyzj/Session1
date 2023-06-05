using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1.pojo
{
    internal class order
    {
        private int Id;
        private int OrderId;
        private int PartId;
        private string BatchNumber;
        private int Amount;
        private int TransactionTypeId;
        private int SupplierId;
        private int SourceWareHouseId;
        private int DesWareHouseId;
        private string Date;
        private string PartName;
        private string SuppliersName;
        private string TransactionName;
        private string WareHousesName;

        public int id { get => Id; set => Id = value; }
        public int orderId { get => OrderId; set => OrderId = value; }
        public int partId { get => PartId; set => PartId = value; }
        public string batchNumber { get => BatchNumber; set => BatchNumber = value; }
        public int amount { get => Amount; set => Amount = value; }
        public int transactionTypeId { get => TransactionTypeId; set => TransactionTypeId = value; }
        public int supplierId { get => SupplierId; set => SupplierId = value; }
        public int sourceWareHouseId { get => SourceWareHouseId; set => SourceWareHouseId = value; }
        public int desWareHouseId { get => DesWareHouseId; set => DesWareHouseId = value; }
        public string date { get => Date; set => Date = value; }
        public string partName { get => PartName; set => PartName = value; }
        public string suppliersName { get => SuppliersName; set => SuppliersName = value; }
        public string transactionName { get => TransactionName; set => TransactionName = value; }
        public string wareHousesName { get => WareHousesName; set => WareHousesName = value; }
    }
}
