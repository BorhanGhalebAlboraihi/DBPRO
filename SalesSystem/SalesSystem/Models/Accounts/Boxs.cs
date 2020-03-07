using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Boxs
    {
        [Key]
        public int Box_Id { get; set; }
        public virtual ICollection<LocalAccounts.Arresting_Voucher> Arresting_Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Exchange__Voucher> Exchange__Vouchers { get; set; }
        public virtual ICollection<LocalAccounts.Employees_Activity> Employees_Activities { get; set; }
        public virtual ICollection<LocalAccounts.Salerys_Execution> Salerys_Executions { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public string BoxArabic_Name { get; set; }
        public string BoxEnglish_Name { get; set; }
        public int Box_MainAccountNB { get; set; }
        public string Box_Type { get; set; }
        public string Box_State { get; set; }
        public string Box_Netuarl { get; set; }
        public int C_Id { get; set; }
        public string C_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string M_Id { get; set; }
        public virtual Moneys Moneys { get; set; }
        public int Account_Id { get; set; }
        public virtual MainAccounts Accounts { get; set; }
    }
}
