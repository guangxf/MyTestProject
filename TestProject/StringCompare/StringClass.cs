using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.StringCompare
{
    public class StringClass
    {
        public StringClass() { }

        public void Accumulation(long fortimes, string content)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string str = string.Empty;
            for (int i = 0; i < fortimes; i++)
            {
                str += content;
            }
            sw.Stop();
            Console.WriteLine("str++用时：" + sw.ElapsedMilliseconds);
        }
    }
}
