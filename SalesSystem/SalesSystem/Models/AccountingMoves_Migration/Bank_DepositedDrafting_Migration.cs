using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.AccountingMoves_Migration
{
    public class Bank_DepositedDrafting_Migration
    {
        //ترحيل التوريد والسحب البنكي
        [Key]
        public int Move_Id { get; set; }
        public DateTime MigrationHistory { get; set; }

        /// <summary>
        /// ام تختار نوع الترحيل  الكل او قيد او يوم او فترة 
        /// </summary>

        /// <summary>
        public bool Resource { get; set; }
        public bool Drafting { get; set; }
        /// </summary>
        public bool AllMig { get; set; }//ترحيل الكل 
        public bool ConstMig { get; set; }//ترحيل قيد 
        public bool DayMig { get; set; }
        public bool PeriodMig { get; set; }//ترحيل فترة محاسبية
        public int FromBDMove_Id { get; set; }//التوريد المخزني او السحب المخزني
        public int ToMove_Id { get; set; }// رقم التوريد او السحب المخزني
                                          /// <summary>
        public bool MoneyAll { get; set; }
        public bool SelectMoney { get; set; }
        public string M_Name { get; set; }
        /// </summary>
        public int Voucher_Id { get; set; }//رقم السند
        public string Refference { get; set; }
        public DateTime ExecutionHistory { get; set; }
        public double Communication { get; set; }//المبلغ
        public string S_Name { get; set; }//المحصل
        public int Box_Id { get; set; }
        public int Ban_Id { get; set; }
        public bool Swap { get; set; }//التبديل
        /// <summary>
        /// Lower
        /// </summary>
        public string C_Id { get; set; }
        public int Ch_Id { get; set; }
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string Sight_Method { get; set; }//طريقة التسديد
        public int ConstNumber { get; set; }//عدد القيود
        public int NotConstMigration { get; set; }//القيود التي لن ترحل 
        public int ConstMigration { get; set; }//القيود التي سترحل
        /// <summary>
        /// Details Voucher
        /// </summary>
        public int Accounts_Id { get; set; }
        public string Accounte_Name { get; set; }
        public string Money { get; set; }
        public double Debtore { get; set; }
        public double Borrower { get; set; }
        public string Communique { get; set; }
        public string C_Name { get; set; }


    }
}
