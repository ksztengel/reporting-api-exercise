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


        ReportRootObject IReportingManager.GetLCP(string business_id, string report, string interval, string start, string end)
        {
            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);

            //if (startTime < endTime)
            //{
            //switch (interval)
            //{
            //case "hours":
            //    var hour = (endTime - startTime).TotalHours;
            //    break;
            //case "days":
            //var days = (endTime - startTime).TotalDays;
            //break;
            //case "weeks":
            //    var week = (endTime - startTime).TotalDays;
            //    break;
            //case "months":
            //var month = (endTime - startTime).TotalDays;
            //break;
            //error handling

            //}

            //};


            //get laborcost (hours worked * pay_rate)
            var laborResult = _jsonManager.GetLaborEntriesJson();

            laborResult.data.ForEach((entry) =>
            {

                if ((entry.clock_out <= endTime) && (entry.clock_in >= startTime))

                {
                    int hours = (int)(entry.clock_out - entry.clock_in).TotalHours;
                    laborCost += entry.pay_rate * hours;

                }


            });

            //get total sales

            var priceResult = _jsonManager.GetOrderedItemsJson();

            priceResult.data.ForEach((order) =>
            {
                if (order.updated_at >= startTime && order.updated_at <= endTime)
                {
                    totalSales += order.price;
                }

            });

            var value = (laborCost / totalSales) * 100;


            ReportTimeFrame tf = new ReportTimeFrame();
            {
                tf.start = startTime;
                tf.end = endTime;
            }

            ReportDTO rptDTO = new ReportDTO();

            {
                value = (int)rptDTO.value;
                tf = rptDTO.timeFrame;

            }

            List<ReportDTO> rptList = new List<ReportDTO>();
            {

                rptList.Add(new ReportDTO());
            }

            ReportRootObject rpt = new ReportRootObject();
            {
                rpt.report = "LCP";
                rpt.timeInterval = interval;
                rpt.data = rptList;


            };


            return rpt;
        }



        ReportRootObject IReportingManager.GetFCP(string business_id, string report, string interval, string start, string end)
        {

            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);

            //get food cost/sales
            var foodResult = _jsonManager.GetOrderedItemsJson();

            foodResult.data.ForEach((item) =>
            {

                totalCost += item.cost;
                totalSales += item.price;

            });

            var value = (totalCost / totalSales) * 100;


            ReportTimeFrame tf = new ReportTimeFrame();
            {
                tf.start = startTime;
                //tf.end = endTime;
            }

            ReportDTO rptDTO = new ReportDTO();

            {
                value = (int)rptDTO.value;
                tf = rptDTO.timeFrame;


            }

            List<ReportDTO> rptList = new List<ReportDTO>();
            {
                rptList.Add(new ReportDTO());

            }


            ReportRootObject rpt = new ReportRootObject();
            {
                rpt.report = "FCP";
                rpt.timeInterval = interval;
                rpt.data = rptList;


            };


            return rpt;
        }



        EmployeeRootObject IReportingManager.GetEGS(string business_id, string report, string interval, string start, string end)
        {

            DateTime startTime = DateTime.Parse(start);
            DateTime endTime = DateTime.Parse(end);

            //get gross sales

            var employeeResults = _jsonManager.GetEmployeeJson();

            employeeResults.data.ForEach((emp) =>
            {
                if (emp.updated_at >= startTime && emp.updated_at <= endTime)
                {
                    id = emp.id;
                    name = emp.first_name + " " + emp.last_name;

                    var foodResult = _jsonManager.GetOrderedItemsJson();

                    foodResult.data.ForEach((item) =>

                    {
                        if (item.employee_id == id)
                        {
                            grossSales += item.price;
                        }

                    });
                };
            });

            var employee = name;
            var value = grossSales;


            EmployeeTimeFrame tf = new EmployeeTimeFrame();
            {
                tf.start = startTime;
                tf.end = endTime;
            }

            EmployeeReportDTO erptDTO = new EmployeeReportDTO();
            {
                tf = erptDTO.timeFrame;
                name = erptDTO.employee;
                value = (int)erptDTO.value;
            }

            List<EmployeeReportDTO> erptList = new List<EmployeeReportDTO>();
            {

                erptList.Add(new EmployeeReportDTO());
            }


            EmployeeRootObject erpt = new EmployeeRootObject();
            {
                erpt.report = "EGS";
                erpt.timeInterval = interval;
                erpt.data = erptList;


            }
            return erpt;
        }


    }
}



