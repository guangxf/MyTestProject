using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.TempService
{
    public class TestOutRef
    {
        public void Method1(ref int i) { i = 10; }
        public void Method2(int i) { i = 20; }
        public void Method3(out int i) { i = 30; }

        public void Test() {
            int i=0;
            Method1(ref i);//int i;报错
            Console.WriteLine(i);

            Method2(i);
            Console.WriteLine(i);

            Method3(out i);
            Console.WriteLine(i);

            int j; //此处区别于ref，不报错
            Method3(out i);
            Console.WriteLine(i);
        }
    }
}
