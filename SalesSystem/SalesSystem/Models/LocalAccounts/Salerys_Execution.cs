using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Salerys_Execution
    {
        //تنفيذ الرواتب
        /// <summary>
        /// Top
        /// </summary>
        public int Move_Id { get; set; }
        public DateTime History { get; set; }
        public string Communique { get; set; }
        public string Bough { get; set; }
        public double communication { get; set; }
        public string State{ get; set; }
        public int Bnk_Id { get; set; }
        public string M_Name { get; set; }
        public int Box_Id { get; set; }
        /// <summary>
        /// Lower Details Employees
        /// </summary>
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Location { get; set; }
        public double Work_Type { get; set; }//Days and weekly and month and year
        public double Salery { get; set; }
        public double Equivalence { get; set; }//المكافئة
        public double Addset { get; set; }//الاضافي او العلاوه
        public double Tuxedos { get; set; }
        public double Advance { get; set; }//المسحوبات او السلاف
        public double Vulture { get; set; }//الجزاءات
        public double Contender { get; set; }// الاستقطاعات
        public double Pure { get; set; } //  

    }
}
