using helloStd;
using System;

namespace helloCoreStd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test helloCoreStd");
            string s = "こんにちは C++ の世界";

            HelloDll.SetNameStr(s);
            var s1 = HelloDll.GetNameStr();
            Console.WriteLine(s1);

            HelloDll.SetNameWStr(s + " in Unicode");
            var s2 = HelloDll.GetNameWStr();
            Console.WriteLine(s2);
            Console.WriteLine("end");
        }
    }
}
