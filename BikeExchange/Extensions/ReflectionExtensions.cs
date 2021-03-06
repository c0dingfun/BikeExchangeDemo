﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeExchange.Extensions
{
    public static class ReflectionExtensions
    {
        public static string GetPropertyValue<T>(this T item, string propertyName)
        {
            // do reflection on the item
            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();

        }
    }
}
