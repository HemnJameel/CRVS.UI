using CRVS.Core.Models.SheardCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
public class Governorite: CommonProp
    {
        public int GovernoriteId { get; set; }
        public string ?GovernoriteName { get; set; }
      
        [NotMapped]
        public int DohId { get; set; }
       
    }
}
