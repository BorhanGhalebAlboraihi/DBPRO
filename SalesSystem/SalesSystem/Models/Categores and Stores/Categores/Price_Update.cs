using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Price_Update
    {
        public int Move_Id { get; set; }
        public int SelectPrice { get; set; }//Part,sentence,private
        public int M_Id { get; set; }
        public string M_Name { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public double DismembermentPrice { get; set; }
        public double SentencePrice { get; set; }
        public double PrivatePrice { get; set; }
        public double Update_Ascription { get; set; }//نسبة التعديل
       
       

    }
}
