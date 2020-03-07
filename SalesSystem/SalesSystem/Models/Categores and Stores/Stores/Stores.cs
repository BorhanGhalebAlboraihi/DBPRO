using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Stores
    {
        [Key]
        public int S_Id { get; set; }
        public virtual ICollection<Stores_Groupe> Stores_Groupes { get; set; }
        public virtual ICollection<Categores.Racks_Table> Racks_Tables { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public string S_Name { get; set; }
        public string WopS_Name { get; set; }//اسم المخزن الاجنبي
        public int Account_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public int M_Id { get; set; }
        public virtual Moneys Moneys { get; set; }
        public virtual Accounts.System_Money System_Money { get; set; }
        public string M_Name { get; set; }
        public double Phone { get; set; }
        public string CS_Name { get; set; }
        public virtual Categores.Cat_State Cat_State { get; set; }
        public string Address { get; set; }
        public string Store_Honest { get; set; }//امين المخزن
        public string Location { get; set; }
        public DateTime History { get; set; }
    }
}
