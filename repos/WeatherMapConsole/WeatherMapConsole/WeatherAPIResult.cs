using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMapConsole
{
    public class WeatherAPIResult
    {
        [JsonProperty("main")]
        public MainData Main { get; set; }
    }
}
