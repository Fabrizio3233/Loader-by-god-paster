using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Linq;
using Microsoft.Win32;
using FabrygameLoader;
using System.Windows;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using FabrygameLoader;
using Fabrygame99;
using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fabrygame99;

namespace Loader
{
    class Class3
    {
		public static void cheatsaa()
        {
			Console.Clear();
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.SetWindowSize(123, 30);
			Console.WriteLine("");
			Console.WriteLine("   ▄██████▄   ▄██████▄  ████████▄               ▄███████▄    ▄████████    ▄████████     ███        ▄████████    ▄████████ ");
			Console.WriteLine("  ███    ███ ███    ███ ███   ▀███             ███    ███   ███    ███   ███    ███ ▀█████████▄   ███    ███   ███    ███ ");
			Console.WriteLine("  ███    █▀  ███    ███ ███    ███             ███    ███   ███    ███   ███    █▀     ▀███▀▀██   ███    █▀    ███    ███ ");
			Console.WriteLine(" ▄███        ███    ███ ███    ███             ███    ███   ███    ███   ███            ███   ▀  ▄███▄▄▄      ▄███▄▄▄▄██▀ ");
			Console.WriteLine("▀▀███ ████▄  ███    ███ ███    ███           ▀█████████▀  ▀███████████ ▀███████████     ███     ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ");
			Console.WriteLine("  ███    ███ ███    ███ ███    ███             ███          ███    ███          ███     ███       ███    █▄  ▀███████████ ");
			Console.WriteLine("  ███    ███ ███    ███ ███   ▄███             ███          ███    ███    ▄█    ███     ███       ███    ███   ███    ███ ");
			Console.WriteLine("  ████████▀   ▀██████▀  ████████▀             ▄████▀        ███    █▀   ▄████████▀     ▄████▀     ██████████   ███    ███ ");
			Console.WriteLine("                                                                                                               ███    ███ ");
			Console.ForegroundColor = ConsoleColor.Red;
			Class2.Print("CHEATS", 20);
			Console.WriteLine("");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("All outdated now");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("0");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(" ---> Go Back");
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("");
			Console.Write("9");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write(" ---> EXIT");
			Console.WriteLine("");
			Class2.Print("Selection: ", 20);
			string stop = Console.ReadLine();
			if (stop == "9")
			{
				Environment.Exit(-1);
			}
			else if (stop == "0")
			{
				Program.Loader();
			}
			else
			{
				Class3.cheatsaa();
			}
		
		Inizio:

			if (a == "1")
			{

			}

			else if (a == "5")
{
	/*ShowWindow(win, 0);
	Thread.Sleep(1);*/
	new Thread(new ThreadStart(Program.Loader)).Start();
	ooo.thred();
	Environment.Exit(0);
}
else if (a == "4")
{
	Cheats.Cleanur();
}
else if (a == "9")
{
	Environment.Exit(-1);
}

else if (a == "3")
{
	Cheats.HWID();
}
else if (a == "2")
{
Cleaner:
	Console.Clear();
	Console.ForegroundColor = ConsoleColor.Magenta;
	Console.SetWindowSize(120, 30);
	Console.WriteLine("");
	Console.WriteLine(" ██████╗  ██████╗ ██████╗         ██████╗  █████╗ ███████╗████████╗███████╗██████╗ ");
	Console.WriteLine("██╔════╝ ██╔═══██╗██╔══██╗        ██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗");
	Console.WriteLine("██║  ███╗██║   ██║██║  ██║        ██████╔╝███████║███████╗   ██║   █████╗  ██████╔╝");
	Console.WriteLine("██║   ██║██║   ██║██║  ██║        ██╔═══╝ ██╔══██║╚════██║   ██║   ██╔══╝  ██╔══██╗");
	Console.WriteLine("╚██████╔╝╚██████╔╝██████╔╝        ██║     ██║  ██║███████║   ██║   ███████╗██║  ██║");
	Console.WriteLine(" ╚═════╝  ╚═════╝ ╚═════╝         ╚═╝     ╚═╝  ╚═╝╚══════╝   ╚═╝   ╚══════╝╚═╝  ╚═╝");
	Console.ForegroundColor = ConsoleColor.Red;
	Class2.Print("CLEANER", 20);
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("");
	Console.Write("1");
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.Write(" ---> Apple Cleaner");
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.WriteLine("");
	Console.Write("0");
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.Write(" ---> Go back");
	Console.WriteLine("");
	Console.ForegroundColor = ConsoleColor.Yellow;
	Console.Write("9");
	Console.ForegroundColor = ConsoleColor.Cyan;
	Console.Write(" ---> Exit");
	Console.WriteLine("");
	Class2.Print("Selection:", 20);
	string b = Console.ReadLine();
	if (b == "1")
	{
		//Apple Cleaner
		Cheats.AppleCleaner();
	}
	else if (b == "0")
	{
		goto Inizio;
	}
	else if (b == "9")
	{
		Environment.Exit(-1);
	}
	else
	{
		goto Cleaner;
	}
	else
	{
	Console.Clear();
	goto Inizio;
	}
    }
}
