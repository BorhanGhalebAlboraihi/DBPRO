using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Main_Accounts
    {
        [Key]
        //رقم حساب المخزون الخاص به مثلا 100 هذا للمخزون 100-100 هذ للمجموعة 100100100هذ لللصنف وهكذا

        // الحسابات الرئيسية
        public int Move_Id { get; set; }
        public string Description { get; set; }
        public int Account_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Account_Name { get; set; } //في الدليل المحاسبي
        /// <summary>
        /// Foreign Key with Account Type
        /// </summary>
        public string Type_Name { get; set; }
        public virtual Accounts.AccountsTypes AccountsTypes { get; set; }
        public DateTime History { get; set; }//السرية
        /// <summary>
        /// 
        /// </summary>
        public string Rank_Name { get; set; }
        public virtual Accounts.AccountsRanks  AccountsRanks { get; set; }
        public string M_Name { get; set; }
        public virtual Accounts.Moneys Moneys { get; set; }
        public double Debtor_Total { get; set; }//
        public double Borrower_Total { get; set; }



    }
}
