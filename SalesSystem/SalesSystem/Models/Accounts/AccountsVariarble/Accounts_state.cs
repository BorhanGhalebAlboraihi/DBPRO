using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Accounts.AccountsVariarble
{
    public class Accounts_state
    {
        public int AS_Id { get; set; }
        [Key]
        public string AS_Name { get; set; }
        public virtual ICollection<MainAccounts> MainAccounts { get; set; }
        public string EngName { get; set; }
    }
}
