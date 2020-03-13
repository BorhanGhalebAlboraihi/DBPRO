using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.AccountingMoves_Migration
{
    public class StoreOutgoings_Migration
    {
        [Key]
        public int Move_Id { get; set; }
        public DateTime MigrationHistory { get; set; }
        /// <summary>
        public bool AllMig { get; set; }//ترحيل الكل 
        public bool DayMig { get; set; }//اليوم
        public bool PeriodMig { get; set; }//ترحيل فترة محاسبية
        public int Command { get; set; }//امر
        /// </summary>
        public bool Outgoning_Command { get; set; }
        public bool Returns_Command { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int FromResource_Id { get; set; }//رقم التوريد
        public int To { get; set; }

        public DateTime History { get; set; }
        public string RE_Type { get; set; } //نوع التوريد
        public string ST_Name { get; set; }//نهائي او غير نهائي

        public string Const_Type { get; set; }//نوع القيد


        public double TransferPrice { get; set; }//سعر التحويل
        public double StoreTransferPrice { get; set; }//سعر التحويل المخزني
        public int Car_Id { get; set; }//السيارة
        public string Care_Name { get; set; }//اسم السائق
        public string Refference { get; set; }
        public int ConstNumber { get; set; }//عدد القيود
        public int NotConstMigration { get; set; }//القيود التي لن ترحل 
        public int ConstMigration { get; set; }//القيود التي سترحل






        /// <summary>
        /// Details Accounts
        /// </summary>                             
        public int Account_Id { get; set; }
        public string Account_Name { get; set; }
        public string C_Name { get; set; }
        public double Debtore { get; set; }
        public double Borrower { get; set; }
        public string M_Name { get; set; }//Money
        public string Communique { get; set; }
        public string S_Name { get; set; }
    }
}
