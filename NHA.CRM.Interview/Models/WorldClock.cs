using Newtonsoft.Json;
using System;

namespace NHA.CRM.Interview.Models
{
	public class WorldClock
	{
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("client_ip")]
        public string ClientIp { get; set; }

        [JsonProperty("datetime")]
        public DateTime Datetime { get; set; }

        [JsonProperty("day_of_week")]
        public int DayOfWeek { get; set; }

        [JsonProperty("day_of_year")]
        public int DayOfYear { get; set; }

        [JsonProperty("dst")]
        public bool Dst { get; set; }

        [JsonProperty("dst_from")]
        public DateTime DstFrom { get; set; }

        [JsonProperty("dst_offset")]
        public int DstOffset { get; set; }

        [JsonProperty("dst_until")]
        public DateTime DstUntil { get; set; }

        [JsonProperty("raw_offset")]
        public int RawOffset { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("unixtime")]
        public int Unixtime { get; set; }

        [JsonProperty("utc_datetime")]
        public DateTime UtcDatetime { get; set; }

        [JsonProperty("utc_offset")]
        public string UtcOffset { get; set; }

        [JsonProperty("week_number")]
        public int WeekNumber { get; set; }
    }
}
