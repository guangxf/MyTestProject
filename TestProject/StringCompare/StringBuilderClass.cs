using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.StringCompare
{
    public class StringBuilderClass
    {
        public void Accumulation(long fortimes, string content)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            StringBuilder sb = new StringBuilder(2);
            for (int i = 0; i < fortimes; i++) {
                sb.Append(content);
            }
            sw.Stop();
            Console.WriteLine("stringbuilder用时：" + sw.ElapsedTicks);
        }
    }
}
