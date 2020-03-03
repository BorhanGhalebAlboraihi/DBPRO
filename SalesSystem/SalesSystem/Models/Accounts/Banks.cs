using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class Banks
    {
        [Key]
        public int Bnk_Id { get; set; }
        public string BakArabic_Name { get; set; }
        public string BakEnglish_Name { get; set; }
        public int Bak_MainAccountNB { get; set; }
        public string Bak_Type { get; set; }
        public string Bak_State { get; set; }
        public string Bak_Netuarl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string M_Id{ get; set; }
        public virtual Moneys Moneys { get; set; }
        public int Account_Id { get; set; }
        public virtual MainAccounts Accounts { get; set; }

    }
}
