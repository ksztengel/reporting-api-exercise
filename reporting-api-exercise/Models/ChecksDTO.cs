using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{
    public class ChecksDTO
    {
        public class Datum
        {
            public string id { get; set; }
            public string business_id { get; set; }
            public string employee_id { get; set; }
            public string name { get; set; }
            public bool closed { get; set; }
            public DateTime closed_at { get; set; }
            public DateTime updated_at { get; set; }
            public DateTime created_at { get; set; }
        }

        public class RootObject
        {
            public int count { get; set; }
            public List<Datum> data { get; set; }
        }
    }
   }

