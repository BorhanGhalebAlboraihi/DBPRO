using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class CheqesWorks
    {
        //جدول العمل على الشيكات 
        /// <summary>
        /// Top هنا معنا من حساب البنك الى حساب العملاء او الصنوق او الشيكات تحت التحصيل المهم المدين بنك او 
        /// </summary>
        public int Process_Id { get; set; }
        public string AS_Name { get; set; }
        public virtual Accounts.AccountsVariarble.Accounts_state Accounts_State { get; set; }
        public int Bank_Id { get; set; }
        public virtual Accounts.Banks Banks { get; set; }
        public string Bank_Name { get; set; }
        public int M_Id { get; set; }
        public virtual Accounts.Moneys Moneys { get; set; }
        public int MT_Id{ get; set; } //   نوع الحركة هل نقد من البنك او شيك اذا كانت شيك لازم تحديد رقم الشيك  مثلا اذا كان شيك تحت التحصيل ك 
        public virtual LocalAccounts.ChMove_Type ChMove_Type { get; set; }
        public string MT_Name { get; set; }//نوع الحركة هل شيك او نقد 
        public int Ch_Id { get; set; }
        public double Communication { get; set; }
        public DateTime Deservedness_History { get; set; }



        /// <summary>
        /// Lower
        /// </summary>
        public int Const_Id { get; set; }
        public virtual Editorial_Accounts.Constraints_Type Constraints_Type { get; set; }
        public string Year { get; set; }
        public string Communique { get; set; }
        public double Account_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Accounts_Name { get; set; }
        public string C_Name { get; set; }
        public string Toin_Accounts { get; set; }//الحسابات الوسيطة




    }
}
