using System;
using System.Runtime.InteropServices;

namespace helloStd
{
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
