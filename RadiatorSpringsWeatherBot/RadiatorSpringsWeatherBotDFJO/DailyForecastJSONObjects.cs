// GENERATED FROM JSON THING KAV DON'T CHANGE IT

using System.Collections.Generic;

namespace RadiatorSpringsWeatherBot.RadiatorSpringsWeatherBotDFJO
{
    public class DummyThiccTwo
    {
        
    }
    public class Geometry
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public List <List <List <double > > > coordinates { get; set; }
    }

    public class Elevation
    {
        
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string unitCode { get; set; }
    }

    public class PeriodsItem
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int number { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string startTime { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string endTime { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string isDaytime { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public int temperature { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string temperatureUnit { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string temperatureTrend { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string windSpeed { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string windDirection { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string icon { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string shortForecast { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string detailedForecast { get; set; }
    }

    public class Properties
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string updated { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string units { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string forecastGenerator { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string generatedAt { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string updateTime { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string validTimes { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public Elevation elevation { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public List <PeriodsItem > periods { get; set; }
    }

    public class Root
    {
        
        /// <summary>
        /// 
        /// </summary>
        public List <string > @context { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public Geometry geometry { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public Properties properties { get; set; }
    }


    }