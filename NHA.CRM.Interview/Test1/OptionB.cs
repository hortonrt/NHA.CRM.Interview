using Newtonsoft.Json;
using NHA.CRM.Interview.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace NHA.CRM.Interview.Preference
{
	public class OptionB
	{
		private HttpClient HttpClient { get; }

		public OptionB(HttpClient httpClient)
		{
			HttpClient = httpClient;
		}

		public async Task<WorldClock> GetWorldClock()
		{
			var response = await HttpClient.GetAsync("http://worldtimeapi.org/api/timezone/America/Detroit");
			var result = await response.Content.ReadAsStringAsync();
			var clock = JsonConvert.DeserializeObject<WorldClock>(result);
			return clock;
	        }
	}
}
