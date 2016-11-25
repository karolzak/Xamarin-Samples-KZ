﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using XamFormsHttpClient.Models;

namespace XamFormsHttpClient.Models
{
    public static partial class OrderCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<Order> DeserializeJson(JToken inputObject)
        {
            IList<Order> deserializedObject = new List<Order>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                Order order = new Order();
                order.DeserializeJson(iListValue);
                deserializedObject.Add(order);
            }
            return deserializedObject;
        }
    }
}
