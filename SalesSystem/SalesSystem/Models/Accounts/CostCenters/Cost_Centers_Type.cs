using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.CostCenters
{
    public class Cost_Centers_Type
    {
        public int CT_Id { get; set; }
        [Key]
        public string CT_Name { get; set; }
        public virtual ICollection<CostCenter> CostCenters { get; set; }
        public string EngName { get; set; }
       
    }
}
