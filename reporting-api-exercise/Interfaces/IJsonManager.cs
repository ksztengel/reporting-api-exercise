using System;
using System.Collections.Generic;
using reportingapiexercise.Models;
using static reportingapiexercise.Models.ChecksDTO;

namespace reportingapiexercise.Interfaces
{
    public interface IJsonManager
    {
        BusinessRootObject GetBusinessJson();

        LaborEntriesRootObject GetLaborEntriesJson();

        OrderedItemsRootObject GetOrderedItemsJson();

        ChecksRootObject GetChecksJson();

        EmployeesRootObject GetEmployeeJson();

        MenuItemsRootObject GetMenuItemsJson();

    }
}
