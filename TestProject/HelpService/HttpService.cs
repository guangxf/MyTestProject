using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.HelpService
{
    public static class HttpService
    {
        public static string SimulateGet(string strUrl)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var clientResult = client.GetAsync(strUrl).Result;
                    if (clientResult.StatusCode.ToString().Equals("429"))
                    {
                        return "429_busy";
                    }
                    if (clientResult.IsSuccessStatusCode)
                    {
                        var a = clientResult.Content.ReadAsStringAsync();
                        return string.Format("1_success_{0}",a.Result);
                    }
                    else
                    {
                        return string.Format("{0}_0_false", clientResult.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                return "2_exception";
            }
        }
    }
}
