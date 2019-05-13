using System;
using System.Collections.Generic;

namespace reportingapiexercise.Models
{
    public class MenuItemsDTO
    {
        public class Datum
        {
            public string id { get; set; }
            public string business_id { get; set; }
            public string name { get; set; }
            public int cost { get; set; }
            public int price { get; set; }
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
