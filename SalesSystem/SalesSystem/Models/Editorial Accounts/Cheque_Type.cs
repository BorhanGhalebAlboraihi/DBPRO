using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Editorial_Accounts
{
    public class Cheque_Type
    {
        public int CT_Id { get; set; }
        [Key]
        public string CT_Name { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
    }
}
