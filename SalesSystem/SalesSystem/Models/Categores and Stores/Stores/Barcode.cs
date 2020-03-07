using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Barcode
    {
       
        public int Process_Id { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public int Unit{ get; set; }
        public virtual Categores.Units_Order Units_Order { get; set; } 
        [Key]
        public int Bar_Id  { get; set; }
        public string Bar_Type { get; set; }

    }
}
