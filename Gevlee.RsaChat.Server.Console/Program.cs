﻿using System.Text;
using Gevlee.RsaChat.Server.Core;

namespace Gevlee.RsaChat.Server.Console
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			System.Console.OutputEncoding = Encoding.ASCII;
			var bootstrapper = new Bootstrapper();
			bootstrapper.Run();
			System.Console.ReadKey();
		}
	}
}