using System;
using System.IO;
using MyWeather;
using Newtonsoft.Json.Linq;

string key = File.ReadAllText("appsettings.json");
string APIKey = JObject.Parse(key).GetValue("APIKey").ToString();

Console.WriteLine("Enter your zipcode");
var zipCode = Console.ReadLine();

//Call for the string, that is, the Endpoint. In other words, the api call and in this case
//I used "weatherUrl" to represent the weatherMap url.
var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";

Console.WriteLine();

Console.WriteLine($"At the moment, the temp is {MyWeatherMap.GetTemp(weatherUrl)}°F in your location. ");
Console.WriteLine();

Console.WriteLine($"While the humidity is {MyWeatherMap.GetHumidity(weatherUrl)}°F. ");
Console.WriteLine();

Console.WriteLine($"Thank you for checking in, goodbye!");
Console.WriteLine();
