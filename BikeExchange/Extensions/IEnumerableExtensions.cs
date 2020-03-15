using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BikeExchange.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItems<T>(this IEnumerable<T> items)
        {
            var selectListItems = new List<SelectListItem>();
            selectListItems.Add(
                new SelectListItem
                {
                    Text = "----Select----",
                    Value = "0"
                }
            );

            foreach (var item in items)
            {
                selectListItems.Add(
                    new SelectListItem
                    {
                        //Text = item.GetType().GetProperty("Name").GetValue(item,null).ToString(),
                        //Value = item.GetType().GetProperty("Id").GetValue(item,null).ToString()
                        Text = item.GetPropertyValue("Name"), // using yet another extension method
                        Value = item.GetPropertyValue("Id")
                    }
                ); ; ;
            }

            return selectListItems;
        }
    }
}
