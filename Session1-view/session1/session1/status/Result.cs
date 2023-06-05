using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session1.status
{
    internal class Result
    {
        private string message;
        private string responseCode;
        private object data;

        public Result()
        {

        }

        public Result(string message, string responseCode, object data)
        {
            this.message = message;
            this.responseCode = responseCode;
            this.data = data;
        }

        public string Message { get => message; set => message = value; }
        public string ResponseCode { get => responseCode; set => responseCode = value; }
        public object Data { get => data; set => data = value; }
    }
}
