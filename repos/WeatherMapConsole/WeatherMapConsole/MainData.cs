using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMapConsole
{
    public class MainData
    {
        [JsonProperty("temp")]
        public decimal Temperature { get; set; }
        [JsonProperty("humidity")]
        public decimal Humidity { get; set; }
        [JsonProperty("pressure")]
        public decimal Pressure { get; set; }
    }
}
