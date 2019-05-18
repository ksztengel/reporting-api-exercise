using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{
    public class EGSDTO
    {
        public class TimeFrame
        {
            public DateTime start { get; set; }
            public DateTime end { get; set; }
        }

        public class Datum
        {
            public TimeFrame timeFrame { get; set; }
            public string employee { get; set; }
            public double value { get; set; }
        }

        public class RootObject
        {
            public string report { get; set; }
            public string timeInterval { get; set; }
            public List<Datum> data { get; set; }
        }
    }
}
