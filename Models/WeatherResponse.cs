using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherNow.Models
{
    public class WeatherResponse
    {
        [JsonProperty("name")]
        public string City { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public List<WeatherDescription> Weather { get; set; }

        [JsonProperty("dt")]
        public long Dt { get; set; } // Date in Unix time

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; } // Visibility in meters
    }

    public class Main
    {
        [JsonProperty("temp")]
        public float Temperature { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }

    public class WeatherDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public float Speed { get; set; } // Wind speed in meters per second
    }
}