﻿// -----------------------------------------------------------------------------
//  <copyright file="Program.cs" company="Zack Loveless">
//      Copyright (c) Zack Loveless.  All rights reserved.
//  </copyright>
// -----------------------------------------------------------------------------

namespace LanteaBot
{
	using System;
	using Lantea.Core;

	public class Program
	{
		public static void Main(string[] args)
		{
			using (var bot = new Bot())
			{
				bot.LoadSettings("Settings.xml");
				bot.Start();

				Console.Write("Press <ENTER> to terminate the bot.");
				Console.ReadLine();
			}
		}
	}
}