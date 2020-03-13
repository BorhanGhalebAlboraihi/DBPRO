using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.System_Reports_and_Output
{
    public class Accounts_Exposure
    {
        //كشف الحسابات
   
        [Key]
        public int Move_Id { get; set; }
       
        /// <summary>
        /// Details Voucher
        /// </summary>
        public int Accounts_Id { get; set; }
        public string Accounte_Name { get; set; }
        public string M_Id { get; set; }
        public DateTime History { get; set; }
        public string ConstType { get; set; } 

        /// <summary>
        ///  الرقم ام يكون رقم السند او رقم الفاتورة او رقم القيد يعني الرقم بشكل عام
        /// </summary>                                 
        public int Number { get; set; }
        public string Refference { get; set; }
        public double Debtore { get; set; }
        public double Borrower { get; set; }
        public string Communique { get; set; }
        public bool Migration { get; set; }
        public string C_Name { get; set; }
        public double Accounts { get; set; }//الرصيد
        /// <summary>
        /// بيانات اضافية
        /// </summary>
        public double Communication { get; set; }//المبلغ
        public string S_Name { get; set; }//المحصل
        public int Ch_Id { get; set; }
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string Sight_Method { get; set; }//طريقة التسديد
        public int MoveNumber { get; set; }//عدد الحركات

    }
}
