using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test hellodll");
            string s = "こんにちは C++ の世界";

            HelloDll.SetNameStr(s);
            // var s1 = Marshal.PtrToStringAnsi(GetNameStr());
            var s1 = HelloDll.GetNameStr();
            Console.WriteLine(s1);

            HelloDll.SetNameWStr(s + " in Unicode");
            // var s2 = Marshal.PtrToStringUni(GetNameWStr());
            var s2 = HelloDll.GetNameWStr();
            Console.WriteLine(s2);
            Console.WriteLine("end");
        }

        [DllImport("hellodll", EntryPoint = "SetNameWStr", CharSet = CharSet.Unicode)]
        static extern void SetNameWStr(string t);
        [DllImport("hellodll", EntryPoint = "GetNameWStr", CharSet = CharSet.Unicode)]
        static extern IntPtr GetNameWStr();
    }

    public class HelloDll
    {
        public static void SetNameStr(string s) { _SetNameStr(s); }
        public static string GetNameStr() { return Marshal.PtrToStringAnsi(_GetNameStr()); }
        public static void SetNameWStr(string s) { _SetNameWStr(s); }
        public static string GetNameWStr() { return Marshal.PtrToStringUni(_GetNameWStr()); }


        [DllImport("hellodll", EntryPoint = "SetNameStr")]
        static extern void _SetNameStr(string t);
        [DllImport("hellodll", EntryPoint = "GetNameStr")]
        static extern IntPtr _GetNameStr();
        [DllImport("hellodll", EntryPoint = "SetNameWStr", CharSet = CharSet.Unicode)]
        static extern void _SetNameWStr(string t);
        [DllImport("hellodll", EntryPoint = "GetNameWStr", CharSet = CharSet.Unicode)]
        static extern IntPtr _GetNameWStr();
    }
}
