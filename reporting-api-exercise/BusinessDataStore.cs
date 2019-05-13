﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using reportingapiexercise.Models;


using System; namespace reporting_api_exercise {
    public class BusinessDataStore
    {
        public sstatic BusinessDataStore Current {get;}  = new BusinessDataStore();

        public List<BusinessDTO> Businesses { get; set; }

        public BusinessDataStore()
    {
      "count": 3,
      "data": [
        {
          "id": "b2aeb27b-c85c-4ad8-83d4-d9511063d418",
          "name": "Red BBQ",
          "hours": [
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22
          ],
          "updated_at": "2018-07-27T16:34:12.910Z",
          "created_at": "2018-07-27T16:34:12.910Z"
        },
        {
          "id": "e0b6683d-5efc-4b7a-836d-f3a3fe16ebae",
          "name": "Avero Burger",
          "hours": [
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22
          ],
          "updated_at": "2018-07-27T16:32:02.167Z",
          "created_at": "2018-07-27T16:32:02.167Z"
        },
        {
          "id": "f21c2579-b95e-4a5b-aead-a3cf9d60d43b",
          "name": "Sunshine Breakfast",
          "hours": [
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15
          ],
          "updated_at": "2018-07-27T16:34:59.803Z",
          "created_at": "2018-07-27T16:34:59.803Z"
        }
      ]
    }
  }
}
