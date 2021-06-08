using FabrygameLoader;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;
using System.Windows.Forms;
using System.Diagnostics;

namespace Loader
{
    class Perform
    {
		public static void Activator()
        {
			Process f = new Process();

			f.StartInfo.FileName = "cmd.exe";

			f.StartInfo.RedirectStandardInput = true;

			f.StartInfo.RedirectStandardError = true;

			f.StartInfo.RedirectStandardOutput = true;

			f.StartInfo.UseShellExecute = false;

			f.StartInfo.CreateNoWindow = true;

			f.Start();

			f.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");

			f.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");

			f.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");

			f.StandardInput.WriteLine("taskkill /f /im BEService.exe");

			f.StandardInput.WriteLine("taskkill /f /im BEServices.exe");

			f.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");

			f.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");

			f.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");

			f.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");

			f.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");

			f.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");

			f.StandardInput.WriteLine("reg delete \"HKEY_USERS\\");

			f.StandardInput.WriteLine("Done! go play Fortnite Kid!");
		}
        public static void changehwid()
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
				MessageBox.Show("Old HWID: " + str, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (MessageBox.Show("New HWID: " + text + ", do you like it?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
				{
					changehwid2();
				}
				else
                {

                }
			}
			catch (Exception)
			{
				MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}
		public static void changehwid2()
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
				if (MessageBox.Show("New HWID: " + text + ", do you like it?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
				{
					changehwid2();
				}
				else
				{

				}
			}
			catch (Exception)
			{
				MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}
    }
}
