using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Displaies_Types
    {
        
        public int DT_Id { get; set; }
        [Key]
        public string DT_Name { get; set; }
        public virtual ICollection<Categores_Lower_and_Top> Categores_Lower_And_Tops { get; set; }
    }
}
