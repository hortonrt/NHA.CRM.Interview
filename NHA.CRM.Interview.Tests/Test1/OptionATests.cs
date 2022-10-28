using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHA.CRM.Interview.Models;
using System;

namespace NHA.CRM.Interview.Preference.Tests
{
	[TestClass()]
	public class OptionATests
	{
		[TestMethod()]
		public void GetClockTest()
		{
			OptionA optionA = new OptionA();
			WorldClock worldClock = optionA.GetWorldClock().Result;
			DateTime now = DateTime.Now;
			Assert.AreEqual((int)now.DayOfWeek, worldClock.DayOfWeek);
		}
	}
}