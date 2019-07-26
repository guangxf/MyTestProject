using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestProject.HelpService;
using TestProject.ViewModel;

namespace TestProject.TempService
{
    class TempTestService
    {
        public void DateDiff()
        {
            DateClass dc = new DateClass();
            int forceDays = 0;
            dc.DateDiff(DateTime.Parse("2017-07-07"), DateTime.Now, out forceDays);
            Console.WriteLine(forceDays);
        }
        public void TestJson()
        {
            #region testjson
            JsonModel.ReMsg model = new JsonModel.ReMsg
            {
                ErrCode = -1,
                ErrMsg = "cuowu",
                Version = ""
            };
            string strjson = JsonConvert.SerializeObject(model);
            var reMsg = (JsonModel.ReMsg)JsonConvert.DeserializeObject(strjson);
            Console.WriteLine(reMsg.ErrCode);
            Console.WriteLine(reMsg.ErrMsg);
            Console.WriteLine(reMsg.Version);
            #endregion
            #region testvalue
            SecretService tv = new SecretService();
            var va = GetAdd();

            string ms = "lkjdsfi%lkdsjfak&kdsjafikd3231&djfie";
            Console.WriteLine("utf-8:" + tv.GetMd5(ms));
            Console.WriteLine("default:" + tv.GetMd51(ms));
            Console.WriteLine("====================");
            Console.WriteLine(string.Format("ab值为：{0}", va.value1));
            Console.WriteLine(string.Format("ac值为：{0}", va.value2));
            Console.WriteLine(string.Format("bc值为：{0}", va.value3));
            Console.WriteLine(string.Format("abc值为：{0}", va.value4));
            Console.WriteLine("====================");
            Console.WriteLine(string.Format("abc包含a为：{0}", GetOther(va.value4, 1)));
            Console.WriteLine(string.Format("abc包含b为：{0}", GetOther(va.value4, 2)));
            Console.WriteLine(string.Format("abc包含c为：{0}", GetOther(va.value4, 4)));
            Console.WriteLine(string.Format("abc包含ab为：{0}", GetOther(va.value4, va.value1)));
            Console.WriteLine(string.Format("abc包含ac为：{0}", GetOther(va.value4, va.value2)));
            Console.WriteLine(string.Format("abc包含bc为：{0}", GetOther(va.value4, va.value3)));
            Console.WriteLine(string.Format("abc包含abc为：{0}", GetOther(va.value4, va.value4)));
            #endregion
        }
        #region 位运算
        public GetValue GetAdd()
        {
            GetValue gv = new GetValue();
            int a = 1;
            int b = 2;
            int c = 4;
            gv.value1 = a | b;
            gv.value2 = a | c;
            gv.value3 = b | c;
            gv.value4 = a | b | c;
            return gv;
        }
        public int GetOther(int num1, int num2)
        {
            return num1 & num2;
        }
        public class GetValue
        {
            public int value1 { get; set; }
            public int value2 { get; set; }
            public int value3 { get; set; }
            public int value4 { get; set; }
        }
        #endregion
    }
}
