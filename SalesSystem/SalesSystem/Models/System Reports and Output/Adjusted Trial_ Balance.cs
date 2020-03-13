using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.System_Reports_and_Output
{
    public class Adjusted_Trial__Balance
    {
        //ميزان المراجعة المعدل
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
        /// <summary>
        /// هذا في حالة الأرصده
        /// </summary>
        public double Debtore { get; set; }
        public double Borrower { get; set; }
        /// <summary>
        /// هذا في حالة المجاميع
        /// </summary>
        public double SumDebtore { get; set; }
        public double SumBorrower { get; set; }
        public string Communique { get; set; }
        public bool Migration { get; set; }
        public string C_Name { get; set; }
        public int Rank_Id { get; set; }
        public string Rank_Name { get; set; }
        public double Accounts { get; set; }//الرصيد
        /// <summary>
        /// بيانات اضافية
        /// </summary>
        public double DebtorTotal { get; set; }//مجموع المدين في حالة الارصدة
        public string BorrowerTotal { get; set; }//مجموع الدائن في حالة الارصدة 
        public double SumDebtorTotal { get; set; }//مجموع المدين في حالة المجاميع
        public string SumBorrowerTotal { get; set; }//مجموع الدائن في حالة في المجاميع 
        public double Pure  { get; set; }//الفارق 
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string Sight_Method { get; set; }//طريقة التسديد
      
    }
}
