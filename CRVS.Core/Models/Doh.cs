using CRVS.Core.Models.SheardCode;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRVS.Core.Models
{
    public class Doh :CommonProp
    {
        public int DohId { get; set; }
        public string? DohName { get; set; }
      
      

        [ForeignKey("Governorite")]
        public int GovernoriteId { get; set; }
        public Governorite? Governorite { get; set; }   
        
     
    }
}
