using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Cat_State
    {
        public int CS_Id { get; set; }
        [Key]
        public string CS_Name { get; set; }
        public virtual ICollection<Categores_Data> Categores_Datas { get; set; }
        public virtual ICollection<Stores.Stores_Groupe> GetStores_Groupes { get; set; }
        public virtual ICollection<Stores.Stores> Stores { get; set; }
        public virtual Categores__Lower Categores__Lower { get; set; }

        
    }
}
