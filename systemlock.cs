using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace VLV_OS
{
	class sys_lock
	{
		public static void lockpass(string passcode)
		{
			string version = "2021-04-30";
			bool unlocked = false;
			while (!unlocked)
			{
				Console.Clear();
				logo.Logo();
				Console.WriteLine("                                                                                ");
				Console.WriteLine("                                System Locked                                   ");
				Console.WriteLine("                                                                                ");
				Console.Write("Password: ");
				string enterpass = Console.ReadLine();
				if (enterpass == passcode)
				{
					unlocked = true;
					Console.Clear();
				}
			}
		}
	}
}
