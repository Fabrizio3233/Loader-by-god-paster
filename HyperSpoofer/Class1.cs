using System;
using System.Runtime.InteropServices;
namespace AllKeys
{
    public class Class1
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr h, string m, string c, int type);

        public static void Ciao(string[] args)
        {
            MessageBox((IntPtr)0, "Your Message", "My Message Box", 0);
        }
    }
}