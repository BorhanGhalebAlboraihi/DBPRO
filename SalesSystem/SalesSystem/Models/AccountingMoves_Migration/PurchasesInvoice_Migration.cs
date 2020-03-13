﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.AccountingMoves_Migration
{
    public class PurchasesInvoice_Migration
    {
        //ترحيل فواتير المشتريات 
        [Key]
        public int Move_Id { get; set; }
        /// <summary>
        /// ام تختار نوع الترحيل  الكل او قيد او يوم او فترة 
        /// </summary>
        public bool AllMig { get; set; }//ترحيل الكل 
        public bool ConstMig { get; set; }//ترحيل فاتورة 
        public bool DayMig { get; set; }//اليوم
        public bool PeriodMig { get; set; }//ترحيل فترة محاسبية
        /// <summary>
        /// تختار هل قبض ام شيك
        /// </summary>
        public bool Purchases { get; set; }//مشتريات
        public bool Purchases_Returns { get; set; }// مردود مشتريات
   
        /// <summary>
        /// تختار هل نقدا ام شيك ام اجل 
        /// </summary>
        public bool Cesh { get; set; }
        /// <summary>
        /// اذا كان شيك لازم تحدد طريقة التسديد هل الن ام تسديد لا يعني لازم نربطة في اةراق القبض 
        /// </summary>
        public bool Cheque { get; set; }
        public string Sight_Method { get; set; }//طريقة التسديد
        public bool Term { get; set; }//اجل
        /// <summary>
        /// تختار هل كل العملات ام عمله محددة
        /// </summary>
        public bool MoneyAll { get; set; }
        public bool SelectMoney { get; set; }
        public string M_Name { get; set; }

        /// <summary>
        /// رقم السند من الى 
        /// </summary>
        public int FromMove_Id { get; set; }//من رقم الفاتورة 
        public int ToMove_Id { get; set; }//الي رقم الفاتورة

        /// Middem
        /// </summary>
        public bool Migration { get; set; }
        public string ConstType { get; set; }//قيد فاتورة مبيعات ام قيد فاتورة مردود
        public int Voucher_Id { get; set; }//رقم الفاتورة
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
