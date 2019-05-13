using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using reportingapiexercise.Interfaces;
using reportingapiexercise.Models;

namespace reportingapiexercise
{
    public class ReportingManager : IReportingManager 
    {

        private readonly IJsonManager _jsonManager;

        public ReportingManager(IJsonManager jsonManager)
        {

            _jsonManager = jsonManager;

        }      

        public BusinessRootObject GetBusinessJson()
        {
            return _jsonManager.GetBusinessJson();
        }


        public LaborEntriesRootObject GetLaborEntriesJson()
        {
            return _jsonManager.GetLaborEntriesJson();

        }

        public OrderedItemsRootObject GetOrderedItemsJson()
        {
            return _jsonManager.GetOrderedItemsJson();
        }

        public int GetOrderedPrices(string business_id)
        {
            var priceResult = _jsonManager.GetOrderedItemsJson();

            int priceSum = priceResult.data.Where(p => p.business_id == business_id).ToList().Sum(d => d.price);

            return priceSum;

        }
        
    }
}
