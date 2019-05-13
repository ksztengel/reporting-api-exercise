using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace reportingapiexercise.Models
{
    public class LaborEntriesDTO
    {


            [JsonProperty("id")] 
            public string id { get; set; }
            [JsonProperty("business_id")]
            public string business_id { get; set; }
            [JsonProperty("employee_id")]
            public string employee_id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("clock_in")]
            public DateTime clock_in { get; set; }
            [JsonProperty("clock_out")]
            public DateTime clock_out { get; set; }
            [JsonProperty("pay_rate")]
            public int pay_rate { get; set; }
            [JsonProperty("updated_at")]
            public DateTime updated_at { get; set; }
            [JsonProperty("created_at")]
            public DateTime created_at { get; set; }
        }

        public class LaborEntriesRootObject : IEnumerable<int>
        {
            public int count { get; set; }
            public List<LaborEntriesDTO> data { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    }


