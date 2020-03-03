using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Boxs
    {
        [Key]
        public int Box_Id { get; set; }
        public string BoxArabic_Name { get; set; }
        public string BoxEnglish_Name { get; set; }
        public int Box_MainAccountNB { get; set; }
        public string Box_Type { get; set; }
        public string Box_State { get; set; }
        public string Box_Netuarl { get; set; }
        public int C_Id { get; set; }
        public string C_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string M_Id { get; set; }
        public virtual Moneys Moneys { get; set; }
        public int Account_Id { get; set; }
        public virtual MainAccounts Accounts { get; set; }
    }
}
