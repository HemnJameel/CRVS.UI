using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class DistrictHistory
    { 
        public int DistrictHistoryId { get; set; }
        public string? DistrictHistoryName { get; set; }
        public int DistrictCode { get; set; }
        public DateTime DistrictHistorydate { get; set; }
        public string? DistrictType { get; set; }


    }
}
