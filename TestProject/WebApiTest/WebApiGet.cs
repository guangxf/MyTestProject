using ServiceStack;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestProject.HelpService;

namespace TestProject.WebApiTest
{
    public static class WebApiGet
    {
        public static void TestGetReInfo()
        {
            for (int i = 20; i < 30; i++)
            {
                //Task.Factory.StartNew(() => new
                //{
                //    WebApiGet.Task2Foreach(1)
                //});
                for (int j = 0; j < 10; j++)
                {
                    System.Threading.Thread.Sleep(100);

                    byte[] buffer = Guid.NewGuid().ToByteArray();//生成字节数组
                    int iRoot = BitConverter.ToInt32(buffer, 0);//利用BitConvert方法把字节数组转换为整数
                    Random rdmNum = new Random(iRoot);//以这个生成的整数为种子
                    int ii = rdmNum.Next(10000, 99999);
                    string url = string.Format(@"http://192.168.4.239:8050/api/CarInsurance/getreinfo?Agent={0}&ChildAgent={0}&CityCode=1&CustKey=test12345678&Group=1&LicenseNo=京{1}&RenewalCarType=0&RenewalType=4&TimeFormat=1&SecCode=6f0962a2eb83e6889dc80e70bb688ac1", i, ii);
                    string result = HttpService.SimulateGet(url);
                    Console.WriteLine(string.Format("{2}代理人id{0}，返回{1}", i, result, DateTime.Now));
                }
            }


        }

        public static void Task2Foreach(int i)
        {

            
        }
        public static SqlDataReader GetTable(string sql)
        {
            string strconn = "server=192.168.5.42;Charset=utf8;port=4005;user id=bihu;password=123456;database=bihumanbu_qa";
            SqlConnection sqlConnection = new SqlConnection(strconn);
            try
            {
                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {
                    return cmd.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlConnection.Close();
            }
            return null;
        }

        ///<summary>
        ///利用反射和泛型将SqlDataReader转换成List模型
        ///</summary>
        ///<param name="sql">查询sql语句</param>
        ///<returns></returns>

        //public static IList<T> ExecuteToList<T>(string sql) where T : new()

        //{
        //    IList<T> list;

        //    Type type = typeof(T);

        //    string tempName = string.Empty;

        //    using (SqlDataReader reader = ExecuteReader(sql))
        //    {
        //        if (reader.HasRows)
        //        {
        //            list = new List<T>();
        //            while (reader.Read())
        //            {
        //                T t = new T();

        //                PropertyInfo[] propertys = t.GetType().GetProperties();

        //                foreach (PropertyInfo pi in propertys)
        //                {
        //                    tempName = pi.Name;

        //                    if (readerExists(reader, tempName))
        //                    {
        //                        if (!pi.CanWrite)
        //                        {
        //                            continue;
        //                        }
        //                        var value = reader[tempName];

        //                        if (value != DBNull.Value)
        //                        {
        //                            pi.SetValue(t, value, null);
        //                        }

        //                    }

        //                }

        //                list.Add(t);

        //            }
        //            return list;
        //        }
        //    }
        //    return null;
        //}
    }
}
