using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.BillsSetting
{
    public class Dust
    {
        //جدول الضريبة
        public int Id { get; set; }
        public int Groupe_Id { get; set; }
        public string Groupe_Name { get; set; }
        public int Categore_Id { get; set; }
        public string Categore_Name { get; set; }
        public double Buys_Dust { get; set; }
        public double Sales_Dust { get; set; }
        
    }
}
