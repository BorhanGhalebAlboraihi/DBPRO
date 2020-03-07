using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Outgoningness
    {// جدول المصروفات
        /// <summary>
        /// Top
        /// </summary>
        [Key]
        public int Move_Id { get; set; }//رقم الحركة
        public string OUT_Name { get; set; }//نوع الحركة
        public virtual OutgoningnessMove_Type OutgoningnessMove_Type { get; set; }
        public DateTime Request_History { get; set; }
        public string Request_Comment { get; set; }
        /// <summary>
        ///  تعليق الطلب  لأنها العملية وفي هذه الحاله لا يمكن الترحيل
        /// </summary>

        public string Request_Introduction { get; set; }//مقدم الطلب
        /// <summary>
        /// Cheshfrom Box
        /// </summary>
        public int Box_Id { get; set; }
        public string Box_Name { get; set; }
        public string M_Name{ get; set; }
        public string Accounant { get; set; }//يقدم الى المسؤل
       /// <summary>
       /// Cheqe from Bank
       /// </summary>
        public int Bnk_Id { get; set; }
        public string Bnk_Name { get; set; }
        public int Ch_Id { get; set; }
        public string Deservedness_History { get; set; }
        /// <summary>
        /// Public
        /// </summary>
        public double Communication{ get; set; }
        public string Communique { get; set; }
        /// <summary>
        /// Lower
        /// </summary>
        public int Account_Id { get; set; }
        public string Account_Name { get; set; }
        public string C_Name { get; set; }
        public double Communication_Sum { get; set; }




    }
}
