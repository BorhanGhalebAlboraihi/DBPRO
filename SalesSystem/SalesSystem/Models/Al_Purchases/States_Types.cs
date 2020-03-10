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
        public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; } 
        public virtual ICollection<Al_Purchases.Purchases_Commands> Purchases_Commands { get; set; }

        public virtual ICollection<Al_Purchases.Purchases_Requerts> Purchases_Requerts { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
    }
}
