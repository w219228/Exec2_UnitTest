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
		public void IsTradingTime_�O�_���b����ɶ���()
		{
			var stock = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022, 10, 24, 13, 29, 59);
			bool result = stock.IsTradingTime(dateTime);

			Assert.AreEqual(true, result);
		}
		[Test]
		public void IsTradingTime_�b�P������()
		{
			var stock = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022, 10, 23, 13, 29, 59);
			bool result = stock.IsTradingTime(dateTime);

			Assert.AreEqual(false, result);
		}
		[Test]
		public void IsTradingTime_�b�P���@�줭()
		{
			var stock = new TaiwainStockUtility();
			DateTime dateTime = new DateTime(2022, 10, 24, 13, 29, 59);
			bool result = stock.IsTradingTime(dateTime);

			Assert.AreEqual(true, result);
		}
	}
}