using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Stores
{
    public class StoreOutgoings_Returns
    {
        // مردود الصرف المخزني
        //Top
        [Key]
        public int SORMove_Id { get; set; }//رقم الحركة  
        /// <summary>
        /// رقم امر حركة الصرف في جدول الصرف المخزني
        /// </summary>
        public int Move_Id { get; set; }
       public virtual Categores.Store_Outgoings Store_Outgoings { get; set; }
        public int SOMove_Id { get; set; }//رقم امر الصرف
        public DateTime History { get; set; }
        public string Out_Type { get; set; }// نوع امر الصرف  
       // public virtual Categores.Outginigs_Types Outginigs_Types { get; set; }
        public string ST_Name { get; set; }//نهائي او غير نهائي
       // public virtual Al_Purchases.States_Types States_Types { get; set; }
        public string Const_Type { get; set; }//نوع القيد
       // public virtual Editorial_Accounts.Constraints_Type Constraints_Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Account_Id { get; set; }
       // public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Account_Name { get; set; }
       /// <summary>
       /// 
       /// </summary>
        public int Cust_Id { get; set; }
       //public virtual Accounts.Customers Customers { get; set; }
        public string Cust_Name { get; set; }

        public int Sup_Id { get; set; }
       // public virtual Accounts.Suppliers Suppliers { get; set; }
        public string Sup_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public int M_Id { get; set; }//Money
       // public virtual Moneys Moneys { get; set; }
        public int M_Name { get; set; }//Money
        public int S_Id { get; set; }
      //  public virtual Stores Stores { get; set; }
        public string S_Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public double TransferPrice { get; set; }//سعر التحويل
        public double StoreTransferPrice { get; set; }//سعر التحويل المخزني
        public string Communique { get; set; }
        public int Car_Id { get; set; }//السيارة
        public string Care_Name { get; set; }//اسم السائق
        public string Refference { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SG_Id { get; set; }
        //public virtual Categores_and_Stores.Stores.Stores_Groupe Stores_Groupe { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
       // public virtual Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public int U_Id { get; set; }
       // public virtual Stores_Units Stores_Units { get; set; }
        public string U_Name { get; set; }
        public int Numbers { get; set; }
        // public int M_Id { get; set; }
       // public virtual Categores.Cat_Moneys Cat_Moneys { get; set; }
        public int C_Id { get; set; }
       // public virtual Accounts.CostCenters.CostCenter CostCenter { get; set; }
        public string C_Name { get; set; }
        public string Store { get; set; }//المخزن في حال تعدد المخازن للفاتورة
        public double Price { get; set; }
        public double Requert_Quantity { get; set; }
        public double Total { get; set; }
        public DateTime BreakingHistory { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double Frees { get; set; }//الكمبة المجانية

        public double CatTotal { get; set; }//المعدل بالنسبة للكمية المطلوبة من الصنف مع المجاني
        public double CategoreLower { get; set; }//التخفيض بالنسبة للصنف
        public double FreeLower { get; set; }//التخفيض المجاني
        public double HandLower { get; set; }//التخفيض  اليدوي
        public double AutoLower { get; set; }//التخفيض الاّلي
        public double AllTotal { get; set; }//الاجمالي الكلي بعد التخفيض ولكل
        public double Pure { get; set; }//الصافي
    }
}
