using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Primary_Accounts
    {
        // الحسابات الرئيسية
        public int Move_Id { get; set; }
        public string Description  { get; set; }
        public int Account_Id { get; set; }
        public virtual MainAccounts MainAccounts { get; set; }
        public string Account_Name { get; set; } //في الدليل المحاسبي
        /// <summary>
        /// Foreign Key with Account Type
        /// </summary>
        public string Type_Name { get; set; }
        public virtual AccountsTypes AccountsTypes { get; set; }
        public DateTime History { get; set; }//السرية
        /// <summary>
        /// 
        /// </summary>
        public string Rank_Name { get; set; }
        public virtual AccountsRanks AccountsRanks { get; set; }
        public string M_Name { get; set; }
        public virtual Moneys Moneys { get; set; }
        public double Debtor_Total { get; set; }//
        public double Borrower_Total { get; set; }



    }
}
