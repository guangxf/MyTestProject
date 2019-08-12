using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack;
using TestProject.StringCompare;
using TestProject.TempService;
using TestProject.ViewModel;

namespace TestProject
{
    class Program
    {
        private const String host = "https://dm-51.data.aliyun.com";
        private const String path = "/rest/160601/ocr/ocr_idcard.json";
        private const String method = "POST";
        private const String appcode = "4f054ca247be48d1b89f33b9c8be46ff";

        static void Main(string[] args)
        {
            TestAny();
            Console.ReadLine();
        }

        static void TestAny()
        {
            //string inputa = Console.ReadLine();

            //string outputa = TestDatetime("2019-03-29 11:59:59", "2019-03-20 11:59:59");

            //Console.WriteLine(outputa);

            //string a = "";
            //string b = a ?? "1";//!string.IsNullOrEmpty(a) ? a : "1";
            //Console.WriteLine(b);

            //DateTime dtRegisterDate = DateTime.Parse(Console.ReadLine());
            //if (dtRegisterDate > DateTime.Now || dtRegisterDate < DateTime.Now.AddYears(-100))
            //{
            //    Console.WriteLine(1);
            //}
            //if (null == "忘")
            //{
            //    Console.WriteLine("会异常吗？");
            //}
            //else {
            //    Console.WriteLine("不会异常");
            //}

            //string a = "-100002";
            //int aa = int.Parse(a);
            //Console.WriteLine(aa);
            //string b = "-1003AB";
            //int bb;
            //int.TryParse(b, out bb);
            //Console.WriteLine(bb);
            //Console.WriteLine("成功");

            Console.WriteLine(DateTime.Now.ToString("HHmm"));
            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //        //Random random = new Random();
            //        byte[] buffer = Guid.NewGuid().ToByteArray();//生成字节数组
            //        int iRoot = BitConverter.ToInt32(buffer, 0);//利用BitConvert方法把字节数组转换为整数
            //        Random rdmNum = new Random(iRoot);//以这个生成的整数为种子
            //        int m = rdmNum.Next(0, 100);
            //        Console.WriteLine(m);
            //    });
            //}
        }


        static string TestDatetime(string forceExpireDate, string businessExpireDate)
        {
            int dayminus1 = 0;
            int dayminus2 = 0;
            if (!string.IsNullOrEmpty(forceExpireDate))
            {
                dayminus1 = GetDayMinus(DateTime.Parse(forceExpireDate), DateTime.Now);
            }
            if (!string.IsNullOrEmpty(businessExpireDate))
            {
                dayminus2 = GetDayMinus(DateTime.Parse(businessExpireDate), DateTime.Now);
            }
            return dayminus1 > dayminus2 ? dayminus2.ToString() : dayminus1.ToString();
        }
        /// <summary>
        /// 两个时间的差值
        /// </summary>
        /// <param name="dateTime1"></param>
        /// <param name="dateTime2"></param>
        /// <returns></returns>
        public static int GetDayMinus(DateTime dateTime1, DateTime dateTime2)
        {
            TimeSpan ts = dateTime1 - dateTime2;
            if (ts.Days == 0)
            {
                if (dateTime1 < dateTime2)
                {
                    return 1;
                }
            }
            return ts.Days;
        }
        /// <summary>
        /// 小数转换
        /// </summary>
        /// <param name="inputa"></param>
        /// <returns></returns>
        static decimal TestDecimal(string inputa)
        {
            decimal inputdecimal = 0;
            if (!string.IsNullOrWhiteSpace(inputa))
            {
                inputdecimal = decimal.Parse(inputa);
            }
            return Math.Ceiling(inputdecimal);
        }

        /// <summary>
        /// 计算时间
        /// </summary>
        private static void TestTime()
        {
            TempTestService ts = new TempTestService();
            ts.DateDiff();//时间差
            ts.TestJson();//位运算
            CompareService cs = new CompareService();
            cs.DoService();
        }

        /// <summary>
        /// 批量跑续保，测试续保日志
        /// </summary>
        private static void TestReinfo()
        {
            string buz = string.Empty;
            for (int i = 0; i < 20; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    buz = SimulateGet("http://localhost:8057/api/CarInsurance/getreinfo?Agent=102&CanShowExhaustScale=1&CanShowNo=1&CarVin=LMGAC1C81G1002115&ChildAgent=102&CityCode=1&CustKey=test1234567890&Group=1&IsForceRenewal=0&RenewalSource=0&RenewalType=4&ShowAutoMoldCode=1&ShowBaoFei=1&ShowFybc=1&ShowInnerInfo=1&ShowPACheckCode=1&ShowRelation=1&ShowRenewalCarType=1&ShowSanZheJieJiaRi=1&ShowSheBei=1&ShowTransferModel=1&ShowXiuLiChangType=1&TimeFormat=1&SecCode=a4e040a2127d30c7d7e507fb00e0f3f5");
                    Task.Delay(TimeSpan.FromMilliseconds(500));
                });

