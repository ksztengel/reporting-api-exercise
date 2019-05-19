using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{

    public class EmployeeTimeFrame
    {
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }

    public class EmployeeReportDTO
    {
        public EmployeeTimeFrame timeFrame { get; set; }
        public string employee { get; set; }
        public double value { get; set; }
    }

    public class EmployeeRootObject
    {
        public string report { get; set; }
        public string timeInterval { get; set; }
        public List<EmployeeReportDTO> data { get; set; }
    }
}


