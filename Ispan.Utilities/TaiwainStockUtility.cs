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
			bool ordinary = IsOrdinary(dt);
			bool trade = IsTrade(dt);
			return (ordinary && trade)?true:false;	
		}
		public virtual bool IsOrdinary(DateTime dt)
		{
			DayOfWeek week = dt.DayOfWeek;
			int value = (int)week;
			return (value == 6 || value == 0) ? false : true;
		}
		public virtual bool IsTrade(DateTime dt)
		{
			double todayTime = dt.Hour*100+dt.Minute+dt.Second*0.01;
			return (todayTime < 900 || todayTime > 1330) ? false : true;
		}
	}
}
