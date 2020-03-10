using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Resource_Types
    {
        // انواع التوريدالمخزني 
        public int RE_Id { get; set; }
        [Key]
        public string RE_Type { get; set; }
        public virtual ICollection<Categores.Store_Resource> Store_Resources { get; set; }

    }
}
