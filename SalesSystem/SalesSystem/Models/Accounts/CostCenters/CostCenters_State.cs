using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.CostCenters
{
    public class CostCenters_State
    {
        public int CS_Id { get; set; }
        [Key]
        public string CS_Name { get; set; }
        public virtual ICollection<CostCenter> CostCenters { get; set; }
        public string EngName { get; set; }
    }
}
