using Hangfire.RecurringJobExtensions;
using Hangfire.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestCoreWeb.Models;
using TestCoreWeb.Services;

namespace TestCoreWeb.RecurringJobs
{
    public class DownDataJob : IRecurringJob
    {
        public void Execute(PerformContext context)
        {
            string tablename = "agent";
            long i = 0;//起始值，放缓存里
            int lengthsearch = 50;//每次查询长度500条，库里的id是单双跳着走的，实际250条。
            string securl = $"Agent=102&tName={tablename}&FromId={i}&toId={i + lengthsearch}";
            string seccode = securl.GetMd5();
            string url = $"http://114.118.27.21:5099/api/http/BackDbToStatistic?{securl}&seccode={seccode}";
            try
            {
                using (var client = new HttpClient())
                {
                    var clientResult = client.GetAsync(url).Result;
                    if (clientResult.IsSuccessStatusCode)
                    {
                        var result = clientResult.Content.ReadAsStringAsync();
                        int count = 0;
                        if (tablename.Equals("agent"))
                        {
                            Agent a = JsonConvert.DeserializeObject<Agent>(result.Result);
                            List<bx_agent> list = a.Data;
                            DbRepository db = new DbRepository();
                            count = db.InsertAgent(list);
                        }
                        if (count > 0)
                        {
                            i = i + lengthsearch - 1;//将i保存起来
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public class Agent : BaseResult
        {
            public List<bx_agent> Data { get; set; }
        }

        public class BaseResult
        {
            public int Code { get; set; }
            public string Message { get; set; }
            //public object Data { get; set; }
        }
    }
}
