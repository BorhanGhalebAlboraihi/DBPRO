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
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores_and_Stores.Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public double Buys_Dust { get; set; }
        public double Sales_Dust { get; set; }
        
    }
}
