using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace reportingapiexercise
{
    public class BusinessesDTO
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("hours")]
        public List<int> hours { get; set; }
        [JsonProperty("updated_at")]
        public DateTime updated_at { get; set; }
        [JsonProperty("created_at")]
        public DateTime created_at { get; set; }
    }

    public class BusinessRootObject
    {
        public int count { get; set; }
        public List<BusinessesDTO> data { get; set; }
    }

}

