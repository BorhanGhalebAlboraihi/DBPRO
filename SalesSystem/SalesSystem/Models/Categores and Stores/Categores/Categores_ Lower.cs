using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Categores__Lower
    {
        [Key]
        public int Process_Id { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public double LowerTotal { get; set; }
        public double LowerHigh { get; set; }
        public double LowerLess { get; set; }
        public DateTime FromHistory { get; set; }
        public DateTime ToHistory { get; set; }
        public string Communique { get; set; }//البيان
        public string CS_Name { get; set; }
        public virtual Cat_State Cat_State { get; set; }
        public DateTime History { get; set; }
    }
}
