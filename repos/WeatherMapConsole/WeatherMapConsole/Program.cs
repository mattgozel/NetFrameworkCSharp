using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WeatherMapConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter a zip code: ");
                string input = Console.ReadLine();
                int zipcode;

                if (int.TryParse(input, out zipcode) == true)
                {
                    DoWeatherSearch(input);
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a valid number.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }

        private static void DoWeatherSearch(string zipcode)
        {
            string myAPIKey = "26f3accd7482a0ceb76271bf2b4658bb";
            WeatherAPIResult model = null;

            HttpClient client = new HttpClient();

            string uri = $"http://api.openweathermap.org/data/2.5/weather?zip={zipcode},us&units=imperial&appid={myAPIKey}";

            var task = client.GetAsync(uri).ContinueWith((taskForResponse) =>
            {
                HttpResponseMessage response = taskForResponse.Result;

                var processJson = response.Content.ReadAsAsync<WeatherAPIResult>();
                processJson.Wait();

                model = processJson.Result;
            });

            task.Wait();
            DisplaySearchResults(model);

        }

        private static void DisplaySearchResults(WeatherAPIResult model)
        {
            Console.WriteLine($"Temperature (F): {model.Main.Temperature}");
            Console.WriteLine($"Humidity: {model.Main.Humidity}%");
            Console.WriteLine($"Pressure: {model.Main.Pressure}");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
