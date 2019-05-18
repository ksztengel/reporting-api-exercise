using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using reportingapiexercise.Interfaces;
using reportingapiexercise.Models;
using static System.Linq.Enumerable;
using static reportingapiexercise.Models.ChecksDTO;


namespace reportingapiexercise
{

    public class ReportingManager : IReportingManager
    {

        private readonly IJsonManager _jsonManager;
        private int laborCost;
        private int totalSales;
        private int totalCost;
        private int grossSales;
        private string id;
        private string name;


        public ReportingManager(IJsonManager jsonManager)
        {

            _jsonManager = jsonManager;

        }

        public ReportingManager()
        {
        }

        int IReportingManager.GetLCP(string business_id, string report, string start, string end)
        {

            //get hours worked
            var laborResult = _jsonManager.GetLaborEntriesJson();

            //DateTime startTime = DateTime.Parse(start);
            //DateTime endTime = DateTime.Parse(end);

            laborResult.data.ForEach((entry) =>
            {

                if (entry.clock_out > entry.clock_in)

                {

                    int hours = (int)(entry.clock_out - entry.clock_in).TotalHours;
                    laborCost += entry.pay_rate * hours;

                };


            });

            //get total sales

            var priceResult = _jsonManager.GetOrderedItemsJson();
            priceResult.data.ForEach((order) =>
            {

                totalSales += order.price;
            });

            return (laborCost / totalSales) * 100;
        }



        int IReportingManager.GetFCP(string business_id, string report, string start, string end)
        {

            //get food cost/sales
            var foodResult = _jsonManager.GetOrderedItemsJson();

            foodResult.data.ForEach((item) =>
            {
                totalCost += item.cost;
                totalSales += item.price;
            });

            return (totalCost / totalSales) * 100;
        }



        int IReportingManager.GetEGS(string business_id, string report, string start, string end)
        {
            //get gross sales

            var employeeResults = _jsonManager.GetEmployeeJson();

            employeeResults.data.ForEach((employee) =>
            {
                id = employee.id;
                name = employee.first_name + " " + employee.last_name;

                var foodResult = _jsonManager.GetOrderedItemsJson();

                foodResult.data.ForEach((item) =>

                {
                    if (item.employee_id == id)
                    {
                        grossSales += item.price;
                    }

                });
            });


            return grossSales;
        }

    }
}