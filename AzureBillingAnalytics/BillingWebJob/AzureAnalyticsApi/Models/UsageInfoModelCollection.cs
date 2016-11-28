﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace BillingWebJob.Models
{
    public static partial class UsageInfoModelCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<UsageInfoModel> DeserializeJson(JToken inputObject)
        {
            IList<UsageInfoModel> deserializedObject = new List<UsageInfoModel>();
            foreach (JToken iListValue in ((JArray) inputObject))
            {
                UsageInfoModel usageInfoModel = new UsageInfoModel();
                usageInfoModel.DeserializeJson(iListValue);
                deserializedObject.Add(usageInfoModel);
            }
            return deserializedObject;
        }
    }
}