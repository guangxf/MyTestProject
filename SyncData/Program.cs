using log4net;
using log4net.Config;
using log4net.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Data.Common;
using System.IO;
using System.Threading;

namespace SyncData
{
    class Program
    {
        private static ILoggerRepository LoggerRepository;
        static void Main(string[] args)
        {
            //初始db
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySqlClientFactory.Instance);
            //初始日志
            LoggerRepository = LogManager.CreateRepository("Log4netConsolePractice");
            XmlConfigurator.ConfigureAndWatch(LoggerRepository, new FileInfo("App.config"));
            var log = LogManager.GetLogger(LoggerRepository.Name, typeof(Program));
            //插入数据
            long tonum = 0;
            string logstr = string.Empty;
            DownDataService downDataService;
            const int lengthsearch = 3000;//每次查询长度500条，库里的id是单双跳着走的，实际250条。
            int doinsert = 0;
            for (long i = 1983100; i < 4000001; i = i + lengthsearch)
            //carinfo调用到 118880001
            //for (long i = 118730000; i < 118740001; i = i + lengthsearch)
            {
                downDataService = new DownDataService();
                doinsert = downDataService.Download(log, i, lengthsearch, out tonum);
                logstr = $"{DateTime.Now.ToString("HH:mm:ss")}，从 {i} 到 {tonum} 写入成功，写入{doinsert}条";
                log.Info(logstr);
                Console.WriteLine(logstr);
                Thread.Sleep(2000);
            }
            Console.WriteLine("完成");
            Console.ReadLine();

        }
    }
}
