using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using reportingapiexercise;
using reportingapiexercise.Interfaces;
using reportingapiexercise.Models;

namespace reporting_api_exercise.Controllers
{
    [Route("api/reporting")]
    [ApiController]
    [JsonObject]
    public class ReportingController : ControllerBase
    {
        private readonly IJsonManager _jsonManager;
        private readonly IReportingManager _reportingManager;


        public ReportingController(IJsonManager jsonManager, IReportingManager reportingManager)
        {
            _jsonManager = jsonManager;
            _reportingManager = reportingManager;
        }
        /// <summary>
        /// Is and endpoint that gets a report.
        /// <param name="business_id" The id of the business </param>
        /// <param name="report" The abbreviated name of the report to run LCP,FCP,EGS </param>
        /// <param name="timeInterval" The time interval to aggregate data </param>
        /// <param name="start" The start date </param>
        /// <param name ="end" The end date </param>
        /// </summary>
        /// <returns>Returns the LCP or FCP or EGS json</returns>


        [HttpGet]

        public string GetReports(string business_id, string report, string interval, string start, string end)
        {   if (report == null)
            {
                return "Please add a report name:  LCP FCP  or EGS";

                    //add a .resx file to store error messages and use @ReportAPIErrors.report, .interval, .start

            };

            if (report == "LCP")
            {

                var result = _reportingManager.GetLCP(business_id, report, interval, start, end);


                return JsonConvert.SerializeObject(result);
            }



            else if (report == "FCP")

            {

                var result = _reportingManager.GetFCP(business_id, report, interval, start, end);

                return JsonConvert.SerializeObject(result);

            }
            else

            {

                var result = _reportingManager.GetEGS(business_id, report, interval, start, end);

                return JsonConvert.SerializeObject(result);

            }

        }

        [HttpGet()]
        [Route("{business_id}/{report}/{interval}/{start}/{end}")]
        public ReportRootObject GET(string business_id, string report, string interval, string start, string end)
        {
            var result = _reportingManager.GetLCP(business_id, report, interval, start, end);
            return result;
        }

    }



}














