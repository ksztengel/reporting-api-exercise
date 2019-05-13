using System;
using reportingapiexercise.Models;

namespace reportingapiexercise.Interfaces
{
    public interface IReportingManager
    {
        int GetOrderedPrices(string business_id);
    }
}

