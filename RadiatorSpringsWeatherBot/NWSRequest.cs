using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace RadiatorSpringsWeatherBot
{
    public class NWSRequest
    {
        private HttpWebRequest _initRequest;
        private WebResponse _initResponse;
        public NWSRequest()
        {
            _initRequest = (HttpWebRequest) WebRequest.Create("https://api.weather.gov/points/38.8894,-77.0352");
            _initRequest.UserAgent = "myweatherapp.com";
        }
        
        //"https://api.weather.gov/gridpoints/LWX/96,70/forecast"
        //"https://api.weather.gov/gridpoints/LWX/96,70/forecast/hourly"
        //"https://api.weather.gov/points/38.8894,-77.0352"

        // Dictates what type of response we're going to have from NWS, whether that's the base response or a specific format response
        public string WhichResponse(int respType)
        {
            string response = "";
            switch (respType)
            {
                case 0:
                    response = InitialResponse();
                    break;
                case 1:
                    response = ForecastResponse();
                    break;
                case 2:
                    response = "";
                    break;
                default:
                    break;
            }

            return response;
        }
        private string InitialResponse()
        {
            _initResponse = _initRequest.GetResponse();

            string r;

            using (Stream dataStream = _initResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                 r = reader.ReadToEnd();

            }


            Root rootObj = JsonConvert.DeserializeObject<Root>(r);
            return rootObj.properties.forecastHourly.ToString();
        }

        private string ForecastResponse()
        {
            // Really need to find a way to call another function or something, get a way to read this. DRY!!!!
            List<String> propertyItems = new List<string>();
            _initRequest = (HttpWebRequest) WebRequest.Create("https://api.weather.gov/gridpoints/LWX/96,70/forecast");
            _initRequest.UserAgent = "myweatherapp.com";
            
            _initResponse = _initRequest.GetResponse();
            Console.WriteLine(_initResponse);
            RadiatorSpringsWeatherBotDFJO.Root rootObj;
            
            using (Stream dataStream = _initResponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                rootObj = JsonConvert.DeserializeObject<RadiatorSpringsWeatherBotDFJO.Root>(reader.ReadToEnd());


            }

            foreach (var item in rootObj.properties.periods)
            {
                string forecast = $@"{item.name}: {item.detailedForecast}";
                propertyItems.Add(forecast);
                Console.WriteLine(forecast);
            }

            string returnResponse = propertyItems.Aggregate((x, y) => x + "\n" + y);
            Console.WriteLine(returnResponse.Length);
            
            return returnResponse;
        }
    }
}