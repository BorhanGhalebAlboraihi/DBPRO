using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Al_Purchases
{
    public class States_Types
    {
        public int ST_Id { get; set; }
        [Key]
        public string ST_Name { get; set; }
        public virtual ICollection<Purchases__Invoice> Purchases__Invoices { get; set; }
    }
}
