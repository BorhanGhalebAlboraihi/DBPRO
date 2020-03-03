using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class AccountsRanks
    {
        public int Rank_Id { get; set; }
     
        [Key]
        public string Rank_Name { get; set; }
        public virtual ICollection<MainAccounts> MainAccounts { get; set; }
        public virtual ICollection<Primary_Accounts> Primary_Accounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EngName { get; set; }
        public int Length { get; set; }
    }
}
