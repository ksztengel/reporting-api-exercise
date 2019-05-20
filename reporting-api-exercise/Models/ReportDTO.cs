using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{



    public class ReportTimeFrame

    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }


    }
    public class ReportDTO
    {

        public ReportTimeFrame timeFrame { get; set; }
        public double value { get; set; }

    }
    public class ReportRootObject
    {
        public string report { get; set; }
        public string timeInterval { get; set; }
        public List<ReportDTO> data { get; set; }


    }
}





