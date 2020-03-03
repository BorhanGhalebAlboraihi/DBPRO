using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class Cat_Articles
    {// ارقام القطع للأصناف
        public int Process_Id { get; set; }
        public int Article_Id { get; set; }
        public string Article_Name { get; set; }
        public int Franchise_Number { get; set; } // رقم الوكالة للمنتج الذي يأتي من المصنع
        public int Swap_Number { get; set; }
    }
}
