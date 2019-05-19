using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using reportingapiexercise.Interfaces;
using reportingapiexercise.Models;
using static Newtonsoft.Json.JsonConvert;
using static reportingapiexercise.Models.ChecksDTO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace reportingapiexercise

{
    public class JsonManager : IJsonManager
    {

        public BusinessRootObject GetBusinessJson()
        {

            using (StreamReader r = new StreamReader("AppData/BusinessesDataStore.json"))
            {
                string json = r.ReadToEnd();
                BusinessRootObject items = DeserializeObject<BusinessRootObject>(json);
                return items;
            }

        }

        public ChecksRootObject GetChecksJson()
        {

            using (StreamReader r = new StreamReader("AppData/ChecksDataStore.json"))
            {
                string json = r.ReadToEnd();
                ChecksRootObject items = DeserializeObject<ChecksRootObject>(json);
                return items;
            }

        }

        public EmployeesRootObject GetEmployeeJson()
        {

            using (StreamReader r = new StreamReader("AppData/EmployeeDataStore.json"))
            {
                string json = r.ReadToEnd();
                EmployeesRootObject items = DeserializeObject<EmployeesRootObject>(json);
                return items;
            }

        }

        public LaborEntriesRootObject GetLaborEntriesJson()
        {

            using (StreamReader r = new StreamReader("AppData/LaborEntriesDataStore.json"))
            {
                string json = r.ReadToEnd();
                LaborEntriesRootObject items = DeserializeObject<LaborEntriesRootObject>(json);
                return items;
            }

        }

        public MenuItemsRootObject GetMenuItemsJson()
        {

            using (StreamReader r = new StreamReader("AppData/MenuItemsDataStore.json"))
            {
                string json = r.ReadToEnd();
                MenuItemsRootObject items = DeserializeObject<MenuItemsRootObject>(json);
                return items;
            }

        }

        public OrderedItemsRootObject GetOrderedItemsJson()
        {

            using (StreamReader r = new StreamReader("AppData/OrderedItemsDataStore.json"))
            {
                string json = r.ReadToEnd();
                OrderedItemsRootObject items = DeserializeObject<OrderedItemsRootObject>(json);

                return items;
            }

        }

    }
}

