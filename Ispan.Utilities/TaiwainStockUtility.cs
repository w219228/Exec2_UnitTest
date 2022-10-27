using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilities
{
	public class TaiwainStockUtility
	{
		public virtual bool IsTradingTime(DateTime dt)
		{
			bool ordinary = isOrdinary(dt);
			bool trade = isTrade(dt);
			return (ordinary && trade)?true:false;

			
		}
		public virtual bool isOrdinary(DateTime dt)
		{
			DayOfWeek week = dt.DayOfWeek;
			int value = (int)week;
			return (value == 6 || value == 0) ? false : true;
		}
		public virtual bool isTrade(DateTime dt)
		{
			int todayTime = dt.Hour;
			return (todayTime < 9 || todayTime > 13) ? false : true;
		}
	}
}
