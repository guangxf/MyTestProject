using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.ViewModel
{
    public class JsonModel
    {
        public class ReMsg
        {
            /// <summary>
            /// 错误码
            /// </summary>
            public int ErrCode { get; set; }
            /// <summary>
            /// 错误描述
            /// </summary>
            public string ErrMsg { get; set; }
            /// <summary>
            /// 机器人接口版本号
            /// </summary>
            public string Version { get; set; }
        }
    }
}
