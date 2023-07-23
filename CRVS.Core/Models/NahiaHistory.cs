using CRVS.Core.Models.SheardCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class NahiaHistory:CommonProp
    {
        public int NahiaHistoryId { get; set; }
        public string? NahiaHistoryName { get; set; }
        public DateTime NahiaHistorydate { get; set; }
        public string? NahiaType { get; set; }
        public int NahiaCode { get; set; }
    }
}
