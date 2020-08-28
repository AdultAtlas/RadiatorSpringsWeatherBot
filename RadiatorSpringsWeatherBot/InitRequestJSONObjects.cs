// GENERATED FROM JSON THING KAV DON'T CHANGE IT

using System.Collections.Generic;

namespace RadiatorSpringsWeatherBot
{
    public class DummyThicc
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
        public List <double > coordinates { get; set; }
    }

    public class Distance
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

    public class Bearing
    {
        
        /// <summary>
        /// 
        /// </summary>
        public int value { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string unitCode { get; set; }
    }

    public partial class Properties
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string city { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public Distance distance { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public Bearing bearing { get; set; }
    }

    public class RelativeLocation
    {
        
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

    public partial class Properties
    {
        
        /// <summary>
        /// 
        /// </summary>
        public string @id { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string @type { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string cwa { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string forecastOffice { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string gridId { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public int gridX { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public int gridY { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string forecast { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string forecastHourly { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string forecastGridData { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string observationStations { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public RelativeLocation relativeLocation { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string forecastZone { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string county { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string fireWeatherZone { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string timeZone { get; set; }    
        /// <summary>
        /// 
        /// </summary>
        public string radarStation { get; set; }
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
        public string id { get; set; }    
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