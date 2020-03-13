using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.System_Reports_and_Output
{
    public class BorrowerDebtore_Slogan
    {
        //اشعارات المدين والدائن شاشه افتراضية 
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
        public int ConstNumber { get; set; }
        public string Refference { get; set; }
        public double Debtore { get; set; }
        public double Borrower { get; set; }
        public string Communique { get; set; }
        public string C_Name { get; set; }
   
      

    }
}
