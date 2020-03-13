using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Outginigs_Types
    {// انواع اوامر الصرف المخزني 
        public int Out_Id { get; set; }
        [Key]
        public string Out_Type { get; set; }
        public virtual ICollection<Store_Outgoings> Store_Outgoings { get; set; }
       // public virtual ICollection<Stores.StoreOutgoings_Returns> StoreOutgoings_Returns { get; set; }
    }
}
