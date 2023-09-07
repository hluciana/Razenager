using System;
using System.Text;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Razenager.Web
{
    public class RN_PostNager : IDisposable
    {
        private readonly HttpClient client;
        private readonly HttpRequestMessage request;
        private const string url_profile = "https://mimundo.upn.edu.pe/api/zubron/execute/%2Fprofile%2Fget";

        public RN_PostNager()
        {
            client = new HttpClient();
            request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(url_profile)
            };
            request.Headers.Add("Accept", "application/json, text/plain, */*");
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36");
        }

        public async Task AuthToken(string mooToken,RichTextBox rtb)
        {
            var bodyContent = "{\"params\":{\"appVersion\":\"1.0.0-PROD\",\"lang\":\"es-PE\",\"mooToken\":\"" + mooToken + "\",\"platform\":\"web\"}}";
            request.Content = new StringContent(bodyContent, Encoding.UTF8, "application/json");
            var response = await client.SendAsync(request);
            rtb.BeginInvoke((MethodInvoker)(() =>
            {
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    rtb.Text = JObject.Parse(response.Content.ReadAsStringAsync().Result).ToString();
                }
                else rtb.Text = response.Content.ReadAsStringAsync().Result;
            }));
        }

        public void Dispose()
        {
            request?.Dispose();
            client?.Dispose();
        }
    }
}
