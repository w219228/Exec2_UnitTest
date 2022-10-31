﻿using Ispan.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var obj = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022,10,24,13,29,8);
			bool canTrade = obj.IsTradingTime(dateTime);
			Console.WriteLine(canTrade);
		}
	}
}
