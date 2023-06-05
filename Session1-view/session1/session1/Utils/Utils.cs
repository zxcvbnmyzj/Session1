using Newtonsoft.Json.Linq;
using session1.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session1.Utils
{
    internal class Utils
    {
        public static void Exit(Form form, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit?", "prompt", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
                form.Dispose();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }


        public static List<string> getPartList()
        {
            List<string> partList;

            string partsUrl = "http://localhost:7777/yang/api/getPartName";
            try
            {
                JArray partArray = JArray.Parse(HttpRequest.getOrderData(partsUrl, "GET").Data.ToString());
                partList = partArray.ToList().ConvertAll(x => x.ToString());
                return partList;
            }catch(Exception e)
            {
                MessageBox.Show("Server Error", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static List<string> getSuppliersList()
        {
            string SuppliersUrl = "http://localhost:7777/yang/api/getSuppliersName";
            List<string> supplierList;

            try
            {
                JArray supplierArray = JArray.Parse(HttpRequest.getOrderData(SuppliersUrl, "GET").Data.ToString());
                supplierList = supplierArray.ToList().ConvertAll(x => x.ToString());
                return supplierList;
            }catch(Exception e)
            {
                MessageBox.Show("Server Error", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public static List<string> getWareHouseList()
        {
            string WareHouseUrl = "http://localhost:7777/yang/api/getWareHouses";
            List<string> wareHousrList;
            try
            {
                JArray wareHouseArray = JArray.Parse(HttpRequest.getOrderData(WareHouseUrl, "GET").Data.ToString());
                wareHousrList = wareHouseArray.ToList().ConvertAll(x => x.ToString());
                return wareHousrList;
            }
            catch (Exception e)
            {
                MessageBox.Show("Server Error", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
