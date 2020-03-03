using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.CostCenters
{
    public class CostCenter_Rank
    {
        [Key]
        public int CR_Id { get; set; }
        public virtual CostCenter CostCenter { get; set; }
        public string CR_Name { get; set; }
        public int Length { get; set; }
    }
}
