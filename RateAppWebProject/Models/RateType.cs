using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RateAppWebProject.Models
{
    public class RateType
    {
        public SelectRateType SelectedRateType { get; set; }
    }

    public enum SelectRateType
    {
        Excelent,
        Moderate//,
        //Needs Improvement
    }
}


