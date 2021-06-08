using System;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Linq;
using Microsoft.Win32;
using System.Windows.Forms;
using FabrygameLoader;
using System.Security.Cryptography;
using System.Text;
using Console = Colorful.Console;
using System.Drawing;
using Loader;
using System.Windows.Controls;

namespace FabrygameLoader
{
	internal class Class2
	{


		public static void Tester()
		{
			int num = 60;
			_ = (new char[62]);
			char[] array = "♡♢♤♧".ToCharArray();
			RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[num];
			randomNumberGenerator.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(num);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % (array.Length - 1)]);
			}
			Console.Title = "Loader by God Paster#6893 (version: 0.1.2 BETA) | " + (((stringBuilder != null) ? stringBuilder.ToString() : null) ?? "");
			new Thread(new ThreadStart(Class2.Tester)).Start();
		}

		public static void Print(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				Thread.Sleep(sec);
			}
		}
		public static void PrintRed(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i], Color.Red);
				Thread.Sleep(sec);
			}
		}
		public static void Printyyy(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i], Color.Yellow);
				Thread.Sleep(sec);
			}
		}
		public static void PrintBluetomag(string message, int sec = 40)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i], Color.Blue);
				Thread.Sleep(sec);
			}
		}
		public static void Spoofertitle()
		{
			int num = 60;
			_ = (new char[62]);
			char[] array = "∟¦Å►}§(♪►¨┼".ToCharArray();
			RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
			byte[] array2 = new byte[num];
			randomNumberGenerator.GetNonZeroBytes(array2);
			StringBuilder stringBuilder = new StringBuilder(num);
			foreach (byte b in array2)
			{
				stringBuilder.Append(array[(int)b % (array.Length - 1)]);
			}
			Console.Title = "Loader by God Paster#6893 (version: 0.1.2 BETA) | " + (((stringBuilder != null) ? stringBuilder.ToString() : null) ?? "");
			new Thread(new ThreadStart(Class2.Spoofertitle)).Start();
		}
	}
}
