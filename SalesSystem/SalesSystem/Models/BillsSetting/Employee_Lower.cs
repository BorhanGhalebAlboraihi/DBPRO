using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting
{
    public class Employee_Lower
    {
        // جدول التخفيضات للموظف
        [Key]
        public int Process_Id { get; set; }
        /// <summary>
        /// RelationShip
        /// </summary>
        public int Emp_Id { get; set; }
        public virtual Accounts.Employees Employees { get; set; }
        public string Emp_Name { get; set; }
        public double LowerHigh { get; set; }
        public double LowerLess { get; set; }
        public DateTime FromHistory { get; set; }
        public DateTime ToHistory { get; set; }
        public string Communique { get; set; }//البيان
        public DateTime History { get; set; }
        public String State { get; set; }
        /// <summary>
        /// 
        /// </summary>
      
    }
}
