using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Categores_Data
    {

        // بيانات الاصناف
     
     
        /// <summary>
        /// Relationship Foreign Key with Stores_Groupe
        /// </summary>
        public int SG_Id { get; set; }
        public virtual Stores.Stores_Groupe Stores_Groupe { get; set; }
        public string Groupe_Name { get; set; }
        [Key]
        public int Cat_Id { get; set; }
        public virtual ICollection<Units_Order> Units_Orders { get; set; }
        public virtual ICollection<Categores__Lower> GetCategores__Lowers { get; set; }
        public virtual ICollection<Stores.Cat_Articles> Cat_Articles { get; set; }
        public virtual ICollection<Stores.Barcode> Barcodes { get; set; }
        public virtual ICollection<Categores.Store_Outgoings> Store_Outgoings { get; set; }
        public virtual ICollection<Editorial_Store > Editorial_Stores { get; set; }
        public virtual ICollection<Stores.Nesting_Categores> Nesting_Categores { get; set; }
        public virtual ICollection<BillsSetting.Dust> Dusts { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Returns> Purchases_Returns { get; set; }
        public virtual ICollection<Al_Purchases.Purchases__Invoice> Purchases__Invoices { get; set; }
        public virtual ICollection<Al_Purchases.Purchases_Requerts> Purchases_Requerts { get; set; }
        public virtual ICollection<Al_Sales.Sales_Invoice> Sales_Invoices { get; set; }
        public string Cat_Name { get; set; }
        /// <summary>
        /// Relationship Foreign Key with Categores_Type
        /// </summary>
        public string CT_Name { get; set; }
        public virtual Categores_Type Categores_Type { get; set; }
        public string Wop_Name { get; set; }//الاسم الاجنبي
        public int  Account_Id { get; set; }// رقم الحساب للصنف هو رقم الصنف الذي يحتوية نفس الحسابايتم ادخاله هنا ادخال وبعدان يكون اّلي    
        public double Refill { get; set; }//العبوة
        /// <summary>
        /// Relattionship Foreign Key with Cat_State
        /// </summary>
        public string State { get; set; }
        public virtual Cat_State Cat_State { get; set; }
        public double Sales_Price { get; set; }
        public double Buy_Price { get; set; }
        public int U_Id { get; set; }
        public virtual Stores.Stores_Units Stores_Units { get; set; }
        public string Unit_Name { get; set; }
        public string UnitHigh { get; set; }
        public double Number { get; set; }
        /// <Stores>
        public int S_Id { get; set; }
        public string S_Name { get; set; }
        /// </Stores>
        /// <SwapCategore Table>
        public string SwapCategore { get; set; }
        //   اول مايتم تحديد صنف معين يتم جلب الاصناف البديلة له اذا كان هناك وفي الاصح يتم استخدام هذا الجدول في اماكن اخر مثل فاتورة الشراء البيع يعني تدخل الاصناف بعدها تدخل لهم اصناف بديلة  
      
        public virtual ICollection<Swap_Categores> Swap_Categores { get; set; }
        /// <summary>
        public int Article_Id { get; set; }//ارقام القطع للمخزن
        public string Location { get; set; }
        public DateTime BreakingHistory { get; set; }//تاريخ الانتهاء
        public int BreakupBeforeAlarmer { get; set; }//تنبيه قبل الانتهاء بالأيام 
        public double FloatSales { get; set; }//البيع بالكسور
        public double Categore_BageTime { get; set; }//-فترة ضمانة البيع والشراء
        //لاتعمل علاقة مع جدول التخفيضات لأنه قد تكون يدوي او اّلي من قبل النظام
        public double Decrease { get; set; }//اعطاء تخفيض 
        public string M_Id { get; set; }














    }
}

