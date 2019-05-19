using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using reportingapiexercise.Models;

namespace reportingapiexercise.Interfaces
{
    public interface IReportingManager
    {
        ReportRootObject GetLCP(string business_id, string report, string interval, string start, string end);

        ReportRootObject GetFCP(string business_id, string report, string interval, string start, string end);

        EmployeeRootObject GetEGS(string business_id, string report, string interval, string start, string end);


    }

}

