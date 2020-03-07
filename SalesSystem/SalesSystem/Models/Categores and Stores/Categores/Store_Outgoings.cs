using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Categores_and_Stores.Categores
{
    public class Store_Outgoings
    {


        //الصرف المخزني
        //Top
        public int Move_Id { get; set; }//رقم امر الصرف
        public DateTime History { get; set; }
        public string Out_Type { get; set; }// نوع امر الصرف  
        public virtual Outginigs_Types Outginigs_Types { get; set; }
        public string State { get; set; }//نهائي او غير نهائي
        public string Const_Type { get; set; }//نوع القيد
        public virtual Editorial_Accounts.Constraints_Type Constraints_Type { get; set; }

        public int Accounte_Id { get; set; }
        public virtual Accounts.MainAccounts MainAccounts { get; set; }
        public string Accounte_Name { get; set; }
        ///// <summary>
        ///// Cesh from Box
        ///// </summary>
        ////public int Box_Id { get; set; }
        ////public String Box_Name { get; set; }
        ///// <summary>
        ///// cheqe from Bank
        ///// </summary>

        //public int Bnk_Id { get; set; }
        //public string Bnk_Name { get; set; }
        //public int ch_Id { get; set; }//number cheqe
        //public string Ch_Type { get; set; }
        //public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        //public string Sight_Method { get; set; }//طريقة التسديد
        /// <summary>
        /// 
        /// </summary>

        public int Sup_Id { get; set; }
        public virtual Accounts.Suppliers Suppliers { get; set; }
        public string Sup_Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Cust_Id { get; set; }
        public virtual Accounts.Customers Customers { get; set; }
        public string Cust_Name { get; set; }
        public int M_Id { get; set; }//Money
        public virtual Cat_Moneys Cat_Moneys { get; set; }
        public int M_Name { get; set; }//Money
        public int S_Id { get; set; }
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
        public int SG_Id { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public int Numbers { get; set; }
        public string Store { get; set; }//المخزن في حال تعدد المخازن للفاتورة
        public double Price { get; set; }
        public double Requert_Quantity { get; set; }
        public double Total { get; set; }
        public DateTime BreakingHistory { get; set; }
    }
}
