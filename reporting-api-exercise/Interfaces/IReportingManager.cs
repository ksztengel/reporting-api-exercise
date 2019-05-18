using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using reportingapiexercise.Models;

namespace reportingapiexercise.Interfaces
{
    public interface IReportingManager
    {
        int GetLCP(string business_id, string report, string start, string end);

        int GetFCP(string business_id, string report, string start, string end);

        int GetEGS(string business_id, string report, string start, string end);
    }
}

