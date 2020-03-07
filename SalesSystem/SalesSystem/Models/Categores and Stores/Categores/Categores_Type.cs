using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Categores_Type
    {
        public int CT_Id { get; set; }
        [Key]
        public string CT_Name { get; set; }
        public virtual ICollection<Categores_Data> Categores_Datas { get; set; }
    }
}
