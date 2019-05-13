using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{
    public class EmployeesDTO
    {
        public class Datum
        {
            public string id { get; set; }
            public string business_id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public int pay_rate { get; set; }
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
