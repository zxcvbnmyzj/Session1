using Newtonsoft.Json;
using session1.pojo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using session1.status;
using Glimpse.Core.ClientScript;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace session1.api
{
    internal class HttpRequest
    {

        private static bool res = true;
        private int result;

        public int Result { get => result; set => result = value; }
        private order or;

        public order getWareHouseName()
        {
            return or;
        }

        public static async void operateOrder(string url,object user)
        {
            HttpClient client = new HttpClient();
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json,Encoding.UTF8,"application/json");
            var response = await client.PostAsync(url, content);
            response.EnsureSuccessStatusCode();

            //// 转换 User 对象为 JSON 数据，并发送 HTTP POST 请求
            //var response = await client.PostAsync(url,new StringContent(JsonConvert.SerializeObject(user),Encoding.UTF8,"application/json"));
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("operation failed!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }
            MessageBox.Show("Operation successful!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool getRes()
        {
            return res;
        }

        public static Result getData(string url, string Method)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = Method;
            request.ContentType = "application/json";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(myResponseStream, Encoding.UTF8);
            Result result = new Result(response.StatusCode.ToString(),"",reader.ReadToEnd());
            reader.Close();
            myResponseStream.Close();
            return result;
        }

        public static Result getOrderData(string url,string Method)
        {
            try
            {
                //设置请求参数
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = Method;
                request.ContentType = "application/json";

                //发送请求
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        //解析返回结果
                        using (Stream stream = response.GetResponseStream())
                        {
                            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                            string json = reader.ReadToEnd();
                            Result data = JsonConvert.DeserializeObject<Result>(json);
                            if (data != null)
                            {
                                return new Result(response.StatusCode.ToString(),"", data.Data);
                            }
                            return null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to obtain data");
                        return new Result(response.StatusCode.ToString(), "",null);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Failed to call interface：" + e.Message);
                return null;
            }
        }
        
        public static void updateOrAddData(string url,string Method,order orderItems)
        {
            try
            {
                //设置请求参数
                HttpWebRequest request = (HttpWebRequest)(WebRequest.Create(url));
                request.Method = Method;
                request.ContentType = "application/json";

                //制造JSON数据
                string json = JsonConvert.SerializeObject(orderItems);
                byte[] data = Encoding.UTF8.GetBytes(json);
                request.ContentLength = data.Length;
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                //发送请求
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if(response.StatusCode == HttpStatusCode.OK)
                    {
                        MessageBox.Show("Operation successful");
                    }
                    else
                    {
                        MessageBox.Show("operation failed");
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Failed to call interface：" + e.Message);
            }
        }


        public async void getWareHouseName(string url,string Methed,order orderItem)
        {
            // 创建 HttpClient 实例
            var httpClient = new HttpClient();

            // 将请求参数序列化为 JSON 格式
            var jsonRequestBody = JsonConvert.SerializeObject(orderItem);

            // 创建一个 HTTP 请求消息，请求方法为 POST，请求体是 JSON 格式的请求参数
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json")
            };

            // 发送请求并等待响应
            var responseMessage = await httpClient.SendAsync(requestMessage);

            // 如果响应状态码是成功的，就从响应主体中读取数据
            if (responseMessage.IsSuccessStatusCode)
            {
                or.desWareHouseId = Convert.ToInt32(await responseMessage.Content.ReadAsStringAsync());
            }
        }

    }
}
