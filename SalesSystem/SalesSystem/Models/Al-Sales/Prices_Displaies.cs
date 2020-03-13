using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Models.Al_Sales
{
    public class Prices_Displaies
    {
        //عروض الاسعار 
        [Key]
        public int PDMove_Id { get; set; }//رقم الفاتورة ويجب ان تكون متسلسلةحسب تحديد النظام

        /// <summary>
        /// نوع الدفع شيك صندوق -اجل
        /// </summary>
        public bool Cash_CheckBox { get; set; }
        public bool Cheque_CheckBox { get; set; }
        public bool Debtor_CheckBox { get; set; }//اجل
        public DateTime History { get; set; }


        /// <summary>
        /// نوع الحالة اذا كانت نهائي تتم عملية الترحيل ولا عاد يمكن التعديل غير نهائي يمكن
        /// </summary>
        public string ST_Name { get; set; }
        public virtual Al_Purchases.States_Types States_Types { get; set; }
        /// <summary>
        /// if select Cash from Box
        /// </summary>
        public int Box_Id { get; set; }
        public virtual Accounts.Boxs Boxs { get; set; }
        public string Box_Name { get; set; }
        /// <summary>
        /// if select Debtor from Supllier
        /// </summary>
        /// <summary>
        /// Cesh from Bank
        /// </summary>
        public int Bnk_Id { get; set; }
        public virtual Accounts.Banks Banks { get; set; }
        public string Bnk_Name { get; set; }
        public int ch_Id { get; set; }//number cheqe
        public string Ch_Type { get; set; }
        public DateTime Deservedness_History { get; set; }//تاريخ الاستحقاق
        public string Sight_Method { get; set; }//طريقة التسديد
        /// <summary>
        /// 
        /// </summary>
        public int Cust_Id { get; set; }
        public virtual Accounts.Customers Customers { get; set; }
        public string Cust_Name { get; set; }
        public int Sup_Id { get; set; }
        public virtual Accounts.Suppliers Suppliers { get; set; }
        public string Sup_Name { get; set; }
        public int S_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Stores Stores { get; set; }
        public string S_Name { get; set; }
        public double Transfer_Price { get; set; }
        public double StoreOnPrice { get; set; }//سعر على المخزون
        public int M_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Moneys Moneys { get; set; }
        public string M_Name { get; set; }
        public double Outgonining_Price { get; set; }//سعر الصرف
        public int C_Id { get; set; }
        public virtual Accounts.CostCenters.CostCenter CostCenter { get; set; }
        public string C_Name { get; set; }
        public string Communique { get; set; }
        // public int S_Id { get; set; }
        public virtual BillsSetting.Summation Summation { get; set; }
        public string Summation_Name { get; set; }
        public string Refference { get; set; }
        // public string M_Name { get; set; }//عملة الدفع
        public virtual Accounts.Moneys Money { get; set; }
       
        /// <summary>
        /// Lower
        /// </summary>
        public int SG_Id { get; set; }
        public virtual Categores_and_Stores.Stores.Services_Groupes Services_Groupes { get; set; }
        public string SG_Name { get; set; }
        public int Cat_Id { get; set; }
        public virtual Categores_and_Stores.Categores.Categores_Data Categores_Data { get; set; }
        public string Cat_Name { get; set; }
        public int U_Id { get; set; }
        public string U_Name { get; set; }
        public int Numbers { get; set; }
        public double SalePrice { get; set; }
        public double Final_Price { get; set; }
        public double Price_Top { get; set; }
        public DateTime BreakingHistory { get; set; }//العرض ساري حتى تاريخ
        public double Price_Less { get; set; }
        public double DismembermentPrice { get; set; }
        public double SentencePrice { get; set; }
        public double PrivatePrice { get; set; }
        public double Quantity { get; set; }
        public double Frees { get; set; }//الكمبة المجانية

        public double Total { get; set; }//المعدل بالنسبة للكمية المطلوبة من الصنف مع المجاني
        public DateTime BraekingHistory { get; set; }
        public double Ascription { get; set; }//النسبة للبيع
        public double CategoreLower { get; set; }//التخفيض بالنسبة للصنف
        public double FreeLower { get; set; }//التخفيض بالنسبة المجاني
        public double HandLower { get; set; }//التخفيض بالنسبة اليدوي
        public double AutoLower { get; set; }//التخفيض الاّلي
        public double AllTotal { get; set; }//الاجمالي الكلي بعد التخفيض ولكل
        public double Pure { get; set; }//الصافي
        public double Dust { get; set; }
    }
}
