using NHA.CRM.Interview.Models;
using NHA.CRM.Interview.Preference;
using System;
using System.Net.Http;

namespace NHA.CRM.Interview
{
	static class WorldClockRunner
	{
		public static void Run()
		{
			OptionA optionA = new OptionA();
			OptionB optionB = new OptionB(new HttpClient());

			WorldClock optA = optionA.GetWorldClock().Result;
			Console.WriteLine($"Option A Time: {optA.Datetime}");

			WorldClock optB = optionB.GetWorldClock().Result;
			Console.WriteLine($"Option B Time: {optB.Datetime}");
		}
	}
}
