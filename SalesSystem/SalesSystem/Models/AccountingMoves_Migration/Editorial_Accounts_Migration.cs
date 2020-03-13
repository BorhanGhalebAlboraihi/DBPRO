using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.AccountingMoves_Migration
{
    public class Editorial_Accounts_Migration
    {
        // ترحيل الحسابات الافتتاحية او القيود اليومية
        public int Const_Id { get; set; }
        public string Const_Type { get; set; }
        /// <summary>
        /// ام تختار نوع الترحيل  الكل او قيد او يوم او فترة 
        /// </summary>
        public bool AllMig { get; set; }//ترحيل الكل 
        public bool ConstMig { get; set; }//ترحيل قيد 
        public bool DayMig { get; set; }//اليوم
        public bool PeriodMig { get; set; }//ترحيل فترة محاسبية
        /// <summary>
        /// 
        /// </summary>
        public bool MoneyAll { get; set; }
        public bool SelectMoney { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FromMove_Id { get; set; }//من رقم القيد 
        public int ToMove_Id { get; set; }//الي رقم القيد
                                          /// Middem
                                          /// </summary>
        public bool Migration { get; set; }
       public DateTime History { get; set; }
        public string Const_Comment { get; set; }
        public double Transfer_Price { get; set; }
        public string Refference { get; set; }
        public string S_Name { get; set; }//المحصل
        public int Box_Id { get; set; }
        public int Ban_Id { get; set; }
        public bool Swap { get; set; }//التبديل
        /// <summary>
        /// Constraint Data
        /// </summary>
        ///
        public int Account_Id { get; set; }
        public string Account_Name { get; set; }
        public string M_Name { get; set; }
        public double Debtor { get; set; }
        public double Borrower { get; set; }
        public string Communique { get; set; }
        public string C_Name { get; set; }
        public double Equivalent { get; set; }// المكافئ
        public double Debtor_Total { get; set; }
        public double Borrower_Total { get; set; }
        public double Bands { get; set; }//الفارق
    }
}
