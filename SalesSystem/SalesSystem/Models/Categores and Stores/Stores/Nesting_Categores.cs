using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Nesting_Categores
    {
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id  { get; set; }
        public string Cat_Name { get; set; }
        public int NesCat_Id { get; set; }
        public string NesCat_Name { get; set; }
        public double NesCat_Quantity { get; set; }
        public DateTime History { get; set; }
    }
}
