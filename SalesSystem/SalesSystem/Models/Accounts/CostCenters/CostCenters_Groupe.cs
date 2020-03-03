using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.CostCenters
{
    public class CostCenters_Groupe
    {
        public int CG_Id { get; set; }
        public string CG_Name { get; set; }
        [Key]
       public virtual ICollection<CostCenter> CostCenters { get; set; }
        public string EngName { get; set; }
        public string State { get; set; }

    }
}
