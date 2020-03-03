using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Stores_Variables
    {
        [Key]
        public int S_Id { get; set; }
      //  public virtual ICollection<Stores_Groupe> Stores_Groupes { get; set; }
        public string S_Name { get; set; }
        public string WopS_Name { get; set; }//اسم المخزن الاجنبي
        public int Account_Id { get; set; }
       // public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public double Phone { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Store_Honest { get; set; }//امين المخزن
        public string Location { get; set; }
        public DateTime History { get; set; }
    }
}
