using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.System_Reports_and_Output
{
    public class Store_Quantity
    {
        //الكميات المخزنية
        [Key]
        public int Move_Id { get; set; }
        public int S_Id { get; set; }
        public string S_Name { get; set; }
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public int Number { get; set; }
        public int Article_Id { get; set; }//ارقام القطع رقم الصنيع
        public string Article_Name { get; set; }
        public int Bar_Id { get; set; }
        public string Bar_Type { get; set; }
        public DateTime History { get; set; }
        public double Quantity { get; set; }//الكمية المخزنية
        public double PartsPrice { get; set; }//سعر الحبة
        public double Total { get; set; }//الاجمالي
    }
}
