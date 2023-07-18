using CRVS.Core.Models.SheardCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
public class Nahia: CommonProp
    {
        public int NahiaId { get; set; }
        public string? NahiaName { get; set; }
        public int GovernoriteId { get; set; }
        public int DohId { get; set; }

        public int DistrictId { get; set; }
      
    }
}
