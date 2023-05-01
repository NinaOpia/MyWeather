using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace MyWeather
{
	public class MyWeatherMap
	{
		public static double GetTemp(string weatherUrl)
		{
			var client = new HttpClient();

			var response = client.GetStringAsync(weatherUrl).Result;

			var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

			return temp;
		}

		public static double GetHumidity(string weatherUrl)
		{
			var client = new HttpClient();

			var response = client.GetStringAsync(weatherUrl).Result;

			var humidity = double.Parse(JObject.Parse(response)["main"]["humidity"].ToString());

			return humidity;
		}
    }
}

