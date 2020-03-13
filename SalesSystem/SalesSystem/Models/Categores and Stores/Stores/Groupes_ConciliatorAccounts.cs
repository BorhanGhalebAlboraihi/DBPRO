using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Groupes_ConciliatorAccounts
    {
        //الحسابات الوسيطة بالمجموعات
        [Key]
        public int Move_Id { get; set; }
        public int SG_Id { get; set; }
        public virtual Stores_Groupe Stores_Groupe { get; set; }
        public string SG_Name { get; set; }
        public int Accounts_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Accounts_Name { get; set; }
    }

}
