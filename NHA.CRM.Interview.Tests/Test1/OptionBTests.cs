using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using NHA.CRM.Interview.Models;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NHA.CRM.Interview.Preference.Tests
{
	[TestClass()]
	public class OptionBTests
	{
		private HttpClient _httpClient = new HttpClient();

		[TestInitialize()]
		public void SetupTests()
		{
			WorldClock mockWorldClock = new WorldClock
			{
				DayOfWeek = 8
			};
			Mock<HttpMessageHandler> mockMessageHandler = new Mock<HttpMessageHandler>();
			mockMessageHandler.Protected()
					.Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
					.ReturnsAsync(new HttpResponseMessage {
						StatusCode = HttpStatusCode.OK,
						Content = new StringContent(JsonConvert.SerializeObject(mockWorldClock))
					});
			_httpClient = new HttpClient(mockMessageHandler.Object);
		}

		[TestMethod()]
		public void OptionBTest()
		{
			OptionB optionB = new OptionB(_httpClient);
			WorldClock worldClock = optionB.GetWorldClock().Result;
			Assert.AreEqual(8, worldClock.DayOfWeek);
		}
	}
}