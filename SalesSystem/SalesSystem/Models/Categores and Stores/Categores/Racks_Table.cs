using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Racks_Table
    {
        //جدول الرفوف
        public int Racks_Id { get; set; }
        public int S_Id { get; set; }
        public virtual Stores.Stores Stores { get; set; }
        public string S_Name { get; set; }
        public string Racks_Specification { get; set; }
        public string Racks_Description { get; set; }
    }
}
