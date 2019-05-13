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

        public int GetOrderedPrices()
        {
            var priceResult = _jsonManager.GetOrderedItemsJson();
            var price = priceResult.data.FirstOrDefault().price;
            var id = priceResult.data.FirstOrDefault().business_id;

            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += priceResult.data[i].price;
            }
            return sum;

            //foreach (int price in priceResult)
            //{
            //    sum += price;
            //}
            //return sum;
        }


    }
}
