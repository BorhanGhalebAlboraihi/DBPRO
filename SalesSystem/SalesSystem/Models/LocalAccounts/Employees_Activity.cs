using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.LocalAccounts
{
    public class Employees_Activity
    {
        //حركة الموظفين
        /// <summary>
        /// وهذذذه الشاشذذة هذذي شاشذذة يذذتم مذذن خلالهذذا الاسذذتعلام، إضذذافة، تعذذديل وحذذذف كذذل مذذا يتعلذذق بحركذذات المذذوظفين والعمذذال مذذن حيذذث (السذذلف  الاضافي...) باستثناء الراتب. – الخصومات
        /// </summary>
        /// Update Move on Employee
        public int Move_Id { get; set; }
        public string Move_Type { get; set; }
        public string C_Name { get; set; }
        public string M_Name { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Communique { get; set; }
        public string State { get; set; }
        public string History { get; set; }
        /// <summary>
        /// Chesh from Box
        /// </summary>
        public int Box_Id { get; set; }
        public string Box_Name { get; set; }
        /// <summary>
        /// Cheqe from Bank
        /// </summary>
        public int Bnk_Id { get; set; }
        public string Bnk_Name { get; set; }
        public int Ch_Id { get; set; }
        public string Deservedness_History { get; set; }
        /// <summary>
        /// Select Employees
        /// </summary>
        public int  Emp_Id{ get; set; }
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
        public double Pure{ get; set; } //  الصافي      

    }
}
