using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts
{
    public class AccountsGroupe
    {
        public int Groupe_Id { get; set; }
        [Key]
        public string Groupe_Name { get; set; }
        public virtual ICollection<MainAccounts> MainAccounts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EngName { get; set; }
        public int State { get; set; }
    }
}

