using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{
    public class LCPDTO
    {
        public TimeFrame timeFrame { get; set; }
        public double value { get; set; }
    }
    public class TimeFrame
        {
            public DateTime start { get; set; }
            public DateTime end { get; set; }
        }


        public class LCPRootObject
        {
            public string report { get; set; }
            public string timeInterval { get; set; }
            public List<LCPDTO> data { get; set; }
        }
}



