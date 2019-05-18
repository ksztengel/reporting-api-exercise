using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections;

namespace reportingapiexercise.Models
{
    public class OrderedItemsDTO
    {

            [JsonProperty("id")] 
            public string id { get; set; }
            [JsonProperty("business_id")]
            public string business_id { get; set; }
            [JsonProperty("employee_id")]
            public string employee_id { get; set; }
            [JsonProperty("check_id")]
            public string check_id { get; set; }
            [JsonProperty("item_id")]
            public string item_id { get; set; }
            [JsonProperty("name")]
            public string name { get; set; }
            [JsonProperty("cost")]
            public int cost { get; set; }
            [JsonProperty("price")]  
            public int price { get; set; }
            [JsonProperty("voided")]
            public bool voided { get; set; }
            [JsonProperty("updated_at")]
            public DateTime updated_at { get; set; }
            [JsonProperty("created_at")]
            public DateTime created_at { get; set; }

       
    }

        public class OrderedItemsRootObject
    {
        public int count { get; set; }
        public List<OrderedItemsDTO> data = 
            new List<OrderedItemsDTO>();

        public virtual IEnumerator GetEnumerator()
        {
            return this.data.GetEnumerator();
        }
     
    }
}

