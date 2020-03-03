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
        /// Top
        /// </summary>
        public int Process_Id { get; set; }
        public string State { get; set; }
        public string Bank_Id { get; set; }
        public string Bank_Name { get; set; }
        public string Money { get; set; }
        public int Move_Id { get; set; } //رقم الحركة 
        public string Move_Type { get; set; }//نوع الحركة هل شيك او نقد 
        public double Communication { get; set; }
        public int Ch_Id { get; set; }
        public double Account_Id { get; set; }
        public DateTime Deservedness_History { get; set; }

        /// <summary>
        /// Lower
        /// </summary>
        public string Year { get; set; }
        public string Communique { get; set; }
        public string Center { get; set; }
        public string Toin_Accounts { get; set; }//الحسابات الوسيطة




    }
}
