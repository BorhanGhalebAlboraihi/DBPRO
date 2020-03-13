using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Al_Purchases
{
    public class SightMethod_Types
    {
        //انواع طرق التسديد
        public int SMT_Id { get; set; }
        [Key]
        public string SMT_Name{ get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
     }
}
