using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Editorial_Accounts
{
    public class Constraints_Type
    {
        //انواع القيود
        [Key]
        public int Const_Id { get; set; }
        public virtual ICollection<Editorial_Accounts> Editorial_Accounts { get; set; }
        public virtual ICollection<Categores_and_Stores.Categores.Store_Outgoings> Store_Outgoings { get; set; }
        public virtual ICollection<LocalAccounts.CheqesWorks> CheqesWorks { get; set; }
        public string Const_Type { get; set; }
        public string State { get; set; }
    }
}
