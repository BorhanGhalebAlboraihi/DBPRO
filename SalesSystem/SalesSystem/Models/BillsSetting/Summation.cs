using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting
{
    public class Summation
    {
        //جدول المحصلين
        [Key]
        public int S_Id { get; set; }
        public virtual ICollection<Accounts.Customers> Customers { get; set; }
        public virtual ICollection<Accounts.Suppliers> Suppliers { get; set; }
        public String S_Name { get; set; }
        public String Type { get; set; }
        public String Adddress { get; set; }
        public int Phone { get; set; }
        public String State { get; set; }
        public DateTime History { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int A_Id { get; set; }//رقم منطقة العمل 
        public virtual SalesAreas SalesAreas { get; set; }
        public int Account_Id { get; set; }//في الدليل المحاسبي
        public virtual Accounts.MainAccounts MainAccounts { get; set; }

    }
}
