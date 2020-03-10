using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Categores_Variables
    {
        // تعديل الاصناف
        [Key]
        public int Process_Id { get; set; }
        public int Groupe_Id { get; set; }
        public string Groupe_Name { get; set; }
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public string CT_Name { get; set; }
        public string Wop_Name { get; set; }//الاسم الاجنبي
        public int Account_Id { get; set; }//رقم الحساب للصنف هو رقم الصنف الذي يحتوية  الخاص فيه 
        public double Refill { get; set; }//العبوة
        public string State { get; set; }
        public double Sales_Price { get; set; }
        public double Buy_Price { get; set; }
        public int Unit_Id { get; set; }
        public string Unit_Name { get; set; }
        public string UnitHigh { get; set; }
        public double Number { get; set; }
        public int Bar_Id { get; set; }
        public int S_Id { get; set; }
        public string S_Name { get; set; }
        public string SwapCategore { get; set; }
        public int Article_Id { get; set; }//ارقام القطع للمخزن
        public string Location { get; set; }
        public DateTime BreakingHistory { get; set; }//تاريخ الانتهاء
        public int BreakupBeforeAlarmer { get; set; }//تنبيه قبل الانتهاء بالأيام 
        public double FloatSales { get; set; }//البيع بالكسور
        public double Categore_BageTime { get; set; }//-فترة ضمانة البيع والشراء
        public double Decrease { get; set; }//اعطاء تخفيض 
        public double Dust { get; set; }//تحديد الضريبه 
    }
}
