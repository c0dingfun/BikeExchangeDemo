using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BikeExchange.Models.ViewModels
{
    public class ModelViewModel
    {
        public Model Model { get; set; }
        public IEnumerable<Make> Makes { get; set; }

        // 
        public IEnumerable<SelectListItem> MakeList(IEnumerable<Make> makes)
        {
            var makeList = new List<SelectListItem>();
            makeList.Add(
                new SelectListItem
                { 
                    Text="----Select----",
                    Value = "0"
                }
            );

            foreach (var make in makes)
            {
                makeList.Add(
                    new SelectListItem
                    {
                        Text = make.Name,
                        Value = make.Id.ToString()
                    }
                );
            }

            return makeList;
        }
    }
}
