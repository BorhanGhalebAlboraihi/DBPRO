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
        public int C_Id { get; set; }
        public virtual Accounts.CostCenters.CostCenter CostCenter { get; set; }
        public string C_Name { get; set; }
        /// <summary>
        /// تحديد من اجل البحث من المبلغ المعين الي الميلغ المحدد
        /// </summary>
        public double FromCommunication { get; set; }
        public double ToCommunication { get; set; }
        public string State{ get; set; }
        public int Bnk_Id { get; set; }
        public virtual Accounts.Banks Banks { get; set; }
        public string Bnk_Name{ get; set; }
        public string M_Name { get; set; }
        public int Box_Id { get; set; }
        public virtual Accounts.Boxs Boxs { get; set; }
        public string Box_Name { get; set; }
        /// <summary>
        /// Lower Details Employees
        /// </summary>
        public int Emp_Id { get; set; }
        public virtual Accounts.Employees Employees { get; set; }
        public string Emp_Name { get; set; }
        public string Location { get; set; }
        public string Work_Type { get; set; }//Days and weekly and month and year
        public double Salery { get; set; }
        public double Equivalence { get; set; }//المكافئة
        public double Addset { get; set; }//الاضافي او العلاوه
        public double Tuxedos { get; set; }//علاوة بدلات
        public double Advance { get; set; }//المسحوبات او السلاف
        public double Vulture { get; set; }//الجزاءات
        public double Contender { get; set; }// الاستقطاعات
        public double Pure { get; set; } //  

    }
}
