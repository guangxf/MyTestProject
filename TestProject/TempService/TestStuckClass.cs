using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.TempService
{
    public class TestStuckClass
    {
        public struct TestStruck
        {
            public int Num;
        }

        public class TestClass
        {
            public int Num;
        }

        public void Test()
        {
            TestStruck testStruck1 = new TestStruck();
            testStruck1.Num = 1;
            TestStruck testStruck2 = new TestStruck();
            testStruck2.Num = 2;
            Console.WriteLine($"值类型 第一个值{testStruck1.Num},第二个值{testStruck2.Num}");

            TestClass testClass1 = new TestClass();
            testClass1.Num = 11;
            TestClass testClass2 = new TestClass();
            testClass2.Num = 22;
            Console.WriteLine($"引用类型 第一个值{testClass1.Num},第二个值{testClass2.Num}");
        }
    }
}
