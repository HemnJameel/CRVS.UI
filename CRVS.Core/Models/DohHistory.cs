using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class DohHistory
    {
        public int DohHistoryId { get; set; }
        public string? DohHistoryName { get; set; }
        public DateTime DohHistorydate { get; set; }
        public string? DohType { get; set; }
        public int DohCode { get; set; }
    }
}
