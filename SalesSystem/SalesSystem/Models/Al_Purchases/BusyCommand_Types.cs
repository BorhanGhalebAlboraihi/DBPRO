using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Al_Purchases
{
    public class BusyCommand_Types
    {
        [Key]
        public int BCT_Id { get; set; }
        public virtual ICollection<Purchases__Invoice> Purchases__Invoices { get; set; }
        public string BCT_Name { get; set; }
    }
}
