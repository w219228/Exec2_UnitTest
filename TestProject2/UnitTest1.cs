using Ispan.Utilities;

namespace TestProject2
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void IsTradingTime_是否有在交易時間內()
		{
			var stock = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022, 10, 24, 13, 29, 59);
			bool result = stock.IsTradingTime(dateTime);

			Assert.AreEqual(true, result);
		}
		[Test]
		public void IsTradingTime_在星期六日()
		{
			var stock = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022, 10, 23, 13, 29, 59);
			bool result = stock.IsTradingTime(dateTime);

			Assert.AreEqual(false, result);
		}
		[Test]
		public void IsTradingTime_在星期一到五()
		{
			var stock = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022, 10, 24, 13, 29, 59);
			bool result = stock.IsTradingTime(dateTime);

			Assert.AreEqual(true, result);
		}
	}
}