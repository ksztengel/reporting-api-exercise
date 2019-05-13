using System;
namespace reportingapiexercise.Models
{
    public class LCP
    {
        public int business_id { get; set; }
        public string report { get; set; }
        public TimeSpan timeInterval{ get; set;}
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
