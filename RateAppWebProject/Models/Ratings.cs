using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateAppWebProject.Models
{
    public class Ratings
    {
        public int Id { get; set; }
        public int RateID { get; set; }
        public string RateTxt { get; set; }
        public IEnumerable<SelectListItem> RateSelectedValue { get; set; }
    }
}
