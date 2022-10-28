using Newtonsoft.Json;
using NHA.CRM.Interview.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NHA.CRM.Interview.Preference
{
	public class OptionA
	{
		public async Task<WorldClock> GetWorldClock()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://worldtimeapi.org/api/timezone/America/Detroit");
            var result = await response.Content.ReadAsStringAsync();
            var clock = JsonConvert.DeserializeObject<WorldClock>(result);
            return clock;
        }
	}
}
