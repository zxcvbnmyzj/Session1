using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1.pojo
{
    internal class Orders
    {
        private string osId;
        private string suppliersName;
        private string sourceWare;
        private string warehouseName;
        private string Date;
        private string transactionType;

        public string OsId { get => osId; set => osId = value; }
        public string SuppliersName { get => suppliersName; set => suppliersName = value; }
        public string SourceWare { get => sourceWare; set => sourceWare = value; }
        public string WarehouseName { get => warehouseName; set => warehouseName = value; }
        public string Date1 { get => Date; set => Date = value; }
        public string TransactionType { get => transactionType; set => transactionType = value; }
    }
}
