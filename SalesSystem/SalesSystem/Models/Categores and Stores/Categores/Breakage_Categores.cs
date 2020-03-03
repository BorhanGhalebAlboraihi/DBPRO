using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Breakage_Categores
    {
        public int Move_Id { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Store_Id { get; set; }
        public string Store_Name { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public int Unit { get; set; }
        public double Quantity { get; set; }
        public string Because { get; set; }
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public DateTime History { get; set; }

    }
}
