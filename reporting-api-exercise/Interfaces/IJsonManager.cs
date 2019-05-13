using System;
using System.Collections.Generic;
using reportingapiexercise.Models;

namespace reportingapiexercise.Interfaces
{
    public interface IJsonManager
    {
        BusinessRootObject GetBusinessJson();

        LaborEntriesRootObject GetLaborEntriesJson();
        //OrderedItemsRootObject GetOrderedItemsJson(string business_id);
        OrderedItemsRootObject GetOrderedItemsJson();
    }
}