                Console.WriteLine(buz + ":" + i);
            }
        }

        static string SimulateGet(string strUrl)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var clientResult = client.GetAsync(strUrl).Result;
                    if (clientResult.StatusCode.ToString().Equals("429"))
                    {
                        return "频繁";
                    }
                    if (clientResult.IsSuccessStatusCode)
                    {
                        var a = clientResult.Content.ReadAsStringAsync();
                        return "1";
                    }
                    else
                    {
                        return "0";
                    }
                }
            }
            catch (Exception ex)
            {
                return "2";
            }
        }

        private void Op()
        {
            String querys = "";
            String bodys = "{\"image\":\"图片二进制数据的base64编码\",\"configure\":\"{\\\"side\\\":\\\"face\\\"}\"#身份证正反面类型:face/back}";

            Configure configure = new Configure() { side = "face" };
            IdCardClass idCard = new IdCardClass()
            {
                image = @"/9j/4AAQSkZJRgABAQAAAQABAAD/2wBDAAgGBgcGBQgHBwcJCQgKDBQNDAsLDBkSEw8UHRofHh0aHBwgJC4nICIsIxwcKDcpLDAxNDQ0Hyc5PTgyPC4zNDL/2wBDAQkJCQwLDBgNDRgyIRwhMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjIyMjL/wAARCADkAXUDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD0G/aSVhDGcFu/pTYLOC0GVT5u7EcmpmUfaGb0FOY7l+Vc+9WjObGONxHynGae8akdMU7ll6UByVxjnpTJt1GhV2/e/WkRWK9OKdHwuCvSlVlGQRigCIrhuhFKV3L0xUuctkc1HIfmHGKAFERA5Oc9qiK5bAU8etT7mVc8HFRpISPmABPagPQZ5YA54PvTGUdATmpXOSMDPqKMDjjB9DQBGFB5YY+lNZCTyBjoMUpBZuOfxp4IRfmHWgpWGOFReT1pyIAoJIGehoCb+vf9aANzEDGOmKk1QjKqpljkGjK7FC96RlBcAHGO1Owpk6YYUi0h2AWw2MAUiqAWcUxXYbmxn3p/lkqqg9TzSHYTA2Yxy1KYsYToKf1fBHSnLnBPBz2NAxnljdjHA6kU7ygx28gdxTwmxckj8aRj02HmmSxjLj5dvWm+X/e6+1SnCrvz9aZh29gelIaGlEx+tGEYYAByMEU8JTTtUjp6UANXaflC8ikUAEr79acxXhtucGlJyMjpnimDRHsAZsZx60oUOq7eKlXlyG9KjfO35SABQSRuNsnIHIpFPzHA685PekkLdhn69qbGzb8MMn0piY9MbjhRn17UoVS5+XLU/gnLZx0pSykjHQ8VRmxuIg/zdfSkeNG7DHenEAHoPekK89ccdaDO5Etso7nHvTyu0Y6/hTt3PLZP0p65LZ/nQD1GEKwHv600xgk4Hb0qYA8H3pexODknuaBWIwucZz06YppU5zjjOOakcsDxgU1n2n1x7UAwAABI24qIqrFtwH+NTAjGMdPagDJJHSkBkT2pt5Mwnarc4HY0VoyjkfLx2ooL5izuAuJAT/CKdETjBFMk4uC3oKlJ/iAoBvUQZDbQKUKVYg45pDkjcBwKGDsAwPv0pkhkq+OOaOQwJxzTXIxwcsOaAQ6ZznvQGhKTnGRTWA4x2oLZTggcU0Sbo+CCKAHNkqfl/EUzGR2NNcsV4GPeobi6FtbNLLkqnXCkn9KARMp5PTGelNlb+HbkntXMzeK40vIo4FaSPP75TEwZR2PStaz1SK9Z2iEnygZ3oV/nQFjRG0DHf0PUUw72fjBXuawdQ8RGG68i3iEyR8zkH7g9vU1qWl7bXMCyW0odSOCpoKSLRkEadMe3rSKy7cjp/Kudu/EsQjnMMcr+XuAIiJUsKTR9bk1Fgk0TpuUMjhCo6c9ak1R0SryXY5z0IoVQUZmOc96QpiLCtgnj2NH2fagUMxyehpFokHyRqucqTTxkvlQRgULGBIAvYcinpyG4IJNIYKwVQOhY08orYA7d6Y20yAdcClZyqnjHYe5oELznGMjsaZ5W0+YT16UB2BCjr39KDMD16DvQFmh64I560I2cjHA7+tRZLfNkhakBJ+7gkdaAsJg55PFDRgcdqRlZjjOBSFOASTz/ADpjG5VenWkBI3cAD19Kecdhnmk+8DxgUAIy7mHHbp61HvYAg8j2p5BU/Lk9+aYWByPWgAL5x7dKAwJBHQUn3hkcmnYGR0OaZDHZGQRyOlNKqGwR17Uu0BsHoewpN3HZfeqM5AAcHoAORml3KxBzmoyyq2Sd1AOCCoAGOaCBWPynaOppwL4J79Kb8x4zwOaeqtggn3oEOG7Gc9KX5s49PSmAOAPrmpNxGc4pAMMmTgg4FLkdCOtJlX6kc9RQV4+tOwC444PWmruywBpSeM8gmgEEe5oEQu5Bx6UUOi7uhopDuXPlNw+f7ooLhflPfpTT/r3PfaKVmEnygcihDnuOQMPlP4UbSG254pRlh2BFGPMHJ5FMlmRdK5vWQSMCw4HtU2nqwTB3YJ43EVdNtC4YsgLE85pY4I4wdigH2q3JWsZKm1K5Wu9sURG5hu/ujJqnZARTJvQru4QZ/U1sSKsqcj61TFrChDJEAy8g96FLSw5QfNctD733veonZVDFiu3rknFKG3HcQeRwKrXcEd5aSQyplG4K5qLF8xzUdlFqurXt59olSEBY0dHwGx15+uau6PAbrQfLlmlYSFl3lvmxuOOa0zpsM1qtn5Ci2C42YwMVJ9itobT7OFCRAbdo4AFMq553eWfk6ksBt7WLZJzndh1wTknvXS+HrFRaG8a3ihaQYCxkgbfXFaK+F9HkBZrUP7kmrUOjWNrFJHBEY0kG1xnIIpFRZxdoY0uIdt1IPNlkaSMt8oj55x0rQ8JusjSSyyguG8iJM/wjv+NdLNpdnNapA9vGY1wFHoB0oGj2iXiXghQTouA+O1ItIn2hmHBwOoHepR8zLySB27ikG1ue/wDOnxlTuxwf51JrcXZvYsG6elKDtwhzj1pqnCk9Mnp607zcsBx/hQA8cqzEfSoiyBgCc47UZLgd8nt2FBiLK2foKQxBMmCf6Uu1ZBtApuxVIU9BTypA3KaAEXKfJjilIWLBx19KcCJFwAcihRjKsaYAWJ+YDt3prFShJOOc0gJOUxikWPaSGbOaAsPO0ZIpDyTnP0FISxA429smnIqryD270BsMGTyR04IpQgIINKeDuOTn2oO7PHA7gUEsjYqPu9uuKa/yjJIHtinvMsanOOK4LxP4xNtK1tZEDA+Z6ohux0uqa9Z6ZCXlkVWHRR1rhNU8fXDuVtRsX3GSa5xodQ1MmZvMfcepq/beErudQfu57GldE6sVfGmpgnMpya0LLx3eLIqykMO4aqp8EXYIywIobwbcqpCnn3oFys7vTfE1pqCj5zG/cMeK3opPMQkPwa8k/wCEe1G2Q7HIPYVpaJ4rubGcW14GKDhs9RQS01uenoTjBp5cdPz4qrZ3UdzCsiMGRhkEVZPzCmA0jkcCjkEccUuMcdqCcdaBAxx1HJprEqnY0j8YIqNmIBAb60AOQnb0opsZGDg/nRRcaLUjbZmxnpQAwfePu96H/wBc/P8ADSIQvDGhBLclPA3A0fKPmHPr71H0fBBINP37egOM0yALDOVH1p4YkZUHFZ0uoLDO6bcgY4HrUlvqKtHkAjPam4u1xKcW7XLhOOQM+tRPxJnPB9qr3N55Me8HKkgHPaqqXxYqCMZOPwzTUXa5MppOxoEkYI6Z70AYJ5GCe1Vy3zYwSD61Bql+2naXNcBQTGpYD1pDWpoByrFQBSNvYhdvB61w0PjS5NyUMMRAdRxnvXdCUeXnHJ6Url2HoF2sCOlNbYU6ndimISzEcZxT2aNFBbp3oZcWIdmPvUhBA4I/Oqt5dpA4CjOeec8flUdldfaWOQAOoI7/AJ0crtcaqLm5S4RtHPFIANvQk0SuyRFgdwArN/tQllUxsAR2Pekot7GjqKOjNQnMeDigBQ3Q5qtPcCG2MrEYC5JY8D61jvr9ykgDWS5MRckS8EDrg1JpdHSCTpgdO1ALt0/wqnYXiXFvFKyFCyg7SentV4SjgAc4pDGmJ8Zz36etKCyH5st7+lSpkjkdKcu1gR+dMm5E42YdT9aHwQJAealUDBwKjChWKOMZ5FA0xjlsBl/GkYAEMBkmnAZDIeBSJwCvIHqaBjt24AN97sKiKtnJGcHrTmix908elNUsvXpQIAWHqD796dvwMHAFPDAjHT+dMlUBcjj6U0Q2cl401saXYGOIhZpRgY9K830jT31O682bJQHqe9XvGF297r7xc4VtgBNbmiWYhijUDnFTOXKiYLmkbFlp8aIoAx+FbkMAVRUVtGAgyK0FUBcVjE6NiEQKeQtMktwenWrqjjAFIQOfatSWzFuLUk5xk1x/iLRjIv2iFSJF6j1r0CRdwOKyLqHJYEDB9am9mNx5kYHgrXmE5064Y8/cz2NeiIeARjGK8gvYP7M8QwTRggM44/GvXLU74Ub1ANao5GrOxOMjk0ck0jYJweKTt1pkjWTIPOKj29FGPrU3Veo96aBk84oERruJPSipO56flRSLRI5IuG6fdpxBIBJGfamuf3zZxwvFORiR9PaqRM9xcqV680R/MCGJzR9w9+falw23cAc0EmfdQ7JnIiLK4A445pljaGI5liIB9WzWi67hnH5moj83GM+vPFVd2sZ8qTuV7uLzIxGqZBPXPSqy2kiSRkoTz3PCitBRztYZPbmlYDJG3P401KysTKN3djUGMhiMdsVm60N1g4aQopPJEe8n2xWp0+UhdvbmkCZGGxweopFo4IaRLawfaW3C5lcGKMQA8AgDPpxXeQB2QKwGakBJBAGaRRhsng9qRV7jiNoDjt14pn+sDYGOelIz7hggnNSRouMjg9GpFp9itdWPnTJ8oZec5NMt7RbaQLsXb65/TFW2eTIVWBKnr7U8KVyGUE5zmnzO1ilBc1yC4iWVHVWAOMfSs0aZOWyCoCnPXrW5tVuqgbhTQsfTODjtUqTRcoRlqzOusJZuWhLEL9wDO72rmLizvL6GGBLcIbfl2I2hh3Qe3Nd1jcSoAIFMEaqemCex6UrmhR0wpLbo5iaM4wUfqMVpxhVAJGABTAsYbBGT3xUmF3ADpg0h3FeRcAAjk0MMgBfvdqbhcnim8IeB8vcUBYlALDO4/ShjuCv6Gm7iG4HB/nQpOWXb1560CI5cq4Yj8KR03fMOtTKA0ZBGD0NRqCBk/cHHvQVciBdeoyKlRg3PNS712jbz9KZtIbPTNAmxjqAMjGRTZPuHkVMw+XHrUVw21PfpTIZ47qNoZvF0oHTfmutsI1iUE9BVO+tNniWR87gyZFaUcGcBunWsqurNKKsjVt5UcDA4q4Dms1Io9nLFfxqSKNkbdHISvoeaEU7mlt4xSkfLUcTlhnuKhlLuDliB7VVxWY6RtozVKYJLk96kjktySqSAsOvzUjIpPy0nqCOK8R2TfabaUdPMGa9Gsgfssf8AuiuZ1S3WQwCQ4XzRk11NvtEK7TxjAq47GM17xKR60w9KeRUUi5BqjNoeDxyeBTGJ3CoXcRlRk5oRy/XrjtQJokBY54NFMEmTRQBab/j4br92lAK/T60j/wCvbjJ20jDJGcAUIJbj2IxkdRSq7MMAjn2pFAUY/pSAkNjnBpkkbNskIbGPU00kEhlGfw7Vn6kX3yBCuPl6npzUtq7ESBiGO7oOgrTl0uYc/vWLfUAnv0wKQsh6jJ6dKrXPmNFsi49SBzVay88zNy2AxzletHLpcTnrY0gOisv6U7LbccflTchuMDior1Zns3Fu/lSYOHxnFSaJEocRj52AGRiiSYMOT8vWuPM9y2k2DTTTPAcicx53HrjOO1MguPtOlXDTi4ZbeVkiy7KzZxgHH1pFWOwTb1LY9Ke9wc/Kc54auPk06+jgtYdskyKGeTdMV+Y9s9a39JmglsI2UELjBVjkgjg0FI0lYRkMw56Glkn5AUHcP5Vl38jtsRd2Aw9elLpqkdXJc5wcnmny6XBVLS5TZgVcZbluxNKrKHYEjHWqF7dGCwmePLPGjMuBnBxWBotxKbm2lm85XnUkFpNwc4zyO1ZnRc64ugB5x6EVC0ysdokV/bPNLI22IsTwOeaw0XmFjGwG/wC8FxTjG5EqnKzeEm3gD8D3pokQ55wc9M1S1IE2Eg+0CFepfuB3rk55bmFM232j7JNKkaK7kMeuSCegPFSbcx3alccMfzpfMUcEj8awdDcqJ4DvDxsMoz7wM9MH0qd9xnn+VG5/ibHaqjG5E58qNgMCh5PHpTw+CCB1HU1TtP8Aj1jPTKVN1VfUVL3Lj7yHsxDbs5HcU/du5pnbpSgYH8qBschIzzThluQ35im5wvB5PalB2qFoIYE56/Sql22YnAPQfrVt2wuKqSA4IHQ8UMFucUYiurSuxJU4xWu6mSILH1qvqEXlzZHY1fsVDRgmsZLU6UktipJpLXVm0LyMpbncDyMVcs7P+z7VIg5cKMZPU1oKAMcVDctsXJ/CnayJ3Y6FvlOeDSMnmLg0y3DMpNSxth8EU1sNoz7XRbe1eZowd0v3s+lTwweQx7itEAYqKXGDQ1clGRfRCcbD6g1u2S4t1FZJUNcKPWtyBcIBVRM6gpHOMVGygmpiMVGQM4zitDEqyWwLbj1NOWMqBxn1qx3pD15HFBJCU5+6DRTwwBPOKKQ7Ikf/AFx44xzSrnJyBjPFK3Nww5+7Squ1jjof0poUtxF+8QST6UuwNzjpTshqQAjg9PWmQVXsobhi0iZanR2kVvu2DqeQKsH/AGaaOfvU7sXKr7EUkCzKByPYGiPT4ozvGQevU1MCf4RxT9m4fMTSux8ieowphvlAGaHhR4zvOQRijcR8q0BcjJNAWMt9GtTaxW8fmoIT8jxtginpokEdokBU+WriTk8k5zknvWiXG3CjJoKkrljkCi47Gbe6VBcsjl5VkHAaJsEj0qe3so7WKOGCEKqjgtyatMwAGwc57UjKxcFmwPQUXKSGGIGTDlVBFRR28KRlF3MAc5FWUVA52jJ9RS4bcRuCjrilctJETRqYseXlW4YGqNvosFpOskZY7AQis2QmfQVotjuST6UzG4/c6etK5aQjRpIpVuQR+lIYY3K5AO05GPWpAMDnbz7UuT/TpSuVyplW+sI7+28iUvtJByhwQc5FVG0KAwtG8k0gJypd8lSO4rVJx+VBbpzQFihYWEVmH2Fy7nLO5yWNW/s8ZJO0ZPU+tKw3AkU5QNo9D2ouDSERFjUKowBwAKcBTQpyTngfzpPOwBgZBNA9tiTAHXoOtLn/AOtTdxx9KQZ60AOJ7nkmno+F55NRMCe/WnovPHagTH4AHfmoCDvbjNWcmoyPm5X8aCDB1i2JxIBn1qGybAANbl5CJLdgBWHCu1se9RM1pu+hqx9c5qvdoWdWB4Hanq2EzmoHuFz8x/CpuaLcIYZRkmYnJ6YqSGJ0bDSM43Zyf5VEt0gGMVItyhHJxQkN3ReBGKgnPHFEcgYZBqNySetUQNtojJcg9hWwOBVGxX7zGr27irWxhN3YZphzn1p2c9KTI7HmmiGhrDjkEUn0PHvTznFM/Q0ySNvvfdzRUmSCcGigdhWGbhuv3acWI46jvTDj7Q2TjinHPY8UIUtxQN5yDTmYgeoHXFIpHcYppbnjn2pkEZljViN3bOKUTLIuV6HvWbcqPtEhJGdoI3VNYAeTlWU8DIFW46XM41Hexcz5Y3M2PrQLgM4T/JqvqORCv3+oI2VUsyr3IJlK9e/Xmko6XHKdpcpsqMfdqrdXcdvGZpW2Rr95qsODt5rI1p/KsHfzGjIYdBnf22496g0HNr1jCpPmZAYoAFJJI9KkbU4A6CSQJvXcFbj6158EnhmeSAvAySSFQTlgOByO1deymO6t1ml81ZBsEZQE7u7e3vTGacerWL/u47mJj0CBhmkudQggB86QcAHYvUAnArG0+CFNVvtsagiRcEKAR8o71h66t4l/LblkCzDezIDuIB4GT/SkUdwurWoikYTIViOH5+6feoDrtixUicOThfl9/wD9Vcxo8gNheyMsMDx/u97LxjAPPPvWBNKZEt9qpLtUAkJtA6nHX2oKuelHU7YQpL5yBG+67HANQ22tWN2WEd0hO7btLYOfYd65tYZ5dCgmjRHe3DYiZM88jGKraVG97ILeNrRhEQ7v5eGDZzilYq52s2pW9sjvJIq7Rk+v5U6DUbe4VWjmVgwyOc1zWt2gmuJFVYwfszSM2wEsR70aDbxx3BQ+W5SFCGVApUkdDRYaeptyeINOUlTcpnpjnipv7Utjam635hHBbHSua1dLqO9gkhuYGw7FFEY4+U+/NX5JjLoiSmZg+R9xcEnptIpWHzF+PXbF5JF+0ohQ4IJ65qeXUYIDGHkwZfuD1rzWRZLe6cK8aYkPymXP8Q9q6DVlnee0cqiK0ZBZGHzHGcc8YosLmOmj1q0mVdswzISFX1qCXW7SH5mlVRu2EZ5U1y2jCZVtkinCq7tvUBT057UzWJf3kkHmK7CYAkYztK9KLBzaHaWuq21zFI8cgKx5B/DvSf25YZ5uk5/SsHw1IFsrgybVVWxubHTHc1OZJd3GqWI5zjyx/jTsO51EMqTxrJGdytyCO9TAHJ7YqnaurxKyPvHADKeKtIDu6Y/GkBJkduaRjjvRkgkEgUwkd2/KmSxSBtxWBdr9nuj6NW1LKFXJ4ArgdR8Qm51mW2jPyxjilLYcXZnTxyBlxVeSI53Bcmsyz1EAgnODW1FPHIAa507s6U7EImwv+qOfpTlUzD5kwPerXydaPNjXvVjcxIl8tKr3V0IkJJ6U25vAAQtYl9cO8Erk8IpP6UkyJdzY0LXob6SW3+66HA9xXRhsivEtGv5La/WdSQd2T9K9f068S8tUlU5yOlbpHLfUusTjg4oU+o4pM9sUE560yWOOeoPHpSUA8UN0oERkHPBopwbkiigBXyLk8ZG2l+XdkHFDcXLf7tOI4GcGhCluAL9TgimsADnBBPenbVPQ9KDuxwQcUyRgRS3Y8dTSBNpxtGB6UEHqVGfalIz2YfSgRICrpg/rTPLUfdC5pFfHO79KeTxkFee5oGPyccrn8ap3FrDcshlUnY25fY+tWFfHXGOnFZ2tTSQWLyxymLYNzFV3Ej6UDGjQ7FEkCxAmT7zHknnP86JNPtZZS8qAsU2Zyema5uHVNVMhFxNdQxlwqMbYYwe5qbxBq91psUccUv7zK7nZDzz2xxQOxs/2LYRSCWOIK+4HIc9akm0izvZluJ4w8gTaMscAVz2j+Ibi71KS2ndWBPyhEbI49+1dFqd7PYac00MJlZRyM4x70XH1G22k2lu8scUShJPmdTyM/wCRSzabaNIzmJDI4A6dAPT86mW5WGy+0zvsBAZienNcUdfuTI7G9l80OdoXbtxnj36Uizr/AOxbVreK3+fy0OQoYjd9alXSLNGiYW6q8ZyhXj/IqbT7lLm3WYOGBH3h0q4ucMSBz/KlcpIqTWUcqujoCXUrkeneiKyggTZGigMAG4649atKQBknB9KbnqfWkXYpHS7In/j2jJ/3RSmwttoVYVAVgwAGMH1q0G4we1GPmHTBpDSRnz6RZ3RQzW6MVbcDjvUsum29xs82IN5ZO0EcCrYHynnoc0pHI9KLiaM/+yrVbpJ0iUOg2rjgflUFxo1jKuHtkPOfQ/nWqwNNKnHTI9utFxpIz7LSrKAMEiX5uozkEfSrQ06xA5t4f++BUi5wW5x6r/WpFJIHII9KYrCRxLGgSJFRfQDAFTBfl65IoDY6jtzVa5vFt03PkZoEWWYKOBzUTSkcnCisK58QRqSI8Z9SawdV8RyRoQZOW7ChMlqxp+JdbW1tnijkzIRyBXnehubnW3Ynsabf3sk7NuYkmneHVeG8N2RmIHY3tnvRP4SU7yOra1kT5k6HtU8EjKR87Ka14YleMdwRQbBScgVyO51lZWeQf8fGPwpRheS7OaspagdVqwlsvpT1DQzRFJMemFqprkHk6Jcnp8tdGsAUcVheKWC6TKvqKpITdzzeNvLI9q6rQfEb2LCMn92Tz7VyJYgE460+OUjgNgV0rY43uez22s28+F3YJGa0A6sRtIINeRaVqVxHIkSnepPTuK9A0O7aaOUHPykUtnYb2Og3cU5TntUEZ3Y6mph1qiRrKCxopwPJ6UUANmbbOSR/DTC4ODnAp0ozO3GcLVRlcvgZxQhT3LKytnAPy571Y7dqgijwoHapuowAaaJGdD0o6dznvSkY9eKXDY60CGn2b6cU5eVIyPxpcHuKUHAORTDYbjnlRWfrto93pVxDEgaRkwBnH61oAKT97BHvS7SzcHNIZxzeHrxfKZbcfLIrH/SXbAB9DxV3XdB+325ki3PMMbFZuOvOAeM102CTt4xSyrhAAPyoKOL0Lw+8eoG4mttijlWYgHI6fd7V0t5ate20sKkcqRk+tXCESPAxmlVQkeehxmgpFZINyLCwBCgZ9CawNS0HdcOlpasGmy7SibAU+uK6iIApuzgnqRSJgsxcEnPpSKSGW0BggjhJBwoBPrip9mzAB70wECVsHGB3FDk46nP15qS0PcYXGc+1QjeeAuMde1SRyx7eOKGw5HFBSGFNwJA5Hf1qTaNqnuPWmpJ1Q9e1OChsjHOKAYhBDnkYNMA6qe3cVIYwU6fMKbtyARgHtSC5Gd3qMU9Q+BkAk8UNkEZXJ7U8k8YHH0phcaRgnjDfoaiYENlhg+o7VO0jKORnmotyt0GGoDUk5EZIO6uW8U3rW8UYwQSDjFdIzIuN/H8q4Tx9cMrWpQ8fN/SplsFjmLjUiVxtO7Oc1l3F200hck7vrWtdxre2X2mAYdV+YVz5XB5pwtYym3ccWzya7rwbYxT6RJuUNvdga4NY2kIUHNek+DYZLWwKSjaxbcAfQ0SY4ot24k0uQQzEtbE/JJ/d9jW1Em4AjBBp726TRsrqGUjkGs4CbSycBpbb9U/+tWbRqmanlcU9YqbbXMdxGHQgg9xTprqKEbpHCj3osO4MuAc1zmt7HYpIMpjmtVrue5yLaIgf89JBgflWDqcHkTHe7SSP1JP8qmb00CLON1LSfKLSW4LJ3XuKyoonmdUQHdnAHrXaOhJ46E1BPYQwB7mNQrEdvWinVb0ZEoFKzgS0GxWHnEct1xXaeF0/cylu5GK4yziZ5wWxwfzruPDQCRS4PAaqi7yIkrI6BQu7Ap7AYoydvANKMsO9bmIgbPrRSA4J4ooGmK4zcn02004/yKdJ/wAfB/3ahlLFgBkChBMnXkY7fSlGeeeKavCgkHFPxxk59qZI0t65P4U5RnHXFRjJJB5/CpQAy8UAhCpHQ01lxy3PrUgDDt+tNJ3cdzQAL5eB8o5qSNApOOM1GQDwR0pwBVetIfUdtbeSORSK25yWB9qehJWmg4c5BxQUMkKs4GfrTZiu0AcnNOzmQ8GklJO3OAPemNCnGzhT070yI/ux83btTz8y4yT9KiBKHaenoBUstAxZG3dj15p6yqeOn+e9IHXp39KYVVs4I/pSLS7jmRWOe/qKaCyHHBH14ppBU5559OpqUfMuGAz2FIsRuzqfqakBVXVh34pigkFGx+FKvzxlMdO9AMlxgnBwD2pMeXzgkHrTUfK4289DSiXadrde2KZGooJ3EtwO2aV5QB+ppcA8H6mmnaMdPWgCIuWPToaaSNvTvTy44wO/NN3ZHQcmkWMbg8HPqDXEeOLZpxBsRiRngV3DDLHgVE0SO2HAb6ihq4jya0823X5UIfpgjg1XvdKlluwYIWxIM4A4B716+LWAniMcf7NOWBRkKigD0FTGLRMlc830nQhbKZJU3SHp6LXWaPGfNYEY4rdCDlRH+lTBBn5QMj0pcjve4Xsiu/ypwDmovKZyNwyOtXVj6nHfvUoCq3oKuxNzIk0tQ5eGR4S33gnQ1LDplvE28ozt/ekOTWmSuOox9aVsBOfwp8qFcplADjGfSuY1mJ3uvuHiuuyTkHb6ijyhIMHG7rUzhzKwozaPP3tpQAuw9fSm6hby/YVQRk7m9K9AEAYdRuFOMAx0Ge1QqKTvcp1GzzCDT5o40ZVYsTyuK67w3EwgkD5Ulq3zGpHA+b0pcDHyjmqjTs73JlUurBkKMEmm4+fuRTuXX0IoySDzzWxiG0bjxmiokflgTyKKQ0SyAG5OScbaadpI3dBTpB/pBOf4aQKWJNCHPcOCMgnPanZ2jqfb2pCuCOcn+tO74PXvTZPUd8pUUEH1NGR0zxSbgDSQ2hd2F6HNKArZJODTWdemaT5Qp5xTBCABX+9kZ6U9mOfu8fWo0OGxnNOZiG7YoAlLYXoeacmAuPSmMwYDnpzUatySzYz2osMkIwx+YCmyoGX+99aTCjOBnPvUavkYzkDjFFikwDFeM5A6KopxIPBGP9mjfHjByD6CmbTnJbj071LLQhRScKfbaKTYeOM9s9qVyoXC4GOeKQzrt+Uhm9qRomPTAHXr3NJ91h5YyPWoxIhYFj8w6jNKXGGCtgDkE9qBkjcMHJ605mwQy9KhR1ZTlwwpEuI2zGDzSAmYbPnVj75pRtcep/lUAuI4m2yMBnoD1pWkCDcCBmgCcRHBweKDFycntUMdyGOAw4oM+eC3JphqSEKCO5HNJncowByajeVUyzsqqBjJOKRZ4m2kNlR/F2pBcm4yc9PWoiCOQPl9c037XG2VWRPbmkN1FHhGkUH+6TQJPqPUfL8zU4L1x1qGa6jgiMjFVT1J4pLe4iuI98MyuvqDmmG5KCydDj3pfMYHpjPrTY5os7XYFieA3Wkmu7W1cCaeOLd91ZGHNBLRIrGheScgk+9KZY2Gd3XoRUAliaQhZAzDggdRTJLzCMIeBmonYuo3dunFU5NRsYrlIJLtVlzjYXGfyq1JLFGhZ32oO5/nQSwOMbh2ojm3Bnzz6VA9xGE84sogxncW4+tMtdRsLiUxw3ETuwztVwaYrFyM87wMDpmpQxznBqGW7hi2+bIFTsTxzUnnknAHGODSFsK2c7wOnamvnG8Y96eN1RsSH2luGpolhjHzA5z196ZIRgMD07U4qFOD0PSmjCyYA4NMQg6nANFPwysdvQ0Uik7CyYNxz/d4oUYA9aSY/wCkY9VpzMwXIUZ7UIJbiZAyc+1NYdNvUdKcBgA5wfSm5Occc0xFGaZ1lBYMI0P/AH0T0p8EjrIVIJRuQ3ofSn3FuZZFYSFAnQdiadbWhh35kLb+x9aq6sZcsuYyJJZPMJxnLkZIPrV+J2j08lnOVzyfWpf7PUBwXZgefpR9kcQOjTEnOckZxVOSZEYSTuY0VzNFKr7ydzDOD1rRup5t8YVTgjOPenNpmXRg445JI5/+tVma3ErId2CPTrTco3uJQmkyjbXMnnIpDEsCG5qG7eT7U2I8/KPvfzrSitPKcsCTgYGRTri3SQEsAzdjjpS5kmVyScdTPt5nSzcOrnqeOPyqsJmKBf3g5+bB3HpxWrDa+VAYs4zzUbWMIUhIwG9cfrT5oh7OVkSWUivbRvycDBz1qwzj02qahtlWGMKCSB1JqbcCCM8GspPU7IbalS9gS5tXhk3bG4IU4Jrj/D8RtfEM6XCTwOykQxM5ZSvc59a7K8t3uICkUnlSMMBwMkVlWWhzRX/229vDcTopVPl2hR34qSzB8U2ey5juIopxExDXE8bn5R7Cr2ruLk6TbB2NtcSDdz95QvANX9Q0K7vJ5UN/ItpL1iCDOPTPpU9/oP2y3t4oZTbvbsGhkAztOMUBYzdEiWHVtTsUyLZdjKhJwu5eayksl07xZAZIJYLbdtgIcsrv7+ldRp2gvZC5aa5eae4+/JgDtgYqCLw5ILuG4vL6S5WBspGwCgH1OOpoFYzvEiWT3GDC9xqUybYo1Jyvv7VZurG/fwt9jDh7nylQktgE9+atXXhyeXVHvoL5oGdAhxGG6fWtV7GaWx+zi4ZZVUAzBRk0DOd8NvDb3E9o1p9mu1VS2H3Bl7HNQ3cE8HjKwlkuXbzWcBD91FA4AFdDpmhQ2E0sxmee5k+/JIckjsKluNFjn1C1vGkYNAW2qOjZoF0Oc8TRyG6spZ4ZJrBd3mpHzg9iRR4WVbrS7zcjfYZJWESP/c710eq6adRt/szSvChOXMfUr6fjUkVlHa2YigULGo2qo7CgaTuchpWm291rL3ltCI7W2cxpt/jbuT7Co9bsprbU7jUbi0jurQKvBb5kA7gV1WmaUmnW4t4GLDezkt6k5qte6CNRuWe5upjDkH7ODhDj170A1oY2uMLltJhODbSzLlegYYyAaZY7LPXdThiTZAsaSbVHANbt/oUd/aJGXaJ42DoydVI9KbpmhLZCd3lknlmP7x5OuBwPwoDU5bT9VvI72PV72FXhupPKicP80angYH8609eltZJhGbEXWoTIVjQjOB6n0FWYPC1rHcIfOmeCNt6QsfkU1LfeHjcah9uivJ4ZfLCERkcignUp3Fxc6F4YjTfunRAgPUbjwPyzVfQ7i40+4/s66iQTyr5plU53nPOa3pdKS50v7LdF5cgAvnnPY/Wq1jokFlc+aZpJp2G3zJGzhfQUyWc48Mc2h6xdTorXIuHxIeSMEYwa3NZs/t/hxWldwEi3sFbG47e9TT+FbSaeSVpZ0ikYPJEjfIx9xWxJYpNZNA4O102EqexGKZNzM0RFm8NWUcmGUwLkNyDxWBp9qdP8Ubp7eFXuAy2zQ8BQOvFdZBpkUemfYVdvLVfLBzhgPrVSw8PW1ndG4Z55pgNqNK+7aPagm5z2p3V9favPLEsLQaaATFIxAZsZzXYaZd/2hpsN0q7fMQMB6VQufDNjeXLTM0sbPxII3IDj3rZtYI7ZBDEoVFHyqOwoY9yYFnjByKYUMgySc0vRyB0PNGNr45+akJjThkweKWMhowO+KY4CSqex60/cEbdng9aYAsnJGOlFMclmyg4ooC7JHwbtV9VNKRnnJHYCllizOGIyMEfSonAyCCwx6dKSKluOUqd3PI45pCwUEcEjtinIDkluR6U0kZ449aBDEZS2OD61PgZxxUIVcE5wTTwq4J4oGxXUsBzwaQDPPOaUDpg4+lBIZQM8dKBWQwhFPHPtmnjOARxTI4dm7B60/BxjOfc0IVgI9yc0wls4xg/XrTixyMg5pTtwC3FMBhbpwRQzDI5/KnSN6jAFNYjHA69zQUhMjdg5AoCg7gOP6UDbuGDz6j+lKIyr5PTHQVJohFVgB1K5605lGTkZI5GO1CuHQAdj1NOb5c5ztx+dItCBlwcDtzmgFjxt/wDr0EgYfbwRS7zwcf40i7DuW6nHanqFYYbrjrUO8sMgd+lKAW+8xNAmiZDkEDnHBNIxHAUc5pMhD8p5x+dJjaSz8k9aBWJNoKhcY96bkqcEFsUhcqvJ+btTCeAD980AkPLqoZj1NNI+6Px6UHqqnkDmjBLMw4AoHYbuXcxPBFMO7yuVxu5zUmF8rDjk0OxVlQDPFMCN1IULnINOIKpwC3uO1AJZyR27UAEnPQ+xoExpwEyRyfyNRBQ7ZweO1KWJfHP5cU/fxtwM0yWIxIBwN1RR4J3MMEnqKlEfPJPH60Fj0HPvTM2DldmBwT6U7au0ZH4ikC87sYz0pxdQMZxn0pkCIoIJxuFKNvmHnHA61IsUZTgflTQnzn+L60CtYVjjGQD9KY5AIbaQBxTyACv8NDg7DyCKAY1lUDI4x70khXbwf1pSxZP9X2pIwu0AjtQLcQhWTjHtQNpQ569KFKAkHFLHgM3Hf0pDHJ09x60UpwOfWigaLwUFc+lVrhQpwOhoopIuRCOBwabIoHvx3oopmYgA44xTwOTRRTBkmOM+1MPUmiigBu8kAml3HK89aKKQD2+UAimsBjOOSOtFFADWUBCcU0ruU5zRRTKiI38B75p//Lxs7YooqWaoYzH5/Y8VNjehJoopFjEGQrHrSLwuQO9FFIY4cZAprMQePSiigFuPQY56kHvSFyXK9l6CiigYN95aG/1hzzgd6KKBCxgMrMetIxKR/KaKKAHn5tqnpSqAC30oopiZCfuse9NLHywPWiigCMfLnFLgHr60UU0Sx28/d4xTl4YmiimQxWcr0xTABkHFFFCM3uSuMJkcH2oiA2Z70UUDFPLjPT0oKK3UUUUCQ5BgAUgGCaKKRdgCjcW7mlI5BoooCwdetFFFIo//2Q==",
                configure = "{\"side\":\"face\"}"
            };
            bodys = idCard.ToJson();

            String url = host + path;
            HttpWebRequest httpRequest = null;
            HttpWebResponse httpResponse = null;

            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }

            if (host.Contains("https://"))
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
            }
            else
            {
                httpRequest = (HttpWebRequest)WebRequest.Create(url);
            }
            httpRequest.Method = method;
            httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
            //根据API的要求，定义相对应的Content-Type
            httpRequest.ContentType = "application/json; charset=UTF-8";
            if (0 < bodys.Length)
            {
                byte[] data = Encoding.UTF8.GetBytes(bodys);
                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            try
            {
                httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            }
            catch (WebException ex)
            {
                httpResponse = (HttpWebResponse)ex.Response;
            }

            Console.WriteLine(httpResponse.StatusCode);
            Console.WriteLine(httpResponse.Method);
            Console.WriteLine(httpResponse.Headers);
            Stream st = httpResponse.GetResponseStream();
            StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine("\n");
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        private class IdCardClass
        {
            //{\"image\":\"图片二进制数据的base64编码\",\"configure\":\"{\\\"side\\\":\\\"face\\\"}\"#身份证正反面类型:face/back}
            public string image { get; set; }
            public string configure { get; set; }
        }
        public class Configure
        {
            public string side { get; set; }
        }
    }
}
