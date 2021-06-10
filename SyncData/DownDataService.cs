using log4net;
using log4net.Config;
using log4net.Repository;
using Newtonsoft.Json;
using SyncData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace SyncData
{
    public class DownDataService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log"></param>
        /// <param name="firstnum"></param>
        /// <param name="lengthsearch"></param>
        /// <param name="tonum"></param>
        /// <returns></returns>
        public int Download(ILog log, long firstnum, long lengthsearch, out long tonum)
        {
            string tablename = "car_renewal";
            tonum = firstnum + lengthsearch + 1;
            string securl = $"Agent=102&tName={tablename}&FromId={firstnum}&toId={tonum}";
            string seccode = securl.GetMd5();
            string url = $"http:// /api/http/BackDbToStatistic?{securl}&seccode={seccode}";            
            try
            {
                using (var client = new HttpClient())
                {
                    var clientResult = client.GetAsync(url).Result;
                    if (clientResult.IsSuccessStatusCode)
                    {
                        var result = clientResult.Content.ReadAsStringAsync().Result;
                        log.Info($"请求串：{url}");//，返回结果：{result}
                        int count = 0;
                        if (tablename.Equals("carinfo"))
                        {
                            Carinfo a = JsonConvert.DeserializeObject<Carinfo>(result);
                            List<bx_carinfo> list = a.Data;
                            DbRepository db = new DbRepository();
                            count = db.InsertCarinfo(log, list);
                            return count;
                        }
                        if (tablename.Equals("car_renewal"))
                        {
                            Carrenewal a = JsonConvert.DeserializeObject<Carrenewal>(result);
                            List<bx_car_renewal> list = a.Data;
                            DbRepository db = new DbRepository();
                            count = db.InsertCarrenewal(log, list);
                            return count;
                        }
                        if (tablename.Equals("agent"))
                        {
                            Agent a = JsonConvert.DeserializeObject<Agent>(result);
                            List<bx_agent> list = a.Data;
                            DbRepository db = new DbRepository();
                            count = db.InsertAgent(log, list);
                            return count;
                        }
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                log.Info("发生异常:" + ex.Source + "\n" + ex.StackTrace + "\n" + ex.Message + "\n" + ex.InnerException);
            }
            return 0;
        }

        public class Agent : BaseResult
        {
            public List<bx_agent> Data { get; set; }
        }
        public class Carinfo : BaseResult
        {
            public List<bx_carinfo> Data { get; set; }
        }
        public class Carrenewal : BaseResult
        {
            public List<bx_car_renewal> Data { get; set; }
        }
        public class BaseResult
        {
            public int Code { get; set; }
            public string Message { get; set; }
            //public object Data { get; set; }
        }
    }
}
