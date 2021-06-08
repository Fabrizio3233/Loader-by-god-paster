using Fabrygame99;
using Fabrygame99;
using FabrygameLoader;
using FabrygameLoader;
using FabrygameLoader;
using Loader;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using Console = Colorful.Console;

namespace Loader
{
    class bhh
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        static int SW_SHOW = 5;
        static int SW_HIDE = 0;

        public static void accessform()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE); 
            accessdirecttoform();
        }
        public static void accessdirecttoform()
        {
            FormAccesso fa = new FormAccesso();
            Application.Run(fa);
        }
        public static void cum()
        {
        cii:
            Console.Clear();
            Console.Write("LOADER BY God Paster#6893", Color.Red);
            Console.Write(" | ", Color.Cyan);
            Console.Write("Copyright © God Paster#6893", Color.Yellow);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Enter key: ", Color.Yellow);
            Console.ForegroundColor = Color.Yellow;
            string bbbbbbbbbbbb = Console.ReadLine();
            if (bbbbbbbbbbbb == "cum")
            {
                string filename = "C:\\ProgramData\\Success-sound.wav";
                string filename2 = "C:\\ProgramData\\Old-man-says-nope.wav";
                SoundPlayer sound = new SoundPlayer(filename);
                sound.Play();
                MessageBox.Show("SUCCESSSS!!!!", "  ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                File.Delete(filename);
                File.Delete(filename2);
                Program.LALA();
            }
            else
            {
                string filename2 = "C:\\ProgramData\\Old-man-says-nope.wav";
                SoundPlayer sound = new SoundPlayer(filename2);
                sound.Play();
                Console.WriteLine("Failed. Retry in 2 seconds", Color.Yellow);
                Thread.Sleep(2000);
                goto cii;
            }
        }
        public static void Update()
        {
            WebClient webClient = new WebClient();
            if (webClient.DownloadString("https://pastebin.com/raw/msRk8kpn").Contains("2.0"))
            {
                ooo.no();
            }
            ooo.up();
        }
    }
}
